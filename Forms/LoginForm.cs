using CoffeeShopMS.Data;
using CoffeeShopMS.Models;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Please enter username and password.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Read user data → close connection → THEN verify BCrypt (BCrypt is slow, keep it outside the conn)
        string? storedHash = null;
        User?   foundUser  = null;

        try
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd  = new SQLiteCommand(
                "SELECT Id, Username, Password, Role FROM Users WHERE Username=@u", conn);
            cmd.Parameters.AddWithValue("@u", username);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                storedHash = reader["Password"].ToString();
                foundUser  = new User
                {
                    Id       = Convert.ToInt32(reader["Id"]),
                    Username = reader["Username"].ToString()!,
                    Role     = reader["Role"].ToString()!
                };
            }
        }   // <-- conn fully closed here before BCrypt runs
        catch (Exception ex)
        {
            MessageBox.Show($"Database error: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (storedHash != null && foundUser != null &&
            BCrypt.Net.BCrypt.Verify(password, storedHash))
        {
            Session.CurrentUser = foundUser;
            Hide();
            new DashboardForm().ShowDialog();
            Show();
            txtPassword.Clear();
        }
        else
        {
            MessageBox.Show("Invalid username or password.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
    }
}
