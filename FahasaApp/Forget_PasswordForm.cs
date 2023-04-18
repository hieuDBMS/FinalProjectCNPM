using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class Forget_PasswordForm : Form
    {
        bool isclearform1 = false;
        bool isclearform2 = false;
        bool isclearform3 = false;
        public Forget_PasswordForm()
        {
            InitializeComponent();
        }

        private void Forget_PasswordForm_Load(object sender, EventArgs e)
        {
            //Set Form center Screen
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(left, top);
        }

        private void Clearform1(object sender, MouseEventArgs e)
        {
            if (!isclearform1)
            {
                textEmail.Text = "";
                EmailIcon.Visible = false;
                isclearform1 = true;
            }
        }
        private void RePlaceholder1(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "      Nhập email của bạn";
                EmailIcon.Visible = true;
                isclearform1 = false;
            }
        }
        private void Clearform2(object sender, MouseEventArgs e)
        {
            if (!isclearform2)
            {
                textEmail_OTP.Text = "";
                isclearform2 = true;
            }
        }
        private void RePlaceholder2(object sender, EventArgs e)
        {
            if (textEmail_OTP.Text == "")
            {
                textEmail_OTP.Text = "Mã xác nhận 6 ký tự";
                isclearform2 = false;
            }
        }

        private void Clearform3(object sender, MouseEventArgs e)
        {
            if (!isclearform3)
            {
                textPass.Text = "";
                Lockicon.Visible = false;
                isclearform3 = true;
                textPass.PasswordChar = '*';
            }
        }
        private void RePlaceholder3(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "      Mật khẩu";
                Lockicon.Visible = true;
                isclearform3 = false;
                textPass.PasswordChar = '\0';
            }
        }

        private void ShowPassword(object sender, MouseEventArgs e)
        {
            if (textPass.PasswordChar == '*')
            {
                textPass.PasswordChar = '\0';
                HidePasswordIcon.Visible = true;
                ShowPasswordIcon.Visible = false;
            }

        }

        private void HidePassword(object sender, MouseEventArgs e)
        {
            textPass.PasswordChar = '*';
            HidePasswordIcon.Visible = false;
            ShowPasswordIcon.Visible = true;

        }
        private void Return_Btn_Click(object sender, EventArgs e)
        {
            LoginForm LG = new LoginForm();
            LG.Show();
            this.Hide();
        }
    }
}
