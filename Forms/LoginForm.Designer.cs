namespace CoffeeShopMS.Forms;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.panelHeader  = new System.Windows.Forms.Panel();
        this.lblTitle     = new System.Windows.Forms.Label();
        this.lblSubtitle  = new System.Windows.Forms.Label();
        this.panelForm    = new System.Windows.Forms.Panel();
        this.lblFormTitle = new System.Windows.Forms.Label();
        this.lblUsername  = new System.Windows.Forms.Label();
        this.txtUsername  = new System.Windows.Forms.TextBox();
        this.lblPassword  = new System.Windows.Forms.Label();
        this.txtPassword  = new System.Windows.Forms.TextBox();
        this.btnLogin     = new System.Windows.Forms.Button();
        this.btnExit      = new System.Windows.Forms.Button();
        this.lblHint      = new System.Windows.Forms.Label();

        this.panelHeader.SuspendLayout();
        this.panelForm.SuspendLayout();
        this.SuspendLayout();

        // ── panelHeader ──────────────────────────────────────────────────────
        this.panelHeader.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.panelHeader.Controls.Add(this.lblSubtitle);
        this.panelHeader.Controls.Add(this.lblTitle);
        this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelHeader.Location = new System.Drawing.Point(0, 0);
        this.panelHeader.Name = "panelHeader";
        this.panelHeader.Size = new System.Drawing.Size(420, 130);
        this.panelHeader.TabIndex = 0;

        // lblTitle
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 213, 128);
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(420, 72);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "COFFEE SHOP";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblSubtitle
        this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 180, 160);
        this.lblSubtitle.Location = new System.Drawing.Point(0, 72);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(420, 38);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Management System";
        this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // ── panelForm ────────────────────────────────────────────────────────
        this.panelForm.BackColor = System.Drawing.Color.White;
        this.panelForm.Controls.Add(this.lblHint);
        this.panelForm.Controls.Add(this.btnExit);
        this.panelForm.Controls.Add(this.btnLogin);
        this.panelForm.Controls.Add(this.txtPassword);
        this.panelForm.Controls.Add(this.lblPassword);
        this.panelForm.Controls.Add(this.txtUsername);
        this.panelForm.Controls.Add(this.lblUsername);
        this.panelForm.Controls.Add(this.lblFormTitle);
        this.panelForm.Location = new System.Drawing.Point(40, 150);
        this.panelForm.Name = "panelForm";
        this.panelForm.Size = new System.Drawing.Size(340, 310);
        this.panelForm.TabIndex = 1;

        // lblFormTitle
        this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblFormTitle.Location = new System.Drawing.Point(25, 15);
        this.lblFormTitle.Name = "lblFormTitle";
        this.lblFormTitle.Size = new System.Drawing.Size(290, 22);
        this.lblFormTitle.TabIndex = 0;
        this.lblFormTitle.Text = "Sign In to Your Account";
        this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblUsername
        this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblUsername.Location = new System.Drawing.Point(25, 52);
        this.lblUsername.Name = "lblUsername";
        this.lblUsername.Size = new System.Drawing.Size(290, 18);
        this.lblUsername.TabIndex = 1;
        this.lblUsername.Text = "Username";

        // txtUsername
        this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtUsername.Location = new System.Drawing.Point(25, 72);
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.Size = new System.Drawing.Size(290, 28);
        this.txtUsername.TabIndex = 2;

        // lblPassword
        this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.lblPassword.Location = new System.Drawing.Point(25, 115);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Size = new System.Drawing.Size(290, 18);
        this.lblPassword.TabIndex = 3;
        this.lblPassword.Text = "Password";

        // txtPassword
        this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtPassword.Location = new System.Drawing.Point(25, 135);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(290, 28);
        this.txtPassword.TabIndex = 4;
        this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);

        // btnLogin
        this.btnLogin.BackColor = System.Drawing.Color.FromArgb(74, 44, 29);
        this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogin.FlatAppearance.BorderSize = 0;
        this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnLogin.ForeColor = System.Drawing.Color.White;
        this.btnLogin.Location = new System.Drawing.Point(25, 183);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(290, 42);
        this.btnLogin.TabIndex = 5;
        this.btnLogin.Text = "LOGIN";
        this.btnLogin.UseVisualStyleBackColor = false;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

        // btnExit
        this.btnExit.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
        this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExit.FlatAppearance.BorderSize = 0;
        this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnExit.ForeColor = System.Drawing.Color.White;
        this.btnExit.Location = new System.Drawing.Point(25, 235);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(290, 36);
        this.btnExit.TabIndex = 6;
        this.btnExit.Text = "EXIT";
        this.btnExit.UseVisualStyleBackColor = false;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

        // lblHint
        this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
        this.lblHint.ForeColor = System.Drawing.Color.Gray;
        this.lblHint.Location = new System.Drawing.Point(25, 282);
        this.lblHint.Name = "lblHint";
        this.lblHint.Size = new System.Drawing.Size(290, 18);
        this.lblHint.TabIndex = 7;
        this.lblHint.Text = "Default credentials:  admin  /  admin123";
        this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // ── LoginForm ────────────────────────────────────────────────────────
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(245, 240, 235);
        this.ClientSize = new System.Drawing.Size(420, 500);
        this.Controls.Add(this.panelForm);
        this.Controls.Add(this.panelHeader);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "LoginForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Coffee Shop MS - Login";

        this.panelHeader.ResumeLayout(false);
        this.panelForm.ResumeLayout(false);
        this.panelForm.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel panelForm;
    private System.Windows.Forms.Label lblFormTitle;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label lblHint;
}
