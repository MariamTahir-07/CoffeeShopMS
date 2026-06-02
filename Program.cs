using CoffeeShopMS.Data;
using CoffeeShopMS.Forms;

namespace CoffeeShopMS;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        DatabaseHelper.InitializeDatabase();
        Application.Run(new LoginForm());
    }
}
