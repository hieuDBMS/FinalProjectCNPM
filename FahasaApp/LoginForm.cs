using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            
            if(EmailIcon.Visible == false && Lockicon.Visible == false)
            {
                //Authentication Account
                using (SqlConnection conn = new SqlConnection(Program.getConnectString()))
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [CUSTOMER] WHERE Email=@username AND Password=@password", conn);
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        MainForm mf = new MainForm();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin để đăng nhập");
            }    
            
            
            
          
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm RG = new RegisterForm();
            RG.Show();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ShowPassword(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
                HidePasswordIcon.Visible = true;
                ShowPasswordIcon.Visible = false;
            }

        }

        private void HidePassword(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            HidePasswordIcon.Visible = false;
            ShowPasswordIcon.Visible = true;

        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
            Forget_PasswordForm FG = new Forget_PasswordForm();
            FG.Show();
            this.Hide();
        }
    }

}
