using CoffeeShopMS.Models;

namespace CoffeeShopMS.Forms;

public partial class BillingForm : Form
{
    private readonly int            _orderId;
    private readonly string         _customerName;
    private readonly List<CartItem> _items;
    private readonly double         _total;

    public BillingForm(int orderId, string customerName, List<CartItem> items, double total)
    {
        _orderId      = orderId;
        _customerName = customerName;
        _items        = items;
        _total        = total;
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        BuildBill();
    }

    private void BuildBill()
    {
        rtbBill.Clear();

        void AppendCentered(string text, Font font, Color color)
        {
            rtbBill.SelectionAlignment = HorizontalAlignment.Center;
            rtbBill.SelectionFont      = font;
            rtbBill.SelectionColor     = color;
            rtbBill.AppendText(text + "\n");
        }
        void AppendLeft(string text, Font font, Color color)
        {
            rtbBill.SelectionAlignment = HorizontalAlignment.Left;
            rtbBill.SelectionFont      = font;
            rtbBill.SelectionColor     = color;
            rtbBill.AppendText(text + "\n");
        }

        var f14b  = new Font("Courier New", 14F, FontStyle.Bold);
        var f9    = new Font("Courier New",  9F);
        var f9b   = new Font("Courier New",  9F, FontStyle.Bold);
        var f10b  = new Font("Courier New", 10F, FontStyle.Bold);
        var brown = Color.FromArgb(74, 44, 29);
        var gray  = Color.Gray;
        var black = Color.Black;

        AppendCentered("COFFEE SHOP",       f14b, brown);
        AppendCentered("Management System", f9,   gray);
        AppendLeft(new string('-', 46),     f9,   gray);
        AppendLeft($"Order # : {_orderId:0000}",                       f9, black);
        AppendLeft($"Date    : {DateTime.Now:dd-MMM-yyyy  hh:mm tt}",  f9, black);
        AppendLeft($"Name    : {_customerName}",                        f9, black);
        AppendLeft($"Server  : {Session.CurrentUser?.Username}",        f9, black);
        AppendLeft(new string('-', 46),     f9, gray);
        AppendLeft($"{"ITEM",-22}{"QTY",5}{"PRICE",9}{"TOTAL",9}",    f9b, black);
        AppendLeft(new string('-', 46),     f9, gray);

        foreach (var item in _items)
        {
            string name = item.ProductName.Length > 21
                ? item.ProductName[..21] : item.ProductName;
            AppendLeft(
                $"{name,-22}{item.Quantity,5}{item.UnitPrice,9:0.00}{item.SubTotal,9:0.00}",
                f9, black);
        }

        AppendLeft(new string('-', 46), f9, gray);

        rtbBill.SelectionAlignment = HorizontalAlignment.Right;
        rtbBill.SelectionFont      = f10b;
        rtbBill.SelectionColor     = brown;
        rtbBill.AppendText($"TOTAL:  Rs. {_total:0.00}\n");

        AppendLeft(new string('-', 46), f9, gray);
        AppendCentered("\nThank you for visiting!", f9, gray);
        AppendCentered("Please come again  :)",     f9, gray);

        // dispose local font objects
        f14b.Dispose(); f9.Dispose(); f9b.Dispose(); f10b.Dispose();
    }

    // ── Print using PrintDocument (RichTextBox.Print() does not exist in .NET 8) ──
    private void btnPrint_Click(object sender, EventArgs e)
    {
        using var pd = new System.Drawing.Printing.PrintDocument();
        pd.PrintPage += PrintBillPage;
        using var preview = new PrintPreviewDialog
        {
            Document        = pd,
            Width           = 640,
            Height          = 800,
            StartPosition   = FormStartPosition.CenterParent
        };
        preview.ShowDialog(this);
    }

    private void PrintBillPage(object sender,
        System.Drawing.Printing.PrintPageEventArgs e)
    {
        var    g     = e.Graphics!;
        float  x     = 60f;
        float  y     = 40f;
        const float lh = 18f;

        using var f14b = new Font("Courier New", 14F, FontStyle.Bold);
        using var f9   = new Font("Courier New",  9F);
        using var f9b  = new Font("Courier New",  9F, FontStyle.Bold);
        using var f10b = new Font("Courier New", 10F, FontStyle.Bold);

        var brown = Color.FromArgb(74, 44, 29);

        void Line(string text, Font font, Brush brush, bool center = false)
        {
            float dx = center
                ? (e.PageBounds.Width - g.MeasureString(text, font).Width) / 2f
                : x;
            g.DrawString(text, font, brush, dx, y);
            y += lh;
        }
        void Div() { g.DrawLine(Pens.Gray, x, y, e.PageBounds.Width - x, y); y += 6f; }

        Line("COFFEE SHOP",       f14b, new SolidBrush(brown), center: true);
        Line("Management System", f9,   Brushes.Gray,          center: true);
        y += 4; Div();
        Line($"Order # : {_orderId:0000}",                       f9, Brushes.Black);
        Line($"Date    : {DateTime.Now:dd-MMM-yyyy  hh:mm tt}",  f9, Brushes.Black);
        Line($"Name    : {_customerName}",                        f9, Brushes.Black);
        Line($"Server  : {Session.CurrentUser?.Username}",        f9, Brushes.Black);
        Div();
        Line($"{"ITEM",-22}{"QTY",5}{"PRICE",9}{"TOTAL",9}",    f9b, Brushes.Black);
        Div();
        foreach (var item in _items)
        {
            string name = item.ProductName.Length > 21
                ? item.ProductName[..21] : item.ProductName;
            Line($"{name,-22}{item.Quantity,5}{item.UnitPrice,9:0.00}{item.SubTotal,9:0.00}",
                f9, Brushes.Black);
        }
        Div();
        string totLine = $"TOTAL:  Rs. {_total:0.00}";
        float  tw      = g.MeasureString(totLine, f10b).Width;
        g.DrawString(totLine, f10b, new SolidBrush(brown),
            e.PageBounds.Width - x - tw, y);
        y += lh + 4; Div(); y += 6;
        Line("Thank you for visiting!", f9, Brushes.Gray, center: true);
        Line("Please come again  :)",   f9, Brushes.Gray, center: true);

        e.HasMorePages = false;
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}
