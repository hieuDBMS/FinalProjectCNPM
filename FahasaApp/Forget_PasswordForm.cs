using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using ToastNotifications;
using ToastNotifications.Core;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;

namespace FahasaApp
{
    public partial class Forget_PasswordForm : Form
    {
        bool isclearform1 = false;
        bool isclearform2 = false;
        bool isclearform3 = false;

        String OTPCheck;
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

        private void SendOTP_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi mã OTP");
            int otp = new Random().Next(100000, 999999);

            OTPCheck = otp.ToString();
            // Gửi email
            MailMessage message = new MailMessage();
            message.From = new MailAddress("fahasa.finalproject@gmail.com");
            message.To.Add(textEmail.Text);
            message.Subject = "OTP Verification Recovery Password";
            message.Body = "Your OTP is " + otp.ToString();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("fahasa.finalproject@gmail.com", "kjvolzwfqnbdpucd"); //(Email, Password)
            client.Send(message);
        }
        private void Accept_btn_Click(object sender, EventArgs e)
        {

            //Check empty textbox
            if(textEmail.Text == "      Nhập email của bạn" || textEmail_OTP.Text == "Mã xác nhận 6 ký tự" || textPass.Text == "      Mật khẩu")
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin");
                return;
            } 
            
            //Authentication OTP
            if (textEmail_OTP.Text == OTPCheck)
            {
                using (SqlConnection conn = new SqlConnection(Program.getConnectString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [CUSTOMER] SET Password = @password WHERE Email=@username", conn);
                    cmd.Parameters.AddWithValue("@password", textPass.Text);
                    cmd.Parameters.AddWithValue("@username", textEmail.Text);
                    cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Khôi phục mật khẩu thành công");
                }
            }
            else
                MessageBox.Show("Mã OTP không chính xác");
                
        }

        private void Return_Btn_Click(object sender, EventArgs e)
        {
            LoginForm LG = new LoginForm();
            LG.Show();
            this.Hide();
        }

        
    }
}
