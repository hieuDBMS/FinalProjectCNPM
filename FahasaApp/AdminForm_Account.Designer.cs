namespace FahasaApp
{
    partial class AdminForm_Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm_Account));
            this.ButtonPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.TaikhoanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DonhangBtn = new Guna.UI2.WinForms.Guna2Button();
            this.KhachhangBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NhanvienBtn = new Guna.UI2.WinForms.Guna2Button();
            this.KhosachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NhanVienPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dataGridView_account = new System.Windows.Forms.DataGridView();
            this.ButtonPanelOption = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuaBtn = new Guna.UI2.WinForms.Guna2Button();
            this.XoaBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ThemBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelLogoSideMenu = new System.Windows.Forms.Panel();
            this.seach_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonPanel.SuspendLayout();
            this.NhanVienPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_account)).BeginInit();
            this.ButtonPanelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.TaikhoanBtn);
            this.ButtonPanel.Controls.Add(this.DonhangBtn);
            this.ButtonPanel.Controls.Add(this.KhachhangBtn);
            this.ButtonPanel.Controls.Add(this.NhanvienBtn);
            this.ButtonPanel.Controls.Add(this.KhosachBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(2, 93);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(520, 46);
            this.ButtonPanel.TabIndex = 18;
            // 
            // TaikhoanBtn
            // 
            this.TaikhoanBtn.BorderRadius = 5;
            this.TaikhoanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TaikhoanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TaikhoanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TaikhoanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TaikhoanBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.TaikhoanBtn.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaikhoanBtn.ForeColor = System.Drawing.Color.White;
            this.TaikhoanBtn.Location = new System.Drawing.Point(416, 8);
            this.TaikhoanBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaikhoanBtn.Name = "TaikhoanBtn";
            this.TaikhoanBtn.Size = new System.Drawing.Size(98, 28);
            this.TaikhoanBtn.TabIndex = 4;
            this.TaikhoanBtn.Text = "Tài khoản";
            // 
            // DonhangBtn
            // 
            this.DonhangBtn.BackColor = System.Drawing.Color.White;
            this.DonhangBtn.BorderColor = System.Drawing.Color.Red;
            this.DonhangBtn.BorderRadius = 5;
            this.DonhangBtn.BorderThickness = 1;
            this.DonhangBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DonhangBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DonhangBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DonhangBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DonhangBtn.FillColor = System.Drawing.Color.White;
            this.DonhangBtn.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonhangBtn.ForeColor = System.Drawing.Color.Red;
            this.DonhangBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.DonhangBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.DonhangBtn.Location = new System.Drawing.Point(314, 8);
            this.DonhangBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DonhangBtn.Name = "DonhangBtn";
            this.DonhangBtn.Size = new System.Drawing.Size(98, 28);
            this.DonhangBtn.TabIndex = 3;
            this.DonhangBtn.Text = "Đơn hàng";
            this.DonhangBtn.Click += new System.EventHandler(this.DonhangBtn_Click);
            // 
            // KhachhangBtn
            // 
            this.KhachhangBtn.BackColor = System.Drawing.Color.White;
            this.KhachhangBtn.BorderColor = System.Drawing.Color.Red;
            this.KhachhangBtn.BorderRadius = 5;
            this.KhachhangBtn.BorderThickness = 1;
            this.KhachhangBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.KhachhangBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.KhachhangBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.KhachhangBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.KhachhangBtn.FillColor = System.Drawing.Color.White;
            this.KhachhangBtn.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhachhangBtn.ForeColor = System.Drawing.Color.Red;
            this.KhachhangBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.KhachhangBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.KhachhangBtn.Location = new System.Drawing.Point(212, 8);
            this.KhachhangBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KhachhangBtn.Name = "KhachhangBtn";
            this.KhachhangBtn.Size = new System.Drawing.Size(98, 28);
            this.KhachhangBtn.TabIndex = 2;
            this.KhachhangBtn.Text = "Khách hàng";
            this.KhachhangBtn.Click += new System.EventHandler(this.KhachhangBtn_Click);
            // 
            // NhanvienBtn
            // 
            this.NhanvienBtn.BackColor = System.Drawing.Color.White;
            this.NhanvienBtn.BorderColor = System.Drawing.Color.Red;
            this.NhanvienBtn.BorderRadius = 5;
            this.NhanvienBtn.BorderThickness = 1;
            this.NhanvienBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NhanvienBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NhanvienBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NhanvienBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NhanvienBtn.FillColor = System.Drawing.Color.White;
            this.NhanvienBtn.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanvienBtn.ForeColor = System.Drawing.Color.Red;
            this.NhanvienBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.NhanvienBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.NhanvienBtn.Location = new System.Drawing.Point(110, 8);
            this.NhanvienBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhanvienBtn.Name = "NhanvienBtn";
            this.NhanvienBtn.Size = new System.Drawing.Size(98, 28);
            this.NhanvienBtn.TabIndex = 1;
            this.NhanvienBtn.Text = "Nhân viên";
            this.NhanvienBtn.Click += new System.EventHandler(this.NhanvienBtn_Click);
            // 
            // KhosachBtn
            // 
            this.KhosachBtn.BackColor = System.Drawing.Color.White;
            this.KhosachBtn.BorderColor = System.Drawing.Color.Red;
            this.KhosachBtn.BorderRadius = 5;
            this.KhosachBtn.BorderThickness = 1;
            this.KhosachBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.KhosachBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.KhosachBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.KhosachBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.KhosachBtn.FillColor = System.Drawing.Color.White;
            this.KhosachBtn.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhosachBtn.ForeColor = System.Drawing.Color.Red;
            this.KhosachBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.KhosachBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.KhosachBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.KhosachBtn.Location = new System.Drawing.Point(8, 8);
            this.KhosachBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KhosachBtn.Name = "KhosachBtn";
            this.KhosachBtn.PressedColor = System.Drawing.Color.Red;
            this.KhosachBtn.PressedDepth = 50;
            this.KhosachBtn.Size = new System.Drawing.Size(98, 28);
            this.KhosachBtn.TabIndex = 0;
            this.KhosachBtn.Text = "Kho sách";
            this.KhosachBtn.Click += new System.EventHandler(this.KhosachBtn_Click);
            // 
            // NhanVienPanel
            // 
            this.NhanVienPanel.Controls.Add(this.dataGridView_account);
            this.NhanVienPanel.Location = new System.Drawing.Point(31, 204);
            this.NhanVienPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhanVienPanel.Name = "NhanVienPanel";
            this.NhanVienPanel.Size = new System.Drawing.Size(857, 348);
            this.NhanVienPanel.TabIndex = 19;
            // 
            // dataGridView_account
            // 
            this.dataGridView_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_account.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_account.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_account.Name = "dataGridView_account";
            this.dataGridView_account.RowHeadersWidth = 51;
            this.dataGridView_account.RowTemplate.Height = 24;
            this.dataGridView_account.Size = new System.Drawing.Size(857, 348);
            this.dataGridView_account.TabIndex = 0;
            this.dataGridView_account.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_account_CellContentClick);
            // 
            // ButtonPanelOption
            // 
            this.ButtonPanelOption.Controls.Add(this.SuaBtn);
            this.ButtonPanelOption.Controls.Add(this.XoaBtn);
            this.ButtonPanelOption.Controls.Add(this.ThemBtn);
            this.ButtonPanelOption.Location = new System.Drawing.Point(576, 144);
            this.ButtonPanelOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonPanelOption.Name = "ButtonPanelOption";
            this.ButtonPanelOption.Size = new System.Drawing.Size(312, 46);
            this.ButtonPanelOption.TabIndex = 20;
            // 
            // SuaBtn
            // 
            this.SuaBtn.BackColor = System.Drawing.Color.White;
            this.SuaBtn.BorderColor = System.Drawing.Color.Red;
            this.SuaBtn.BorderRadius = 5;
            this.SuaBtn.BorderThickness = 1;
            this.SuaBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SuaBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SuaBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SuaBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SuaBtn.FillColor = System.Drawing.Color.White;
            this.SuaBtn.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaBtn.ForeColor = System.Drawing.Color.Red;
            this.SuaBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.SuaBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.SuaBtn.Location = new System.Drawing.Point(212, 8);
            this.SuaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SuaBtn.Name = "SuaBtn";
            this.SuaBtn.Size = new System.Drawing.Size(98, 28);
            this.SuaBtn.TabIndex = 2;
            this.SuaBtn.Text = "Sửa";
            this.SuaBtn.Click += new System.EventHandler(this.SuaBtn_Click);
            // 
            // XoaBtn
            // 
            this.XoaBtn.BackColor = System.Drawing.Color.White;
            this.XoaBtn.BorderColor = System.Drawing.Color.Red;
            this.XoaBtn.BorderRadius = 5;
            this.XoaBtn.BorderThickness = 1;
            this.XoaBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.XoaBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.XoaBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.XoaBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.XoaBtn.FillColor = System.Drawing.Color.White;
            this.XoaBtn.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaBtn.ForeColor = System.Drawing.Color.Red;
            this.XoaBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.XoaBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.XoaBtn.Location = new System.Drawing.Point(110, 8);
            this.XoaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(98, 28);
            this.XoaBtn.TabIndex = 1;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.Click += new System.EventHandler(this.XoaBtn_Click);
            // 
            // ThemBtn
            // 
            this.ThemBtn.BackColor = System.Drawing.Color.White;
            this.ThemBtn.BorderColor = System.Drawing.Color.Red;
            this.ThemBtn.BorderRadius = 5;
            this.ThemBtn.BorderThickness = 1;
            this.ThemBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ThemBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ThemBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ThemBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ThemBtn.FillColor = System.Drawing.Color.White;
            this.ThemBtn.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemBtn.ForeColor = System.Drawing.Color.Red;
            this.ThemBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.ThemBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.ThemBtn.Location = new System.Drawing.Point(8, 8);
            this.ThemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(98, 28);
            this.ThemBtn.TabIndex = 0;
            this.ThemBtn.Text = "Thêm";
            this.ThemBtn.Click += new System.EventHandler(this.ThemBtn_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Location = new System.Drawing.Point(664, 4);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(233, 87);
            this.UserPanel.TabIndex = 21;
            // 
            // panelLogoSideMenu
            // 
            this.panelLogoSideMenu.BackColor = System.Drawing.Color.White;
            this.panelLogoSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoSideMenu.BackgroundImage")));
            this.panelLogoSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogoSideMenu.Location = new System.Drawing.Point(2, 4);
            this.panelLogoSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogoSideMenu.Name = "panelLogoSideMenu";
            this.panelLogoSideMenu.Size = new System.Drawing.Size(244, 87);
            this.panelLogoSideMenu.TabIndex = 17;
            // 
            // seach_Account
            // 
            this.seach_Account.BackColor = System.Drawing.Color.White;
            this.seach_Account.BorderColor = System.Drawing.Color.Red;
            this.seach_Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seach_Account.DefaultText = "";
            this.seach_Account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.seach_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.seach_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seach_Account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seach_Account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seach_Account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seach_Account.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seach_Account.Location = new System.Drawing.Point(31, 151);
            this.seach_Account.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seach_Account.Name = "seach_Account";
            this.seach_Account.PasswordChar = '\0';
            this.seach_Account.PlaceholderText = "";
            this.seach_Account.SelectedText = "";
            this.seach_Account.Size = new System.Drawing.Size(484, 29);
            this.seach_Account.TabIndex = 22;
            this.seach_Account.TextChanged += new System.EventHandler(this.seach_Account_TextChanged);
            // 
            // AdminForm_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 557);
            this.Controls.Add(this.seach_Account);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.NhanVienPanel);
            this.Controls.Add(this.ButtonPanelOption);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.panelLogoSideMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm_Account";
            this.Text = "AdminForm_Account";
            this.Load += new System.EventHandler(this.AdminForm_Account_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.NhanVienPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_account)).EndInit();
            this.ButtonPanelOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel ButtonPanel;
        private Guna.UI2.WinForms.Guna2Button TaikhoanBtn;
        private Guna.UI2.WinForms.Guna2Button DonhangBtn;
        private Guna.UI2.WinForms.Guna2Button KhachhangBtn;
        private Guna.UI2.WinForms.Guna2Button NhanvienBtn;
        private Guna.UI2.WinForms.Guna2Button KhosachBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel NhanVienPanel;
        private System.Windows.Forms.DataGridView dataGridView_account;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel ButtonPanelOption;
        private Guna.UI2.WinForms.Guna2Button SuaBtn;
        private Guna.UI2.WinForms.Guna2Button XoaBtn;
        private Guna.UI2.WinForms.Guna2Button ThemBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel UserPanel;
        private System.Windows.Forms.Panel panelLogoSideMenu;
        private Guna.UI2.WinForms.Guna2TextBox seach_Account;
    }
}