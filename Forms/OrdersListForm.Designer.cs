namespace CoffeeShopMS.Forms;

partial class OrdersListForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.panelTop    = new System.Windows.Forms.Panel();
        this.lblTitle    = new System.Windows.Forms.Label();
        this.panelFilter = new System.Windows.Forms.Panel();
        this.txtSearch   = new System.Windows.Forms.TextBox();
        this.btnSearch   = new System.Windows.Forms.Button();
        this.btnRefresh  = new System.Windows.Forms.Button();
        this.lblCount    = new System.Windows.Forms.Label();
        this.splitMain   = new System.Windows.Forms.SplitContainer();
        this.dgvOrders   = new System.Windows.Forms.DataGridView();
        this.colOrdId    = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colOrdDate  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colOrdCust  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colOrdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colOrdStat  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colOrdServ  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lblDetails  = new System.Windows.Forms.Label();
        this.dgvDetails  = new System.Windows.Forms.DataGridView();
        this.colDetQty   = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDetProd  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDetUp    = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDetSub   = new System.Windows.Forms.DataGridViewTextBoxColumn();

        this.panelTop.SuspendLayout();
        this.panelFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
        this.splitMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
        this.SuspendLayout();

        // panelTop
        this.panelTop.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelTop.Location = new System.Drawing.Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new System.Drawing.Size(900, 50);
        this.panelTop.TabIndex = 0;

        // lblTitle
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 213, 128);
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(900, 50);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Orders History";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // panelFilter
        this.panelFilter.BackColor = System.Drawing.Color.White;
        this.panelFilter.Controls.Add(this.lblCount);
        this.panelFilter.Controls.Add(this.btnRefresh);
        this.panelFilter.Controls.Add(this.btnSearch);
        this.panelFilter.Controls.Add(this.txtSearch);
        this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelFilter.Location = new System.Drawing.Point(0, 50);
        this.panelFilter.Name = "panelFilter";
        this.panelFilter.Size = new System.Drawing.Size(900, 48);
        this.panelFilter.TabIndex = 1;

        // txtSearch
        this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtSearch.Location = new System.Drawing.Point(10, 12);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(240, 25);
        this.txtSearch.TabIndex = 0;

        // btnSearch
        this.btnSearch.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSearch.FlatAppearance.BorderSize = 0;
        this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnSearch.ForeColor = System.Drawing.Color.White;
        this.btnSearch.Location = new System.Drawing.Point(260, 10);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(110, 30);
        this.btnSearch.TabIndex = 1;
        this.btnSearch.Text = "Search";
        this.btnSearch.UseVisualStyleBackColor = false;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

        // btnRefresh
        this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
        this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRefresh.FlatAppearance.BorderSize = 0;
        this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnRefresh.ForeColor = System.Drawing.Color.White;
        this.btnRefresh.Location = new System.Drawing.Point(380, 10);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(110, 30);
        this.btnRefresh.TabIndex = 2;
        this.btnRefresh.Text = "Refresh";
        this.btnRefresh.UseVisualStyleBackColor = false;
        this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

        // lblCount
        this.lblCount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
        this.lblCount.ForeColor = System.Drawing.Color.Gray;
        this.lblCount.Location = new System.Drawing.Point(500, 15);
        this.lblCount.Name = "lblCount";
        this.lblCount.Size = new System.Drawing.Size(200, 20);
        this.lblCount.TabIndex = 3;
        this.lblCount.Text = "";

        // splitMain
        this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitMain.Location = new System.Drawing.Point(0, 98);
        this.splitMain.Name = "splitMain";
        this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
        this.splitMain.Panel1.Controls.Add(this.dgvOrders);
        this.splitMain.Panel2.Controls.Add(this.dgvDetails);
        this.splitMain.Panel2.Controls.Add(this.lblDetails);
        this.splitMain.Size = new System.Drawing.Size(900, 502);
        this.splitMain.SplitterDistance = 300;
        this.splitMain.TabIndex = 2;

        // dgvOrders
        this.dgvOrders.AllowUserToAddRows = false;
        this.dgvOrders.AllowUserToDeleteRows = false;
        this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
        this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.dgvOrders.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        this.dgvOrders.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrdId, this.colOrdDate, this.colOrdCust,
            this.colOrdTotal, this.colOrdStat, this.colOrdServ });
        this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvOrders.MultiSelect = false;
        this.dgvOrders.Name = "dgvOrders";
        this.dgvOrders.ReadOnly = true;
        this.dgvOrders.RowHeadersVisible = false;
        this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvOrders.TabIndex = 0;
        this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);

        this.colOrdId.FillWeight = 8F;
        this.colOrdId.HeaderText = "Order #";
        this.colOrdId.Name = "colOrdId";
        this.colOrdId.ReadOnly = true;

        this.colOrdDate.HeaderText = "Date";
        this.colOrdDate.Name = "colOrdDate";
        this.colOrdDate.ReadOnly = true;

        this.colOrdCust.HeaderText = "Customer";
        this.colOrdCust.Name = "colOrdCust";
        this.colOrdCust.ReadOnly = true;

        this.colOrdTotal.FillWeight = 15F;
        this.colOrdTotal.HeaderText = "Total";
        this.colOrdTotal.Name = "colOrdTotal";
        this.colOrdTotal.ReadOnly = true;

        this.colOrdStat.FillWeight = 12F;
        this.colOrdStat.HeaderText = "Status";
        this.colOrdStat.Name = "colOrdStat";
        this.colOrdStat.ReadOnly = true;

        this.colOrdServ.FillWeight = 15F;
        this.colOrdServ.HeaderText = "Server";
        this.colOrdServ.Name = "colOrdServ";
        this.colOrdServ.ReadOnly = true;

        // lblDetails
        this.lblDetails.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
        this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(140, 100, 70);
        this.lblDetails.Location = new System.Drawing.Point(0, 0);
        this.lblDetails.Name = "lblDetails";
        this.lblDetails.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
        this.lblDetails.Size = new System.Drawing.Size(900, 22);
        this.lblDetails.TabIndex = 0;
        this.lblDetails.Text = "Order Details (click a row above to view)";

        // dgvDetails
        this.dgvDetails.AllowUserToAddRows = false;
        this.dgvDetails.AllowUserToDeleteRows = false;
        this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(250, 248, 245);
        this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(140, 100, 70);
        this.dgvDetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.dgvDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        this.dgvDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(140, 100, 70);
        this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetQty, this.colDetProd, this.colDetUp, this.colDetSub });
        this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvDetails.MultiSelect = false;
        this.dgvDetails.Name = "dgvDetails";
        this.dgvDetails.ReadOnly = true;
        this.dgvDetails.RowHeadersVisible = false;
        this.dgvDetails.TabIndex = 1;

        this.colDetQty.FillWeight = 10F;
        this.colDetQty.HeaderText = "Qty";
        this.colDetQty.Name = "colDetQty";
        this.colDetQty.ReadOnly = true;

        this.colDetProd.HeaderText = "Product";
        this.colDetProd.Name = "colDetProd";
        this.colDetProd.ReadOnly = true;

        this.colDetUp.FillWeight = 20F;
        this.colDetUp.HeaderText = "Unit Price";
        this.colDetUp.Name = "colDetUp";
        this.colDetUp.ReadOnly = true;

        this.colDetSub.FillWeight = 20F;
        this.colDetSub.HeaderText = "Sub-Total";
        this.colDetSub.Name = "colDetSub";
        this.colDetSub.ReadOnly = true;

        // OrdersListForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 600);
        this.Controls.Add(this.splitMain);
        this.Controls.Add(this.panelFilter);
        this.Controls.Add(this.panelTop);
        this.MinimumSize = new System.Drawing.Size(900, 640);
        this.Name = "OrdersListForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Orders History";

        this.panelTop.ResumeLayout(false);
        this.panelFilter.ResumeLayout(false);
        this.panelFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
        this.splitMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelFilter;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.SplitContainer splitMain;
    private System.Windows.Forms.DataGridView dgvOrders;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrdId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrdDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrdCust;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrdTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrdStat;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrdServ;
    private System.Windows.Forms.Label lblDetails;
    private System.Windows.Forms.DataGridView dgvDetails;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDetQty;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDetProd;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDetUp;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDetSub;
}
