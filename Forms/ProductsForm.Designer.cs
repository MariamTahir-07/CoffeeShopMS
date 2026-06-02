namespace CoffeeShopMS.Forms;

partial class ProductsForm
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
        this.lblTitle = new System.Windows.Forms.Label();
        this.panelLeft = new System.Windows.Forms.Panel();
        this.lblFormTitle = new System.Windows.Forms.Label();
        this.lblId = new System.Windows.Forms.Label();
        this.txtProductId = new System.Windows.Forms.TextBox();
        this.lblName = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblCategory = new System.Windows.Forms.Label();
        this.cboCategory = new System.Windows.Forms.ComboBox();
        this.lblPrice = new System.Windows.Forms.Label();
        this.txtPrice = new System.Windows.Forms.TextBox();
        this.lblDesc = new System.Windows.Forms.Label();
        this.txtDescription = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.panelRight = new System.Windows.Forms.Panel();
        this.panelFilter = new System.Windows.Forms.Panel();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.cboFilterCategory = new System.Windows.Forms.ComboBox();
        this.btnSearch = new System.Windows.Forms.Button();
        this.lblCount = new System.Windows.Forms.Label();
        this.dgvProducts = new System.Windows.Forms.DataGridView();
        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();

        this.panelTop.SuspendLayout();
        this.panelLeft.SuspendLayout();
        this.panelRight.SuspendLayout();
        this.panelFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
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
        this.lblTitle.Text = "Products Management";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // panelLeft
        this.panelLeft.BackColor = System.Drawing.Color.White;
        this.panelLeft.Controls.Add(this.btnClear);
        this.panelLeft.Controls.Add(this.btnDelete);
        this.panelLeft.Controls.Add(this.btnUpdate);
        this.panelLeft.Controls.Add(this.btnAdd);
        this.panelLeft.Controls.Add(this.txtDescription);
        this.panelLeft.Controls.Add(this.lblDesc);
        this.panelLeft.Controls.Add(this.txtPrice);
        this.panelLeft.Controls.Add(this.lblPrice);
        this.panelLeft.Controls.Add(this.cboCategory);
        this.panelLeft.Controls.Add(this.lblCategory);
        this.panelLeft.Controls.Add(this.txtName);
        this.panelLeft.Controls.Add(this.lblName);
        this.panelLeft.Controls.Add(this.txtProductId);
        this.panelLeft.Controls.Add(this.lblId);
        this.panelLeft.Controls.Add(this.lblFormTitle);
        this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelLeft.Location = new System.Drawing.Point(0, 50);
        this.panelLeft.Name = "panelLeft";
        this.panelLeft.Size = new System.Drawing.Size(280, 510);
        this.panelLeft.TabIndex = 1;

        // lblFormTitle
        this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblFormTitle.Location = new System.Drawing.Point(15, 10);
        this.lblFormTitle.Name = "lblFormTitle";
        this.lblFormTitle.Size = new System.Drawing.Size(250, 25);
        this.lblFormTitle.TabIndex = 0;
        this.lblFormTitle.Text = "Product Details";

        // lblId
        this.lblId.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblId.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblId.Location = new System.Drawing.Point(15, 45);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(250, 18);
        this.lblId.TabIndex = 1;
        this.lblId.Text = "Product ID (auto)";

        // txtProductId
        this.txtProductId.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtProductId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtProductId.Location = new System.Drawing.Point(15, 63);
        this.txtProductId.Name = "txtProductId";
        this.txtProductId.ReadOnly = true;
        this.txtProductId.Size = new System.Drawing.Size(250, 25);
        this.txtProductId.TabIndex = 2;

        // lblName
        this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblName.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblName.Location = new System.Drawing.Point(15, 100);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(250, 18);
        this.lblName.TabIndex = 3;
        this.lblName.Text = "Product Name *";

        // txtName
        this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtName.Location = new System.Drawing.Point(15, 118);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(250, 25);
        this.txtName.TabIndex = 4;

        // lblCategory
        this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblCategory.Location = new System.Drawing.Point(15, 158);
        this.lblCategory.Name = "lblCategory";
        this.lblCategory.Size = new System.Drawing.Size(250, 18);
        this.lblCategory.TabIndex = 5;
        this.lblCategory.Text = "Category *";

        // cboCategory
        this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboCategory.FormattingEnabled = true;
        this.cboCategory.Items.AddRange(new object[] { "Coffee", "Tea", "Food", "Dessert", "Beverage", "Other" });
        this.cboCategory.Location = new System.Drawing.Point(15, 176);
        this.cboCategory.Name = "cboCategory";
        this.cboCategory.Size = new System.Drawing.Size(250, 25);
        this.cboCategory.TabIndex = 6;

        // lblPrice
        this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblPrice.Location = new System.Drawing.Point(15, 214);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Size = new System.Drawing.Size(250, 18);
        this.lblPrice.TabIndex = 7;
        this.lblPrice.Text = "Price (Rs.) *";

        // txtPrice
        this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtPrice.Location = new System.Drawing.Point(15, 232);
        this.txtPrice.Name = "txtPrice";
        this.txtPrice.Size = new System.Drawing.Size(250, 25);
        this.txtPrice.TabIndex = 8;

        // lblDesc
        this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblDesc.Location = new System.Drawing.Point(15, 270);
        this.lblDesc.Name = "lblDesc";
        this.lblDesc.Size = new System.Drawing.Size(250, 18);
        this.lblDesc.TabIndex = 9;
        this.lblDesc.Text = "Description";

        // txtDescription
        this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtDescription.Location = new System.Drawing.Point(15, 288);
        this.txtDescription.Multiline = true;
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.Size = new System.Drawing.Size(250, 65);
        this.txtDescription.TabIndex = 10;

        // btnAdd
        this.btnAdd.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdd.FlatAppearance.BorderSize = 0;
        this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.Location = new System.Drawing.Point(15, 370);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(115, 34);
        this.btnAdd.TabIndex = 11;
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = false;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

        // btnUpdate
        this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.Location = new System.Drawing.Point(145, 370);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(120, 34);
        this.btnUpdate.TabIndex = 12;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualStyleBackColor = false;
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

        // btnDelete
        this.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDelete.FlatAppearance.BorderSize = 0;
        this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnDelete.ForeColor = System.Drawing.Color.White;
        this.btnDelete.Location = new System.Drawing.Point(15, 410);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(115, 34);
        this.btnDelete.TabIndex = 13;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = false;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

        // btnClear
        this.btnClear.BackColor = System.Drawing.Color.Gray;
        this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClear.FlatAppearance.BorderSize = 0;
        this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnClear.ForeColor = System.Drawing.Color.White;
        this.btnClear.Location = new System.Drawing.Point(145, 410);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(120, 34);
        this.btnClear.TabIndex = 14;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = false;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

        // panelFilter
        this.panelFilter.BackColor = System.Drawing.Color.White;
        this.panelFilter.Controls.Add(this.btnSearch);
        this.panelFilter.Controls.Add(this.cboFilterCategory);
        this.panelFilter.Controls.Add(this.txtSearch);
        this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelFilter.Location = new System.Drawing.Point(10, 10);
        this.panelFilter.Name = "panelFilter";
        this.panelFilter.Size = new System.Drawing.Size(600, 50);
        this.panelFilter.TabIndex = 2;

        // txtSearch
        this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtSearch.Location = new System.Drawing.Point(10, 12);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(200, 25);
        this.txtSearch.TabIndex = 0;
        this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);

        // cboFilterCategory
        this.cboFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboFilterCategory.FormattingEnabled = true;
        this.cboFilterCategory.Items.AddRange(new object[] { "All Categories", "Coffee", "Tea", "Food", "Dessert", "Beverage", "Other" });
        this.cboFilterCategory.Location = new System.Drawing.Point(220, 12);
        this.cboFilterCategory.Name = "cboFilterCategory";
        this.cboFilterCategory.Size = new System.Drawing.Size(150, 25);
        this.cboFilterCategory.TabIndex = 1;

        // btnSearch
        this.btnSearch.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSearch.FlatAppearance.BorderSize = 0;
        this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnSearch.ForeColor = System.Drawing.Color.White;
        this.btnSearch.Location = new System.Drawing.Point(380, 10);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(100, 30);
        this.btnSearch.TabIndex = 2;
        this.btnSearch.Text = "Search";
        this.btnSearch.UseVisualStyleBackColor = false;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

        // lblCount
        this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.lblCount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
        this.lblCount.ForeColor = System.Drawing.Color.Gray;
        this.lblCount.Location = new System.Drawing.Point(0, 488);
        this.lblCount.Name = "lblCount";
        this.lblCount.Size = new System.Drawing.Size(620, 22);
        this.lblCount.TabIndex = 3;
        this.lblCount.Text = "";
        this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // dgvProducts
        this.dgvProducts.AllowUserToAddRows = false;
        this.dgvProducts.AllowUserToDeleteRows = false;
        this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
        this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        this.dgvProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId, this.colName, this.colCategory, this.colPrice, this.colDesc });
        this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvProducts.Location = new System.Drawing.Point(0, 0);
        this.dgvProducts.MultiSelect = false;
        this.dgvProducts.Name = "dgvProducts";
        this.dgvProducts.ReadOnly = true;
        this.dgvProducts.RowHeadersVisible = false;
        this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvProducts.Size = new System.Drawing.Size(620, 510);
        this.dgvProducts.TabIndex = 0;
        this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);

        // columns
        this.colId.FillWeight = 5F;
        this.colId.HeaderText = "ID";
        this.colId.Name = "colId";
        this.colId.ReadOnly = true;

        this.colName.FillWeight = 25F;
        this.colName.HeaderText = "Name";
        this.colName.Name = "colName";
        this.colName.ReadOnly = true;

        this.colCategory.FillWeight = 15F;
        this.colCategory.HeaderText = "Category";
        this.colCategory.Name = "colCategory";
        this.colCategory.ReadOnly = true;

        this.colPrice.FillWeight = 15F;
        this.colPrice.HeaderText = "Price";
        this.colPrice.Name = "colPrice";
        this.colPrice.ReadOnly = true;

        this.colDesc.FillWeight = 40F;
        this.colDesc.HeaderText = "Description";
        this.colDesc.Name = "colDesc";
        this.colDesc.ReadOnly = true;

        // panelRight
        this.panelRight.BackColor = System.Drawing.Color.FromArgb(245, 240, 235);
        this.panelRight.Controls.Add(this.dgvProducts);
        this.panelRight.Controls.Add(this.lblCount);
        this.panelRight.Controls.Add(this.panelFilter);
        this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelRight.Location = new System.Drawing.Point(280, 50);
        this.panelRight.Name = "panelRight";
        this.panelRight.Padding = new System.Windows.Forms.Padding(10);
        this.panelRight.Size = new System.Drawing.Size(620, 510);
        this.panelRight.TabIndex = 2;

        // ProductsForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 560);
        this.Controls.Add(this.panelRight);
        this.Controls.Add(this.panelLeft);
        this.Controls.Add(this.panelTop);
        this.MinimumSize = new System.Drawing.Size(900, 600);
        this.Name = "ProductsForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Products Management";

        this.panelTop.ResumeLayout(false);
        this.panelLeft.ResumeLayout(false);
        this.panelLeft.PerformLayout();
        this.panelRight.ResumeLayout(false);
        this.panelFilter.ResumeLayout(false);
        this.panelFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.Label lblFormTitle;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.TextBox txtProductId;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblCategory;
    private System.Windows.Forms.ComboBox cboCategory;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.TextBox txtPrice;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.Panel panelFilter;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ComboBox cboFilterCategory;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.DataGridView dgvProducts;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
}
