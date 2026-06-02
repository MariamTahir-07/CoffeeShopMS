using CoffeeShopMS.Data;
using CoffeeShopMS.Models;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

public partial class OrderForm : Form
{
    private readonly List<Product>  _products = new();
    private readonly List<CartItem> _cart     = new();

    public OrderForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        LoadProducts();
        RefreshCart();
    }

    // ── Load products: read ALL into memory, close conn, then populate ListBox ──
    private void LoadProducts()
    {
        var list = new List<Product>();
        try
        {
            using var conn   = DatabaseHelper.GetConnection();
            using var cmd    = new SQLiteCommand(
                "SELECT Id,Name,Category,Price FROM Products WHERE IsActive=1 ORDER BY Category,Name", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new Product
                {
                    Id       = Convert.ToInt32(reader["Id"]),
                    Name     = reader["Name"].ToString()!,
                    Category = reader["Category"].ToString()!,
                    Price    = Convert.ToDouble(reader["Price"])
                });
        }   // conn closed here
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading products:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _products.Clear();
        _products.AddRange(list);

        lstProducts.Items.Clear();
        foreach (var p in _products)
            lstProducts.Items.Add($"[{p.Category}]  {p.Name}  —  Rs.{p.Price:0.00}");
    }

    // ── Add to cart ──────────────────────────────────────────────────────────
    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        if (lstProducts.SelectedIndex < 0)
        {
            MessageBox.Show("Please select a product.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
        {
            MessageBox.Show("Please enter a valid quantity (number > 0).", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var product  = _products[lstProducts.SelectedIndex];
        var existing = _cart.FirstOrDefault(c => c.ProductId == product.Id);
        if (existing != null)
            existing.Quantity += qty;
        else
            _cart.Add(new CartItem
            {
                ProductId   = product.Id,
                ProductName = product.Name,
                Quantity    = qty,
                UnitPrice   = product.Price
            });

        RefreshCart();
        txtQty.Text = "1";
    }

    private void lstProducts_DoubleClick(object sender, EventArgs e) =>
        btnAddToCart_Click(sender, e);

    // ── Remove from cart ─────────────────────────────────────────────────────
    private void btnRemoveFromCart_Click(object sender, EventArgs e)
    {
        if (dgvCart.SelectedRows.Count == 0) return;
        int idx = dgvCart.SelectedRows[0].Index;
        if (idx >= 0 && idx < _cart.Count)
        {
            _cart.RemoveAt(idx);
            RefreshCart();
        }
    }

    // ── Clear cart ───────────────────────────────────────────────────────────
    private void btnClearCart_Click(object sender, EventArgs e)
    {
        if (_cart.Count == 0) return;
        if (MessageBox.Show("Clear entire cart?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _cart.Clear();
            RefreshCart();
        }
    }

    // ── Refresh cart grid ────────────────────────────────────────────────────
    private void RefreshCart()
    {
        dgvCart.Rows.Clear();
        double total = 0;
        foreach (var item in _cart)
        {
            dgvCart.Rows.Add(item.ProductName, item.Quantity,
                $"Rs.{item.UnitPrice:0.00}", $"Rs.{item.SubTotal:0.00}");
            total += item.SubTotal;
        }
        lblTotal.Text = $"Total:  Rs. {total:0.00}";
    }

    // ── Place order: open → insert → commit → close → THEN show bill ────────
    private void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        if (_cart.Count == 0)
        {
            MessageBox.Show("Cart is empty. Add items first.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string customerName = txtCustomerName.Text.Trim();
        if (string.IsNullOrWhiteSpace(customerName))
            customerName = "Walk-in Customer";

        double total   = _cart.Sum(c => c.SubTotal);
        int    orderId = 0;

        try
        {
            using var conn = DatabaseHelper.GetConnection();
            using var tx   = conn.BeginTransaction();

            // 1. Insert order
            using (var cmdOrder = new SQLiteCommand(
                @"INSERT INTO Orders (CustomerName,TotalAmount,Status,CreatedBy)
                  VALUES (@cn,@ta,'Completed',@cb);
                  SELECT last_insert_rowid();", conn, tx))
            {
                cmdOrder.Parameters.AddWithValue("@cn", customerName);
                cmdOrder.Parameters.AddWithValue("@ta", total);
                cmdOrder.Parameters.AddWithValue("@cb", Session.CurrentUser!.Id);
                orderId = Convert.ToInt32(cmdOrder.ExecuteScalar());
            }

            // 2. Insert each cart line — new command object per iteration
            foreach (var item in _cart)
            {
                using var cmdLine = new SQLiteCommand(
                    @"INSERT INTO OrderDetails
                      (OrderId,ProductId,Quantity,UnitPrice,SubTotal)
                      VALUES (@oid,@pid,@qty,@up,@st)", conn, tx);
                cmdLine.Parameters.AddWithValue("@oid", orderId);
                cmdLine.Parameters.AddWithValue("@pid", item.ProductId);
                cmdLine.Parameters.AddWithValue("@qty", item.Quantity);
                cmdLine.Parameters.AddWithValue("@up",  item.UnitPrice);
                cmdLine.Parameters.AddWithValue("@st",  item.SubTotal);
                cmdLine.ExecuteNonQuery();
            }

            tx.Commit();
        }   // <-- conn fully closed before BillingForm opens
        catch (Exception ex)
        {
            MessageBox.Show($"Error placing order:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 3. Snapshot cart, clear it, THEN open billing — no connection is open
        var snapshot = new List<CartItem>(_cart);
        _cart.Clear();
        RefreshCart();
        txtCustomerName.Clear();

        using var bill = new BillingForm(orderId, customerName, snapshot, total);
        bill.ShowDialog(this);
    }
}
