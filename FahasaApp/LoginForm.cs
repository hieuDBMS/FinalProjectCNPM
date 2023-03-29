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
    public partial class LoginForm : Form
    {
        bool isclearform1 = false;
        bool isclearform2 = false;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Form_load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Form Username
        private void Clearform1(object sender, MouseEventArgs e)
        {
            if (!isclearform1)
            {
                textBoxUsername.Text = "";
                EmailIcon.Visible = false;
                isclearform1 = true;
            }
        }
        private void RePlaceholder1(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "        Số điện thoại hoặc email";
                EmailIcon.Visible = true;
                isclearform1 = false;
            }
        }

        //FormPassword
        private void Clearform2(object sender, MouseEventArgs e)
        {
            if (!isclearform2)
            {
                textBoxPassword.Text = "";
                Lockicon.Visible = false;
                isclearform2 = true;
                textBoxPassword.PasswordChar = '*';
            }
        }
        private void RePlaceholder2(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "        Mật khẩu";
                Lockicon.Visible = true;
                isclearform2 = false;
                textBoxPassword.PasswordChar = '\0';
            }
        }
        private void reloadForm()
        {
            textBoxUsername.Text = "        Số điện thoại hoặc email";
            EmailIcon.Visible = true;
            isclearform1 = false;

            textBoxPassword.Text = "        Mật khẩu";
            Lockicon.Visible = true;
            isclearform2 = false;

            Checkbox.Checked = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm RG = new RegisterForm();
            RG.Show();
        }
    }

}
