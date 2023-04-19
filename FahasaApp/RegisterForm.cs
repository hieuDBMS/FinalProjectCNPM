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
    public partial class RegisterForm : Form
    {
        bool isclearform1 = false;
        bool isclearform2 = false;
        bool isclearform3 = false;
        bool isclearform4 = false;
        bool isclearform5 = false;
        bool isclearform6 = false;
        public RegisterForm()
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

        private void label13_Click(object sender, EventArgs e)
        {
           
        }




        private void Clearform(object sender, MouseEventArgs e)
        {
            if (!isclearform1)
            {
                TextHo.Text = "";
                isclearform1 = true;

            }
        }
        private void RePlaceholder(object sender, EventArgs e)
        {
            if (TextHo.Text == "")
            {
                TextHo.Text = "Họ";
                isclearform1 = false;
            }
        }


        private void Clearform2(object sender, MouseEventArgs e)
        {
            if (!isclearform2)
            {
                textTen.Text = "";
                isclearform2 = true;
            }
        }
        private void RePlaceholder2(object sender, EventArgs e)
        {
            if (textTen.Text == "")
            {
                textTen.Text = "Tên";
                isclearform2 = false;
            }
        }


        private void Clearform3(object sender, MouseEventArgs e)
        {
            if (!isclearform3)
            {
                textEmail.Text = "";
                EmailIcon.Visible = false;
                isclearform3 = true;
            }
        }
        private void RePlaceholder3(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "      Nhập email của bạn";
                EmailIcon.Visible = true;
                isclearform3 = false;
            }
        }


        private void Clearform4(object sender, MouseEventArgs e)
        {
            if (!isclearform4)
            {
                textSDT.Text = "";
                SDTicon.Visible = false;
                isclearform4 = true;
            }
        }
        private void RePlaceholder4(object sender, EventArgs e)
        {
            if (textSDT.Text == "")
            {
                textSDT.Text = "      (+84)";
                SDTicon.Visible = true;
                isclearform4 = false;
            }
        }


        private void Clearform5(object sender, MouseEventArgs e)
        {
            if (!isclearform5)
            {
                textPass.Text = "";
                Lockicon.Visible = false;
                isclearform5 = true;
                textPass.PasswordChar = '*';
            }
        }
        private void RePlaceholder5(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "      Mật khẩu";
                Lockicon.Visible = true;
                isclearform5 = false;
                textPass.PasswordChar = '\0';
            }
        }


        private void Clearform6(object sender, MouseEventArgs e)
        {
            if (!isclearform6)
            {
                textRepass.Text = "";
                Lockicon2.Visible = false;
                isclearform6 = true;
                textRepass.PasswordChar = '*';
            }
        }
        private void RePlaceholder6(object sender, EventArgs e)
        {
            if (textRepass.Text == "")
            {
                textRepass.Text = "      Nhập lại mật khẩu";
                Lockicon2.Visible = true;
                isclearform6 = false;
                textRepass.PasswordChar = '\0';
            }
        }

       
        private void reloadForm()
        {
            TextHo.Text = "Họ";
            isclearform1 = false;

            textTen.Text = "Tên";
            isclearform2 = false;

            textEmail.Text = "      Nhập email của bạn";
            EmailIcon.Visible = true;
            isclearform3 = false;

            textSDT.Text = "      (+84)";
            SDTicon.Visible = true;
            isclearform4 = false;

            textPass.PasswordChar = '\0';
            textPass.Text = "      Mật khẩu";
            Lockicon.Visible = true;
            isclearform5 = false;

            textRepass.PasswordChar = '\0';
            textRepass.Text = "      Nhập lại mật khẩu";
            Lockicon2.Visible = true;
            isclearform6 = false;

            Checkbox.Checked = false;
        }


        //Hide Password
        private void HidePassword(object sender, MouseEventArgs e)
        {        
           textPass.PasswordChar = '*';
           HidePasswordIcon.Visible = false;
           ShowPasswordIcon.Visible = true;  
            
        }

        private void HideRePassword(object sender, MouseEventArgs e)
        {
           
            textRepass.PasswordChar = '*';
            HideRePasswordIcon.Visible = false;
            ShowRePasswordIcon.Visible = true;
        }

        //Show Password
        private void ShowPassword(object sender, MouseEventArgs e)
        {
            if(textPass.PasswordChar == '*')
            {
                textPass.PasswordChar = '\0';
                HidePasswordIcon.Visible = true;
                ShowPasswordIcon.Visible = false;
            }    
           
        }

        private void ShowRepassword(object sender, MouseEventArgs e)
        {
            if(textRepass.PasswordChar == '*')
            {
                textRepass.PasswordChar = '\0';
                HideRePasswordIcon.Visible = true;
                ShowRePasswordIcon.Visible = false;
            }    
            
        }

        private void Label_LoginClick(object sender, MouseEventArgs e)
        {
            LoginForm Lg = new LoginForm();
            Lg.Show();
            this.Hide();
        }

        private void CreateAccount(object sender, MouseEventArgs e)
        {
            if (isclearform1 && isclearform2 && isclearform3 && isclearform4 && isclearform5 && isclearform6 && Checkbox.Checked)
            {
                    try
                    {
                        MailAddress mailAddress = new MailAddress(textEmail.Text);  //Check ValidEmailForm

                        using (SqlConnection conn = new SqlConnection(Program.getConnectString()))
                        {
                            SqlCommand cmd = new SqlCommand("Select * FROM[CUSTOMER]",conn);
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                        
                            while (reader.Read())
                            {
                                if((String)reader["Email"] == textEmail.Text)
                                {
                                    MessageBox.Show("Email này đã được đăng ký");
                                    return;
                                }    
                            }    
                            conn.Close();

                            if(textPass.Text == textRepass.Text)
                            {
                                SqlCommand cmdaddUser = new SqlCommand("INSERT INTO [CUSTOMER] (Firstname, Lastname, Email, Phone, Password, Privilige) VALUES (@Firstname, @Lastname, @Email, @Phone, @Password, @Privilige)", conn);
                                cmdaddUser.Parameters.AddWithValue("@Firstname", textTen.Text);
                                cmdaddUser.Parameters.AddWithValue("@Lastname", TextHo.Text);
                                cmdaddUser.Parameters.AddWithValue("@Email", textEmail.Text);
                                cmdaddUser.Parameters.AddWithValue("@Phone", textSDT.Text);
                                cmdaddUser.Parameters.AddWithValue("@Password", textPass.Text);
                                cmdaddUser.Parameters.AddWithValue("@Privilige", 0);
                                conn.Open();
                                cmdaddUser.ExecuteReader();
                                conn.Close();
                                MessageBox.Show("Chúc mừng bạn đã đăng ký tài khoản thành công! ");
                                reloadForm();
                            }else
                            {
                                MessageBox.Show("Xác thực mật khẩu không chính xác!");
                            }    
                            
                    }

                         
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Định dạng email không hợp lệ");
                    }
            }
            else
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin! ");

        }

      
    }

}
