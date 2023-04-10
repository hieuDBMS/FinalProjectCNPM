namespace FahasaApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label2 = new System.Windows.Forms.Label();
            this.TextHo = new System.Windows.Forms.TextBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.EmailIcon = new System.Windows.Forms.PictureBox();
            this.SDTicon = new System.Windows.Forms.PictureBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.Lockicon = new System.Windows.Forms.PictureBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.Lockicon2 = new System.Windows.Forms.PictureBox();
            this.textRepass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Checkbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDTicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lockicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lockicon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng ký tài khoản của bạn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextHo
            // 
            this.TextHo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextHo.Location = new System.Drawing.Point(366, 124);
            this.TextHo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextHo.Name = "TextHo";
            this.TextHo.Size = new System.Drawing.Size(108, 19);
            this.TextHo.TabIndex = 4;
            this.TextHo.Text = "Họ";
            this.TextHo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform);
            this.TextHo.TextChanged += new System.EventHandler(this.TextHo_TextChanged);
            this.TextHo.Leave += new System.EventHandler(this.RePlaceholder);
            // 
            // textTen
            // 
            this.textTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTen.Location = new System.Drawing.Point(498, 124);
            this.textTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(108, 19);
            this.textTen.TabIndex = 5;
            this.textTen.Text = "Tên";
            this.textTen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform2);
            this.textTen.Leave += new System.EventHandler(this.RePlaceholder2);
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail.Location = new System.Drawing.Point(366, 167);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(239, 19);
            this.textEmail.TabIndex = 6;
            this.textEmail.Text = "        Nhập email của bạn";
            this.textEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform3);
            this.textEmail.Leave += new System.EventHandler(this.RePlaceholder3);
            // 
            // EmailIcon
            // 
            this.EmailIcon.Image = ((System.Drawing.Image)(resources.GetObject("EmailIcon.Image")));
            this.EmailIcon.Location = new System.Drawing.Point(370, 169);
            this.EmailIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailIcon.Name = "EmailIcon";
            this.EmailIcon.Size = new System.Drawing.Size(16, 16);
            this.EmailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailIcon.TabIndex = 7;
            this.EmailIcon.TabStop = false;
            // 
            // SDTicon
            // 
            this.SDTicon.Image = ((System.Drawing.Image)(resources.GetObject("SDTicon.Image")));
            this.SDTicon.Location = new System.Drawing.Point(370, 211);
            this.SDTicon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SDTicon.Name = "SDTicon";
            this.SDTicon.Size = new System.Drawing.Size(16, 16);
            this.SDTicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SDTicon.TabIndex = 9;
            this.SDTicon.TabStop = false;
            // 
            // textSDT
            // 
            this.textSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSDT.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSDT.Location = new System.Drawing.Point(366, 210);
            this.textSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(239, 19);
            this.textSDT.TabIndex = 8;
            this.textSDT.Text = "        (+84)";
            this.textSDT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform4);
            this.textSDT.Leave += new System.EventHandler(this.RePlaceholder4);
            // 
            // Lockicon
            // 
            this.Lockicon.Image = ((System.Drawing.Image)(resources.GetObject("Lockicon.Image")));
            this.Lockicon.Location = new System.Drawing.Point(370, 256);
            this.Lockicon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lockicon.Name = "Lockicon";
            this.Lockicon.Size = new System.Drawing.Size(16, 16);
            this.Lockicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lockicon.TabIndex = 11;
            this.Lockicon.TabStop = false;
            // 
            // textPass
            // 
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPass.Location = new System.Drawing.Point(366, 254);
            this.textPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(239, 19);
            this.textPass.TabIndex = 10;
            this.textPass.Text = "        Mật khẩu";
            this.textPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform5);
            this.textPass.Leave += new System.EventHandler(this.RePlaceholder5);
            // 
            // Lockicon2
            // 
            this.Lockicon2.Image = ((System.Drawing.Image)(resources.GetObject("Lockicon2.Image")));
            this.Lockicon2.Location = new System.Drawing.Point(370, 301);
            this.Lockicon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lockicon2.Name = "Lockicon2";
            this.Lockicon2.Size = new System.Drawing.Size(16, 16);
            this.Lockicon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lockicon2.TabIndex = 13;
            this.Lockicon2.TabStop = false;
            // 
            // textRepass
            // 
            this.textRepass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRepass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textRepass.Location = new System.Drawing.Point(366, 299);
            this.textRepass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRepass.Name = "textRepass";
            this.textRepass.Size = new System.Drawing.Size(239, 19);
            this.textRepass.TabIndex = 12;
            this.textRepass.Text = "        Nhập lại mật khẩu";
            this.textRepass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clearform6);
            this.textRepass.Leave += new System.EventHandler(this.RePlaceholder6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSize = true;
            this.Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox.Location = new System.Drawing.Point(367, 329);
            this.Checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Size = new System.Drawing.Size(108, 17);
            this.Checkbox.TabIndex = 21;
            this.Checkbox.Text = "Tôi đồng ý với";
            this.Checkbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(464, 330);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Điều khoản sử dụng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(590, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Chính sách bảo mật";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(574, 330);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "và";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(366, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "Tạo tài khoản";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(383, 396);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bạn đã có tài khoản?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(495, 396);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Đăng nhập";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 167);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 464);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lockicon2);
            this.Controls.Add(this.textRepass);
            this.Controls.Add(this.Lockicon);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.SDTicon);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(this.EmailIcon);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.TextHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_load);
            ((System.ComponentModel.ISupportInitialize)(this.EmailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDTicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lockicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lockicon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextHo;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.PictureBox EmailIcon;
        private System.Windows.Forms.PictureBox SDTicon;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.PictureBox Lockicon;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.PictureBox Lockicon2;
        private System.Windows.Forms.TextBox textRepass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Checkbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

