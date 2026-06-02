namespace CoffeeShopMS.Forms;

partial class DashboardForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.panelTop = new System.Windows.Forms.Panel();
        this.lblAppTitle = new System.Windows.Forms.Label();
        this.lblWelcome = new System.Windows.Forms.Label();
        this.btnLogout = new System.Windows.Forms.Button();
        this.panelNav = new System.Windows.Forms.Panel();
        this.btnProducts = new System.Windows.Forms.Button();
        this.btnNewOrder = new System.Windows.Forms.Button();
        this.btnOrders = new System.Windows.Forms.Button();
        this.panelStats = new System.Windows.Forms.Panel();
        this.lblDashTitle = new System.Windows.Forms.Label();
        this.card1 = new System.Windows.Forms.Panel();
        this.lblCapProducts = new System.Windows.Forms.Label();
        this.lblStatProducts = new System.Windows.Forms.Label();
        this.card2 = new System.Windows.Forms.Panel();
        this.lblCapOrders = new System.Windows.Forms.Label();
        this.lblStatOrders = new System.Windows.Forms.Label();
        this.card3 = new System.Windows.Forms.Panel();
        this.lblCapToday = new System.Windows.Forms.Label();
        this.lblStatToday = new System.Windows.Forms.Label();
        this.card4 = new System.Windows.Forms.Panel();
        this.lblCapRevenue = new System.Windows.Forms.Label();
        this.lblStatRevenue = new System.Windows.Forms.Label();

        this.panelTop.SuspendLayout();
        this.panelNav.SuspendLayout();
        this.panelStats.SuspendLayout();
        this.card1.SuspendLayout();
        this.card2.SuspendLayout();
        this.card3.SuspendLayout();
        this.card4.SuspendLayout();
        this.SuspendLayout();

        // panelTop
        this.panelTop.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.panelTop.Controls.Add(this.btnLogout);
        this.panelTop.Controls.Add(this.lblWelcome);
        this.panelTop.Controls.Add(this.lblAppTitle);
        this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelTop.Location = new System.Drawing.Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new System.Drawing.Size(920, 65);
        this.panelTop.TabIndex = 0;

        // lblAppTitle
        this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(255, 213, 128);
        this.lblAppTitle.Location = new System.Drawing.Point(15, 15);
        this.lblAppTitle.Name = "lblAppTitle";
        this.lblAppTitle.Size = new System.Drawing.Size(420, 35);
        this.lblAppTitle.TabIndex = 0;
        this.lblAppTitle.Text = "Coffee Shop Management System";

        // lblWelcome
        this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(200, 180, 160);
        this.lblWelcome.Location = new System.Drawing.Point(440, 22);
        this.lblWelcome.Name = "lblWelcome";
        this.lblWelcome.Size = new System.Drawing.Size(340, 20);
        this.lblWelcome.TabIndex = 1;
        this.lblWelcome.Text = "Welcome";

        // btnLogout
        this.btnLogout.BackColor = System.Drawing.Color.FromArgb(180, 60, 40);
        this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogout.FlatAppearance.BorderSize = 0;
        this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnLogout.ForeColor = System.Drawing.Color.White;
        this.btnLogout.Location = new System.Drawing.Point(810, 17);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(90, 32);
        this.btnLogout.TabIndex = 2;
        this.btnLogout.Text = "Logout";
        this.btnLogout.UseVisualStyleBackColor = false;
        this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

        // panelNav
        this.panelNav.BackColor = System.Drawing.Color.FromArgb(60, 35, 20);
        this.panelNav.Controls.Add(this.btnOrders);
        this.panelNav.Controls.Add(this.btnNewOrder);
        this.panelNav.Controls.Add(this.btnProducts);
        this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelNav.Location = new System.Drawing.Point(0, 65);
        this.panelNav.Name = "panelNav";
        this.panelNav.Size = new System.Drawing.Size(200, 515);
        this.panelNav.TabIndex = 1;

        // btnProducts
        this.btnProducts.BackColor = System.Drawing.Color.FromArgb(60, 35, 20);
        this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnProducts.FlatAppearance.BorderSize = 0;
        this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(230, 210, 190);
        this.btnProducts.Location = new System.Drawing.Point(0, 20);
        this.btnProducts.Name = "btnProducts";
        this.btnProducts.Size = new System.Drawing.Size(200, 52);
        this.btnProducts.TabIndex = 0;
        this.btnProducts.Text = "   Products";
        this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnProducts.UseVisualStyleBackColor = false;
        this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);

        // btnNewOrder
        this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(60, 35, 20);
        this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNewOrder.FlatAppearance.BorderSize = 0;
        this.btnNewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnNewOrder.ForeColor = System.Drawing.Color.FromArgb(230, 210, 190);
        this.btnNewOrder.Location = new System.Drawing.Point(0, 80);
        this.btnNewOrder.Name = "btnNewOrder";
        this.btnNewOrder.Size = new System.Drawing.Size(200, 52);
        this.btnNewOrder.TabIndex = 1;
        this.btnNewOrder.Text = "   New Order";
        this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNewOrder.UseVisualStyleBackColor = false;
        this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);

        // btnOrders
        this.btnOrders.BackColor = System.Drawing.Color.FromArgb(60, 35, 20);
        this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnOrders.FlatAppearance.BorderSize = 0;
        this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(230, 210, 190);
        this.btnOrders.Location = new System.Drawing.Point(0, 140);
        this.btnOrders.Name = "btnOrders";
        this.btnOrders.Size = new System.Drawing.Size(200, 52);
        this.btnOrders.TabIndex = 2;
        this.btnOrders.Text = "   Orders";
        this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnOrders.UseVisualStyleBackColor = false;
        this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);

        // panelStats
        this.panelStats.BackColor = System.Drawing.Color.FromArgb(245, 240, 235);
        this.panelStats.Controls.Add(this.card4);
        this.panelStats.Controls.Add(this.card3);
        this.panelStats.Controls.Add(this.card2);
        this.panelStats.Controls.Add(this.card1);
        this.panelStats.Controls.Add(this.lblDashTitle);
        this.panelStats.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelStats.Location = new System.Drawing.Point(200, 65);
        this.panelStats.Name = "panelStats";
        this.panelStats.Size = new System.Drawing.Size(720, 515);
        this.panelStats.TabIndex = 2;

        // lblDashTitle
        this.lblDashTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblDashTitle.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblDashTitle.Location = new System.Drawing.Point(30, 20);
        this.lblDashTitle.Name = "lblDashTitle";
        this.lblDashTitle.Size = new System.Drawing.Size(300, 30);
        this.lblDashTitle.TabIndex = 0;
        this.lblDashTitle.Text = "Dashboard Overview";

        // card1 — Active Products
        this.card1.BackColor = System.Drawing.Color.White;
        this.card1.Controls.Add(this.lblStatProducts);
        this.card1.Controls.Add(this.lblCapProducts);
        this.card1.Location = new System.Drawing.Point(30, 65);
        this.card1.Name = "card1";
        this.card1.Size = new System.Drawing.Size(150, 120);
        this.card1.TabIndex = 1;

        this.lblCapProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblCapProducts.ForeColor = System.Drawing.Color.Gray;
        this.lblCapProducts.Location = new System.Drawing.Point(12, 12);
        this.lblCapProducts.Name = "lblCapProducts";
        this.lblCapProducts.Size = new System.Drawing.Size(126, 20);
        this.lblCapProducts.TabIndex = 0;
        this.lblCapProducts.Text = "Active Products";

        this.lblStatProducts.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
        this.lblStatProducts.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblStatProducts.Location = new System.Drawing.Point(12, 38);
        this.lblStatProducts.Name = "lblStatProducts";
        this.lblStatProducts.Size = new System.Drawing.Size(126, 70);
        this.lblStatProducts.TabIndex = 1;
        this.lblStatProducts.Text = "0";
        this.lblStatProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // card2 — Total Orders
        this.card2.BackColor = System.Drawing.Color.White;
        this.card2.Controls.Add(this.lblStatOrders);
        this.card2.Controls.Add(this.lblCapOrders);
        this.card2.Location = new System.Drawing.Point(200, 65);
        this.card2.Name = "card2";
        this.card2.Size = new System.Drawing.Size(150, 120);
        this.card2.TabIndex = 2;

        this.lblCapOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblCapOrders.ForeColor = System.Drawing.Color.Gray;
        this.lblCapOrders.Location = new System.Drawing.Point(12, 12);
        this.lblCapOrders.Name = "lblCapOrders";
        this.lblCapOrders.Size = new System.Drawing.Size(126, 20);
        this.lblCapOrders.TabIndex = 0;
        this.lblCapOrders.Text = "Total Orders";

        this.lblStatOrders.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
        this.lblStatOrders.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
        this.lblStatOrders.Location = new System.Drawing.Point(12, 38);
        this.lblStatOrders.Name = "lblStatOrders";
        this.lblStatOrders.Size = new System.Drawing.Size(126, 70);
        this.lblStatOrders.TabIndex = 1;
        this.lblStatOrders.Text = "0";
        this.lblStatOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // card3 — Orders Today
        this.card3.BackColor = System.Drawing.Color.White;
        this.card3.Controls.Add(this.lblStatToday);
        this.card3.Controls.Add(this.lblCapToday);
        this.card3.Location = new System.Drawing.Point(370, 65);
        this.card3.Name = "card3";
        this.card3.Size = new System.Drawing.Size(150, 120);
        this.card3.TabIndex = 3;

        this.lblCapToday.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblCapToday.ForeColor = System.Drawing.Color.Gray;
        this.lblCapToday.Location = new System.Drawing.Point(12, 12);
        this.lblCapToday.Name = "lblCapToday";
        this.lblCapToday.Size = new System.Drawing.Size(126, 20);
        this.lblCapToday.TabIndex = 0;
        this.lblCapToday.Text = "Orders Today";

        this.lblStatToday.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
        this.lblStatToday.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
        this.lblStatToday.Location = new System.Drawing.Point(12, 38);
        this.lblStatToday.Name = "lblStatToday";
        this.lblStatToday.Size = new System.Drawing.Size(126, 70);
        this.lblStatToday.TabIndex = 1;
        this.lblStatToday.Text = "0";
        this.lblStatToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // card4 — Revenue Today
        this.card4.BackColor = System.Drawing.Color.White;
        this.card4.Controls.Add(this.lblStatRevenue);
        this.card4.Controls.Add(this.lblCapRevenue);
        this.card4.Location = new System.Drawing.Point(540, 65);
        this.card4.Name = "card4";
        this.card4.Size = new System.Drawing.Size(150, 120);
        this.card4.TabIndex = 4;

        this.lblCapRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblCapRevenue.ForeColor = System.Drawing.Color.Gray;
        this.lblCapRevenue.Location = new System.Drawing.Point(12, 12);
        this.lblCapRevenue.Name = "lblCapRevenue";
        this.lblCapRevenue.Size = new System.Drawing.Size(126, 20);
        this.lblCapRevenue.TabIndex = 0;
        this.lblCapRevenue.Text = "Revenue Today";

        this.lblStatRevenue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblStatRevenue.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
        this.lblStatRevenue.Location = new System.Drawing.Point(8, 35);
        this.lblStatRevenue.Name = "lblStatRevenue";
        this.lblStatRevenue.Size = new System.Drawing.Size(134, 75);
        this.lblStatRevenue.TabIndex = 1;
        this.lblStatRevenue.Text = "Rs.0";
        this.lblStatRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // DashboardForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(920, 580);
        this.Controls.Add(this.panelStats);
        this.Controls.Add(this.panelNav);
        this.Controls.Add(this.panelTop);
        this.MinimumSize = new System.Drawing.Size(940, 620);
        this.Name = "DashboardForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Coffee Shop MS - Dashboard";

        this.panelTop.ResumeLayout(false);
        this.panelNav.ResumeLayout(false);
        this.panelStats.ResumeLayout(false);
        this.card1.ResumeLayout(false);
        this.card2.ResumeLayout(false);
        this.card3.ResumeLayout(false);
        this.card4.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblAppTitle;
    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Panel panelNav;
    private System.Windows.Forms.Button btnProducts;
    private System.Windows.Forms.Button btnNewOrder;
    private System.Windows.Forms.Button btnOrders;
    private System.Windows.Forms.Panel panelStats;
    private System.Windows.Forms.Label lblDashTitle;
    private System.Windows.Forms.Panel card1;
    private System.Windows.Forms.Label lblCapProducts;
    private System.Windows.Forms.Label lblStatProducts;
    private System.Windows.Forms.Panel card2;
    private System.Windows.Forms.Label lblCapOrders;
    private System.Windows.Forms.Label lblStatOrders;
    private System.Windows.Forms.Panel card3;
    private System.Windows.Forms.Label lblCapToday;
    private System.Windows.Forms.Label lblStatToday;
    private System.Windows.Forms.Panel card4;
    private System.Windows.Forms.Label lblCapRevenue;
    private System.Windows.Forms.Label lblStatRevenue;
}
