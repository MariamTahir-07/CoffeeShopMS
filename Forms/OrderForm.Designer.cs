namespace CoffeeShopMS.Forms;

partial class OrderForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.panelTop          = new System.Windows.Forms.Panel();
        this.lblTitle          = new System.Windows.Forms.Label();
        this.panelLeft         = new System.Windows.Forms.Panel();
        this.lblProductsTitle  = new System.Windows.Forms.Label();
        this.lstProducts       = new System.Windows.Forms.ListBox();
        this.lblQty            = new System.Windows.Forms.Label();
        this.txtQty            = new System.Windows.Forms.TextBox();
        this.btnAddToCart      = new System.Windows.Forms.Button();
        this.panelRight        = new System.Windows.Forms.Panel();
        this.lblCustomer       = new System.Windows.Forms.Label();
        this.txtCustomerName   = new System.Windows.Forms.TextBox();
        this.lblCartTitle      = new System.Windows.Forms.Label();
        this.dgvCart           = new System.Windows.Forms.DataGridView();
        this.colProduct        = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colQty            = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colUnitPrice      = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSubTotal       = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lblTotal          = new System.Windows.Forms.Label();
        this.btnRemoveFromCart = new System.Windows.Forms.Button();
        this.btnClearCart      = new System.Windows.Forms.Button();
        this.btnPlaceOrder     = new System.Windows.Forms.Button();

        this.panelTop.SuspendLayout();
        this.panelLeft.SuspendLayout();
        this.panelRight.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
        this.SuspendLayout();

        // panelTop
        this.panelTop.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelTop.Location = new System.Drawing.Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new System.Drawing.Size(920, 50);
        this.panelTop.TabIndex = 0;

        // lblTitle
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 213, 128);
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(920, 50);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "New Order";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // panelLeft
        this.panelLeft.BackColor = System.Drawing.Color.White;
        this.panelLeft.Controls.Add(this.btnAddToCart);
        this.panelLeft.Controls.Add(this.txtQty);
        this.panelLeft.Controls.Add(this.lblQty);
        this.panelLeft.Controls.Add(this.lstProducts);
        this.panelLeft.Controls.Add(this.lblProductsTitle);
        this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelLeft.Location = new System.Drawing.Point(0, 50);
        this.panelLeft.Name = "panelLeft";
        this.panelLeft.Size = new System.Drawing.Size(320, 510);
        this.panelLeft.TabIndex = 1;

        // lblProductsTitle
        this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblProductsTitle.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblProductsTitle.Location = new System.Drawing.Point(10, 10);
        this.lblProductsTitle.Name = "lblProductsTitle";
        this.lblProductsTitle.Size = new System.Drawing.Size(300, 22);
        this.lblProductsTitle.TabIndex = 0;
        this.lblProductsTitle.Text = "Select Product (double-click to add)";

        // lstProducts
        this.lstProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lstProducts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lstProducts.ItemHeight = 24;
        this.lstProducts.Location = new System.Drawing.Point(10, 35);
        this.lstProducts.Name = "lstProducts";
        this.lstProducts.Size = new System.Drawing.Size(300, 370);
        this.lstProducts.TabIndex = 1;
        this.lstProducts.DoubleClick += new System.EventHandler(this.lstProducts_DoubleClick);

        // lblQty
        this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblQty.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblQty.Location = new System.Drawing.Point(10, 420);
        this.lblQty.Name = "lblQty";
        this.lblQty.Size = new System.Drawing.Size(65, 22);
        this.lblQty.TabIndex = 2;
        this.lblQty.Text = "Quantity:";

        // txtQty
        this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtQty.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtQty.Location = new System.Drawing.Point(80, 418);
        this.txtQty.Name = "txtQty";
        this.txtQty.Size = new System.Drawing.Size(60, 26);
        this.txtQty.TabIndex = 3;
        this.txtQty.Text = "1";
        this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

        // btnAddToCart
        this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
        this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAddToCart.FlatAppearance.BorderSize = 0;
        this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnAddToCart.ForeColor = System.Drawing.Color.White;
        this.btnAddToCart.Location = new System.Drawing.Point(150, 415);
        this.btnAddToCart.Name = "btnAddToCart";
        this.btnAddToCart.Size = new System.Drawing.Size(160, 32);
        this.btnAddToCart.TabIndex = 4;
        this.btnAddToCart.Text = "Add to Cart";
        this.btnAddToCart.UseVisualStyleBackColor = false;
        this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

        // panelRight
        this.panelRight.BackColor = System.Drawing.Color.FromArgb(245, 240, 235);
        this.panelRight.Controls.Add(this.btnPlaceOrder);
        this.panelRight.Controls.Add(this.btnClearCart);
        this.panelRight.Controls.Add(this.btnRemoveFromCart);
        this.panelRight.Controls.Add(this.lblTotal);
        this.panelRight.Controls.Add(this.dgvCart);
        this.panelRight.Controls.Add(this.lblCartTitle);
        this.panelRight.Controls.Add(this.txtCustomerName);
        this.panelRight.Controls.Add(this.lblCustomer);
        this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelRight.Location = new System.Drawing.Point(320, 50);
        this.panelRight.Name = "panelRight";
        this.panelRight.Size = new System.Drawing.Size(600, 510);
        this.panelRight.TabIndex = 2;

        // lblCustomer
        this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblCustomer.Location = new System.Drawing.Point(10, 10);
        this.lblCustomer.Name = "lblCustomer";
        this.lblCustomer.Size = new System.Drawing.Size(130, 20);
        this.lblCustomer.TabIndex = 0;
        this.lblCustomer.Text = "Customer Name:";

        // txtCustomerName
        this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtCustomerName.Location = new System.Drawing.Point(148, 8);
        this.txtCustomerName.Name = "txtCustomerName";
        this.txtCustomerName.Size = new System.Drawing.Size(240, 25);
        this.txtCustomerName.TabIndex = 1;

        // lblCartTitle
        this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblCartTitle.Location = new System.Drawing.Point(10, 42);
        this.lblCartTitle.Name = "lblCartTitle";
        this.lblCartTitle.Size = new System.Drawing.Size(200, 22);
        this.lblCartTitle.TabIndex = 2;
        this.lblCartTitle.Text = "Order Cart";

        // dgvCart
        this.dgvCart.AllowUserToAddRows = false;
        this.dgvCart.AllowUserToDeleteRows = false;
        this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvCart.BackgroundColor = System.Drawing.Color.White;
        this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvCart.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.dgvCart.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        this.dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct, this.colQty, this.colUnitPrice, this.colSubTotal });
        this.dgvCart.Location = new System.Drawing.Point(10, 68);
        this.dgvCart.MultiSelect = false;
        this.dgvCart.Name = "dgvCart";
        this.dgvCart.ReadOnly = true;
        this.dgvCart.RowHeadersVisible = false;
        this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvCart.Size = new System.Drawing.Size(578, 340);
        this.dgvCart.TabIndex = 3;

        this.colProduct.FillWeight = 50F;
        this.colProduct.HeaderText = "Product";
        this.colProduct.Name = "colProduct";
        this.colProduct.ReadOnly = true;

        this.colQty.FillWeight = 10F;
        this.colQty.HeaderText = "Qty";
        this.colQty.Name = "colQty";
        this.colQty.ReadOnly = true;

        this.colUnitPrice.FillWeight = 20F;
        this.colUnitPrice.HeaderText = "Unit Price";
        this.colUnitPrice.Name = "colUnitPrice";
        this.colUnitPrice.ReadOnly = true;

        this.colSubTotal.FillWeight = 20F;
        this.colSubTotal.HeaderText = "Sub-Total";
        this.colSubTotal.Name = "colSubTotal";
        this.colSubTotal.ReadOnly = true;

        // lblTotal
        this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblTotal.Location = new System.Drawing.Point(10, 415);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Size = new System.Drawing.Size(300, 30);
        this.lblTotal.TabIndex = 4;
        this.lblTotal.Text = "Total:  Rs. 0.00";
        this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // btnRemoveFromCart
        this.btnRemoveFromCart.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
        this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
        this.btnRemoveFromCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
        this.btnRemoveFromCart.Location = new System.Drawing.Point(10, 455);
        this.btnRemoveFromCart.Name = "btnRemoveFromCart";
        this.btnRemoveFromCart.Size = new System.Drawing.Size(155, 36);
        this.btnRemoveFromCart.TabIndex = 5;
        this.btnRemoveFromCart.Text = "Remove Item";
        this.btnRemoveFromCart.UseVisualStyleBackColor = false;
        this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);

        // btnClearCart
        this.btnClearCart.BackColor = System.Drawing.Color.Gray;
        this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClearCart.FlatAppearance.BorderSize = 0;
        this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnClearCart.ForeColor = System.Drawing.Color.White;
        this.btnClearCart.Location = new System.Drawing.Point(175, 455);
        this.btnClearCart.Name = "btnClearCart";
        this.btnClearCart.Size = new System.Drawing.Size(155, 36);
        this.btnClearCart.TabIndex = 6;
        this.btnClearCart.Text = "Clear Cart";
        this.btnClearCart.UseVisualStyleBackColor = false;
        this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);

        // btnPlaceOrder
        this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
        this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
        this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
        this.btnPlaceOrder.Location = new System.Drawing.Point(400, 455);
        this.btnPlaceOrder.Name = "btnPlaceOrder";
        this.btnPlaceOrder.Size = new System.Drawing.Size(188, 36);
        this.btnPlaceOrder.TabIndex = 7;
        this.btnPlaceOrder.Text = "Place Order";
        this.btnPlaceOrder.UseVisualStyleBackColor = false;
        this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);

        // OrderForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(920, 560);
        this.Controls.Add(this.panelRight);
        this.Controls.Add(this.panelLeft);
        this.Controls.Add(this.panelTop);
        this.MinimumSize = new System.Drawing.Size(920, 600);
        this.Name = "OrderForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "New Order";

        this.panelTop.ResumeLayout(false);
        this.panelLeft.ResumeLayout(false);
        this.panelLeft.PerformLayout();
        this.panelRight.ResumeLayout(false);
        this.panelRight.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.Label lblProductsTitle;
    private System.Windows.Forms.ListBox lstProducts;
    private System.Windows.Forms.Label lblQty;
    private System.Windows.Forms.TextBox txtQty;
    private System.Windows.Forms.Button btnAddToCart;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.Label lblCustomer;
    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.Label lblCartTitle;
    private System.Windows.Forms.DataGridView dgvCart;
    private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
    private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Button btnRemoveFromCart;
    private System.Windows.Forms.Button btnClearCart;
    private System.Windows.Forms.Button btnPlaceOrder;
}
