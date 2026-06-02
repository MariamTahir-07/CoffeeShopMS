using CoffeeShopMS.Data;
using CoffeeShopMS.Models;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        lblWelcome.Text = $"Welcome, {Session.CurrentUser?.Username}  ({Session.CurrentUser?.Role})";
        LoadStats();
    }

    private void LoadStats()
    {
        try
        {
            using var conn = DatabaseHelper.GetConnection();
            lblStatProducts.Text = GetCount(conn, "Products", "WHERE IsActive=1").ToString();
            lblStatOrders.Text   = GetCount(conn, "Orders", "").ToString();
            lblStatToday.Text    = GetCount(conn, "Orders", "WHERE DATE(OrderDate)=DATE('now')").ToString();

            using var cmd = new SQLiteCommand(
                "SELECT IFNULL(SUM(TotalAmount),0) FROM Orders WHERE DATE(OrderDate)=DATE('now')", conn);
            double rev = Convert.ToDouble(cmd.ExecuteScalar());
            lblStatRevenue.Text = $"Rs. {rev:0.00}";
        }
        catch { /* stats are optional */ }
    }

    private static int GetCount(SQLiteConnection conn, string table, string where)
    {
        using var cmd = new SQLiteCommand($"SELECT COUNT(*) FROM {table} {where}", conn);
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        using var f = new ProductsForm();
        f.ShowDialog(this);
        LoadStats();
    }

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
        using var f = new OrderForm();
        f.ShowDialog(this);
        LoadStats();
    }

    private void btnOrders_Click(object sender, EventArgs e)
    {
        using var f = new OrdersListForm();
        f.ShowDialog(this);
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Session.CurrentUser = null;
            Close();
        }
    }
}
