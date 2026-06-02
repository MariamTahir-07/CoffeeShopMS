using CoffeeShopMS.Data;
using CoffeeShopMS.Models;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

public partial class ProductsForm : Form
{
    public ProductsForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // categories already seeded in Designer Items collection
        cboCategory.SelectedIndex       = 0;
        cboFilterCategory.SelectedIndex = 0;
        LoadProducts();
    }

    // ── Load ─────────────────────────────────────────────────────────────────
    private void LoadProducts(string nameFilter = "", string catFilter = "")
    {
        // Step 1: read ALL rows into a plain list while connection is open
        var rows = new List<(int id, string name, string cat, double price, string desc)>();

        try
        {
            string sql = "SELECT * FROM Products WHERE IsActive=1";
            if (!string.IsNullOrWhiteSpace(nameFilter))
                sql += $" AND Name LIKE '%{nameFilter.Replace("'", "''")}%'";
            if (!string.IsNullOrWhiteSpace(catFilter) && catFilter != "All Categories")
                sql += $" AND Category='{catFilter.Replace("'", "''")}'";
            sql += " ORDER BY Category, Name";

            using var conn   = DatabaseHelper.GetConnection();
            using var cmd    = new SQLiteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                rows.Add((
                    Convert.ToInt32(reader["Id"]),
                    reader["Name"].ToString()!,
                    reader["Category"].ToString()!,
                    Convert.ToDouble(reader["Price"]),
                    reader["Description"]?.ToString() ?? ""));
        }   // <-- connection closed here
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading products:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Step 2: update UI — no connection open at this point
        dgvProducts.Rows.Clear();
        foreach (var r in rows)
            dgvProducts.Rows.Add(r.id, r.name, r.cat, $"Rs. {r.price:0.00}", r.desc);

        lblCount.Text = $"{rows.Count} product(s) found";
    }

    // ── Grid selection → populate form ───────────────────────────────────────
    private void dgvProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count == 0) return;
        var row = dgvProducts.SelectedRows[0];
        txtProductId.Text    = row.Cells["colId"].Value?.ToString()   ?? "";
        txtName.Text         = row.Cells["colName"].Value?.ToString() ?? "";
        cboCategory.Text     = row.Cells["colCategory"].Value?.ToString() ?? "";
        string rawPrice      = row.Cells["colPrice"].Value?.ToString()?.Replace("Rs. ", "") ?? "0";
        txtPrice.Text        = rawPrice;
        txtDescription.Text  = row.Cells["colDesc"].Value?.ToString() ?? "";
    }

    // ── Add ──────────────────────────────────────────────────────────────────
    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateForm()) return;
        try
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd  = new SQLiteCommand(
                "INSERT INTO Products (Name,Category,Price,Description) VALUES (@n,@c,@p,@d)", conn);
            cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@c", cboCategory.Text);
            cmd.Parameters.AddWithValue("@p", double.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@d", txtDescription.Text.Trim());
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding product:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        MessageBox.Show("Product added successfully!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
        LoadProducts();
    }

    // ── Update ───────────────────────────────────────────────────────────────
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtProductId.Text))
        {
            MessageBox.Show("Select a product from the list first.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!ValidateForm()) return;
        try
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd  = new SQLiteCommand(
                "UPDATE Products SET Name=@n,Category=@c,Price=@p,Description=@d WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtProductId.Text));
            cmd.Parameters.AddWithValue("@n",  txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@c",  cboCategory.Text);
            cmd.Parameters.AddWithValue("@p",  double.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@d",  txtDescription.Text.Trim());
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating product:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        MessageBox.Show("Product updated!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
        LoadProducts();
    }

    // ── Delete ───────────────────────────────────────────────────────────────
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtProductId.Text))
        {
            MessageBox.Show("Select a product from the list first.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (MessageBox.Show("Delete this product?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        try
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd  = new SQLiteCommand(
                "UPDATE Products SET IsActive=0 WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtProductId.Text));
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting product:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        MessageBox.Show("Product deleted!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
        LoadProducts();
    }

    // ── Search ───────────────────────────────────────────────────────────────
    private void btnSearch_Click(object sender, EventArgs e)
    {
        string cat = cboFilterCategory.SelectedIndex == 0 ? "" : cboFilterCategory.Text;
        LoadProducts(txtSearch.Text.Trim(), cat);
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
    }

    // ── Clear ────────────────────────────────────────────────────────────────
    private void btnClear_Click(object sender, EventArgs e) => ClearForm();

    private void ClearForm()
    {
        txtProductId.Text   = "";
        txtName.Text        = "";
        txtPrice.Text       = "";
        txtDescription.Text = "";
        cboCategory.SelectedIndex = 0;
        txtName.Focus();
    }

    // ── Validation ───────────────────────────────────────────────────────────
    private bool ValidateForm()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Product name is required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
        {
            MessageBox.Show("Please enter a valid price greater than 0.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }
}
