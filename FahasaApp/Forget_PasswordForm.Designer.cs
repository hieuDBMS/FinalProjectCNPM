namespace FahasaApp
{
    partial class Forget_PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forget_PasswordForm));
            this.HidePasswordIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Return_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Accept_btn = new Guna.UI2.WinForms.Guna2Button();
            this.EmailIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShowPasswordIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Lockicon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEmail_OTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendOTP_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.HidePasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lockicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HidePasswordIcon
            // 
            this.HidePasswordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("HidePasswordIcon.Image")));
            this.HidePasswordIcon.ImageRotate = 0F;
            this.HidePasswordIcon.Location = new System.Drawing.Point(526, 276);
            this.HidePasswordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.HidePasswordIcon.Name = "HidePasswordIcon";
            this.HidePasswordIcon.Size = new System.Drawing.Size(20, 20);
            this.HidePasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePasswordIcon.TabIndex = 66;
            this.HidePasswordIcon.TabStop = false;
            this.HidePasswordIcon.Visible = false;
            this.HidePasswordIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HidePassword);
            // 
            // Return_Btn
            // 
            this.Return_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Return_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Return_Btn.BorderRadius = 7;
            this.Return_Btn.BorderThickness = 1;
            this.Return_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Return_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Return_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Return_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Return_Btn.FillColor = System.Drawing.Color.White;
            this.Return_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Return_Btn.Location = new System.Drawing.Point(442, 318);
            this.Return_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Return_Btn.Name = "Return_Btn";
            this.Return_Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Return_Btn.Size = new System.Drawing.Size(108, 37);
            this.Return_Btn.TabIndex = 65;
            this.Return_Btn.Text = "Trở về";
            this.Return_Btn.Click += new System.EventHandler(this.Return_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Khôi phục mật khẩu";
            // 
            // Accept_btn
            // 
            this.Accept_btn.BorderRadius = 5;
            this.Accept_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accept_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Accept_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Accept_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Accept_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Accept_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Accept_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept_btn.ForeColor = System.Drawing.Color.White;
            this.Accept_btn.Location = new System.Drawing.Point(316, 318);
            this.Accept_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Accept_btn.Name = "Accept_btn";
            this.Accept_btn.Size = new System.Drawing.Size(122, 37);
            this.Accept_btn.TabIndex = 63;
            this.Accept_btn.Text = "Xác nhận";
            this.Accept_btn.Click += new System.EventHandler(this.Accept_btn_Click);
            // 
            // EmailIcon
            // 
            this.EmailIcon.Image = ((System.Drawing.Image)(resources.GetObject("EmailIcon.Image")));
            this.EmailIcon.ImageRotate = 0F;
            this.EmailIcon.Location = new System.Drawing.Point(316, 163);
            this.EmailIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailIcon.Name = "EmailIcon";
            this.EmailIcon.Size = new System.Drawing.Size(20, 20);
            this.EmailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailIcon.TabIndex = 62;
            this.EmailIcon.TabStop = false;
            // 
            // textEmail
            // 
            this.textEmail.BorderColor = System.Drawing.Color.Gray;
            this.textEmail.BorderRadius = 5;
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.DefaultText = "      Nhập email của bạn";
            this.textEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.Location = new System.Drawing.Point(313, 162);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail.PlaceholderText = "";
            this.textEmail.SelectedText = "";
            this.textEmail.Size = new System.Drawing.Size(234, 24);
            this.textEmail.TabIndex = 61;
            this.textEmail.Leave += new System.EventHandler(this.RePlaceholder1);
            this.textEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform1);
            // 
            // ShowPasswordIcon
            // 
            this.ShowPasswordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordIcon.Image")));
            this.ShowPasswordIcon.ImageRotate = 0F;
            this.ShowPasswordIcon.Location = new System.Drawing.Point(526, 276);
            this.ShowPasswordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPasswordIcon.Name = "ShowPasswordIcon";
            this.ShowPasswordIcon.Size = new System.Drawing.Size(20, 20);
            this.ShowPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowPasswordIcon.TabIndex = 60;
            this.ShowPasswordIcon.TabStop = false;
            this.ShowPasswordIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowPassword);
            // 
            // Lockicon
            // 
            this.Lockicon.Image = ((System.Drawing.Image)(resources.GetObject("Lockicon.Image")));
            this.Lockicon.ImageRotate = 0F;
            this.Lockicon.Location = new System.Drawing.Point(320, 276);
            this.Lockicon.Margin = new System.Windows.Forms.Padding(2);
            this.Lockicon.Name = "Lockicon";
            this.Lockicon.Size = new System.Drawing.Size(19, 18);
            this.Lockicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lockicon.TabIndex = 59;
            this.Lockicon.TabStop = false;
            // 
            // textPass
            // 
            this.textPass.BorderColor = System.Drawing.Color.Gray;
            this.textPass.BorderRadius = 5;
            this.textPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPass.DefaultText = "      Mật khẩu";
            this.textPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPass.Location = new System.Drawing.Point(316, 274);
            this.textPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '\0';
            this.textPass.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPass.PlaceholderText = "";
            this.textPass.SelectedText = "";
            this.textPass.Size = new System.Drawing.Size(234, 24);
            this.textPass.TabIndex = 58;
            this.textPass.Leave += new System.EventHandler(this.RePlaceholder3);
            this.textPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform3);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // textEmail_OTP
            // 
            this.textEmail_OTP.BorderColor = System.Drawing.Color.Gray;
            this.textEmail_OTP.BorderRadius = 5;
            this.textEmail_OTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail_OTP.DefaultText = "Mã xác nhận 6 ký tự";
            this.textEmail_OTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEmail_OTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEmail_OTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail_OTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail_OTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail_OTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail_OTP.Location = new System.Drawing.Point(316, 218);
            this.textEmail_OTP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textEmail_OTP.Name = "textEmail_OTP";
            this.textEmail_OTP.PasswordChar = '\0';
            this.textEmail_OTP.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail_OTP.PlaceholderText = "";
            this.textEmail_OTP.SelectedText = "";
            this.textEmail_OTP.Size = new System.Drawing.Size(234, 24);
            this.textEmail_OTP.TabIndex = 68;
            this.textEmail_OTP.Leave += new System.EventHandler(this.RePlaceholder2);
            this.textEmail_OTP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Mã xác nhận";
            // 
            // SendOTP_btn
            // 
            this.SendOTP_btn.BorderRadius = 5;
            this.SendOTP_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendOTP_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendOTP_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendOTP_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendOTP_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendOTP_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.SendOTP_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendOTP_btn.ForeColor = System.Drawing.Color.White;
            this.SendOTP_btn.Location = new System.Drawing.Point(476, 191);
            this.SendOTP_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendOTP_btn.Name = "SendOTP_btn";
            this.SendOTP_btn.Size = new System.Drawing.Size(70, 24);
            this.SendOTP_btn.TabIndex = 69;
            this.SendOTP_btn.Text = "Gửi mã";
            this.SendOTP_btn.Click += new System.EventHandler(this.SendOTP_btn_Click);
            // 
            // Forget_PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 440);
            this.Controls.Add(this.SendOTP_btn);
            this.Controls.Add(this.textEmail_OTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HidePasswordIcon);
            this.Controls.Add(this.Return_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Accept_btn);
            this.Controls.Add(this.EmailIcon);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.ShowPasswordIcon);
            this.Controls.Add(this.Lockicon);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Forget_PasswordForm";
            this.Text = "Forget_PasswordForm";
            this.Load += new System.EventHandler(this.Forget_PasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HidePasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lockicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox HidePasswordIcon;
        private Guna.UI2.WinForms.Guna2Button Return_Btn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Accept_btn;
        private Guna.UI2.WinForms.Guna2PictureBox EmailIcon;
        private Guna.UI2.WinForms.Guna2TextBox textEmail;
        private Guna.UI2.WinForms.Guna2PictureBox ShowPasswordIcon;
        private Guna.UI2.WinForms.Guna2PictureBox Lockicon;
        private Guna.UI2.WinForms.Guna2TextBox textPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textEmail_OTP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button SendOTP_btn;
    }
}