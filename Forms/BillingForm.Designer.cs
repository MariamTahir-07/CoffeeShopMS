namespace CoffeeShopMS.Forms;

partial class BillingForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.panelTop  = new System.Windows.Forms.Panel();
        this.lblTitle  = new System.Windows.Forms.Label();
        this.rtbBill   = new System.Windows.Forms.RichTextBox();
        this.panelBtns = new System.Windows.Forms.Panel();
        this.btnPrint  = new System.Windows.Forms.Button();
        this.btnClose  = new System.Windows.Forms.Button();

        this.panelTop.SuspendLayout();
        this.panelBtns.SuspendLayout();
        this.SuspendLayout();

        // panelTop
        this.panelTop.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.panelTop.Controls.Add(this.lblTitle);
        this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelTop.Location = new System.Drawing.Point(0, 0);
        this.panelTop.Name = "panelTop";
        this.panelTop.Size = new System.Drawing.Size(520, 50);
        this.panelTop.TabIndex = 0;

        // lblTitle
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 213, 128);
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(520, 50);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Bill Receipt";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // rtbBill
        this.rtbBill.BackColor = System.Drawing.Color.FromArgb(255, 253, 248);
        this.rtbBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.rtbBill.Dock = System.Windows.Forms.DockStyle.Fill;
        this.rtbBill.Font = new System.Drawing.Font("Courier New", 10F);
        this.rtbBill.Location = new System.Drawing.Point(0, 50);
        this.rtbBill.Name = "rtbBill";
        this.rtbBill.Padding = new System.Windows.Forms.Padding(15);
        this.rtbBill.ReadOnly = true;
        this.rtbBill.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
        this.rtbBill.Size = new System.Drawing.Size(520, 515);
        this.rtbBill.TabIndex = 1;
        this.rtbBill.Text = "";

        // panelBtns
        this.panelBtns.BackColor = System.Drawing.Color.FromArgb(245, 240, 235);
        this.panelBtns.Controls.Add(this.btnClose);
        this.panelBtns.Controls.Add(this.btnPrint);
        this.panelBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panelBtns.Location = new System.Drawing.Point(0, 565);
        this.panelBtns.Name = "panelBtns";
        this.panelBtns.Size = new System.Drawing.Size(520, 55);
        this.panelBtns.TabIndex = 2;

        // btnPrint
        this.btnPrint.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPrint.FlatAppearance.BorderSize = 0;
        this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnPrint.ForeColor = System.Drawing.Color.White;
        this.btnPrint.Location = new System.Drawing.Point(100, 10);
        this.btnPrint.Name = "btnPrint";
        this.btnPrint.Size = new System.Drawing.Size(130, 36);
        this.btnPrint.TabIndex = 0;
        this.btnPrint.Text = "Print";
        this.btnPrint.UseVisualStyleBackColor = false;
        this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

        // btnClose
        this.btnClose.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
        this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClose.FlatAppearance.BorderSize = 0;
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnClose.ForeColor = System.Drawing.Color.White;
        this.btnClose.Location = new System.Drawing.Point(250, 10);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(130, 36);
        this.btnClose.TabIndex = 1;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = false;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

        // BillingForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(520, 620);
        this.Controls.Add(this.rtbBill);
        this.Controls.Add(this.panelBtns);
        this.Controls.Add(this.panelTop);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "BillingForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Bill Receipt";

        this.panelTop.ResumeLayout(false);
        this.panelBtns.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.RichTextBox rtbBill;
    private System.Windows.Forms.Panel panelBtns;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.Button btnClose;
}
