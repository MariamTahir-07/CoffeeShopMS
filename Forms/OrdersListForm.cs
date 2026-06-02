using CoffeeShopMS.Data;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

public partial class OrdersListForm : Form
{
    public OrdersListForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        LoadOrders();
    }

    // ── Load orders: read ALL rows into memory → close → update grid ─────────
    private void LoadOrders(string filter = "")
    {
        var rows = new List<(object id, object date, object cust, string total, object status, object server)>();

        try
        {
            string sql =
                @"SELECT o.Id, o.OrderDate, o.CustomerName,
                         o.TotalAmount, o.Status, u.Username AS Server
                  FROM   Orders o
                  LEFT JOIN Users u ON u.Id = o.CreatedBy";

            if (!string.IsNullOrWhiteSpace(filter))
                sql += $" WHERE o.CustomerName LIKE '%{filter.Replace("'", "''")}%'";

            sql += " ORDER BY o.Id DESC";

            using var conn   = DatabaseHelper.GetConnection();
            using var cmd    = new SQLiteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                rows.Add((
                    reader["Id"],
                    reader["OrderDate"],
                    reader["CustomerName"],
                    $"Rs.{Convert.ToDouble(reader["TotalAmount"]):0.00}",
                    reader["Status"],
                    reader["Server"]
                ));
        }   // conn closed here
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading orders:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        dgvOrders.Rows.Clear();
        dgvDetails.Rows.Clear();
        foreach (var r in rows)
            dgvOrders.Rows.Add(r.id, r.date, r.cust, r.total, r.status, r.server);

        lblCount.Text = $"{rows.Count} order(s)";
    }

    // ── Order row selected → load its detail lines ───────────────────────────
    private void dgvOrders_SelectionChanged(object sender, EventArgs e)
    {
        dgvDetails.Rows.Clear();
        if (dgvOrders.SelectedRows.Count == 0) return;

        var cell = dgvOrders.SelectedRows[0].Cells["colOrdId"].Value;
        if (cell == null) return;
        int orderId = Convert.ToInt32(cell);

        var details = new List<(int qty, string name, string up, string sub)>();

        try
        {
            using var conn   = DatabaseHelper.GetConnection();
            using var cmd    = new SQLiteCommand(
                @"SELECT od.Quantity, p.Name, od.UnitPrice, od.SubTotal
                  FROM   OrderDetails od
                  JOIN   Products     p  ON p.Id = od.ProductId
                  WHERE  od.OrderId = @id", conn);
            cmd.Parameters.AddWithValue("@id", orderId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                details.Add((
                    Convert.ToInt32(reader["Quantity"]),
                    reader["Name"].ToString()!,
                    $"Rs.{Convert.ToDouble(reader["UnitPrice"]):0.00}",
                    $"Rs.{Convert.ToDouble(reader["SubTotal"]):0.00}"
                ));
        }   // conn closed here
        catch { /* non-critical — leave detail grid empty */ }

        foreach (var d in details)
            dgvDetails.Rows.Add(d.qty, d.name, d.up, d.sub);
    }

    private void btnSearch_Click(object sender, EventArgs e) =>
        LoadOrders(txtSearch.Text.Trim());

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        LoadOrders();
    }
}
