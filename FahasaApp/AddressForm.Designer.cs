namespace FahasaApp
{
    partial class AddressForm
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
            this.panelAddress = new Guna.UI2.WinForms.Guna2Panel();
            this.labelUserPhone = new System.Windows.Forms.Label();
            this.labelUserAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panelAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddress
            // 
            this.panelAddress.BackColor = System.Drawing.Color.White;
            this.panelAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelAddress.BorderRadius = 10;
            this.panelAddress.BorderThickness = 1;
            this.panelAddress.Controls.Add(this.pictureBox1);
            this.panelAddress.Controls.Add(this.btnLogin);
            this.panelAddress.Controls.Add(this.labelUserPhone);
            this.panelAddress.Controls.Add(this.labelUserAddress);
            this.panelAddress.Controls.Add(this.label1);
            this.panelAddress.Controls.Add(this.labelUsername);
            this.panelAddress.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddress.Location = new System.Drawing.Point(0, 0);
            this.panelAddress.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(1051, 180);
            this.panelAddress.TabIndex = 2;
            // 
            // labelUserPhone
            // 
            this.labelUserPhone.AutoSize = true;
            this.labelUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPhone.Location = new System.Drawing.Point(683, 24);
            this.labelUserPhone.Name = "labelUserPhone";
            this.labelUserPhone.Size = new System.Drawing.Size(231, 24);
            this.labelUserPhone.TabIndex = 5;
            this.labelUserPhone.Text = "Số điện thoại: 0378203222";
            // 
            // labelUserAddress
            // 
            this.labelUserAddress.AutoSize = true;
            this.labelUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserAddress.Location = new System.Drawing.Point(18, 99);
            this.labelUserAddress.MaximumSize = new System.Drawing.Size(600, 80);
            this.labelUserAddress.Name = "labelUserAddress";
            this.labelUserAddress.Size = new System.Drawing.Size(324, 24);
            this.labelUserAddress.TabIndex = 4;
            this.labelUserAddress.Text = "Địa chỉ giao hàng: Nguyễn Hữu Cảnh\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Địa Chỉ Đặt Hàng";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(18, 61);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(231, 24);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Họ và Tên : Trần Thế Luật";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FahasaApp.Properties.Resources.bookmark_plus;
            this.pictureBox1.Location = new System.Drawing.Point(910, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(687, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 40);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Sửa thông tin đặt hàng";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1051, 180);
            this.Controls.Add(this.panelAddress);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelAddress;
        private System.Windows.Forms.Label labelUserPhone;
        private System.Windows.Forms.Label labelUserAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}