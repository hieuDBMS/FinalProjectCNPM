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
                        dr.Close();
                        conn.Close();
                        
                        //GET ROLE USER OR ADMIN
                        SqlCommand cmd1 = new SqlCommand("[getRolebyEmail]", conn);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@UEmail", textBoxUsername.Text);
                        conn.Open();
                        int roleResult = (int)cmd1.ExecuteScalar();

                        if (roleResult == 2)
                        {
                            AdminForm_Bookstore adminForm = new AdminForm_Bookstore();
                            adminForm.Show();
                        }else if(roleResult == 1)
                        {
                            //OpenForm Staff
                            NhanVienMainForm staffForm = new NhanVienMainForm();
                            staffForm.Show();
                        }    
                        else{
                                // Open Customer
                                // Sync Data to mainForm
                            if (Application.OpenForms.OfType<MainForm>().Any())
                            {
                                // Update and Sync infor user to mainform
                                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                                List<string> user = getAllUserInformationByEmail(textBoxUsername.Text, conn);
                                mainForm.SyncDataUser(user[0], user[1], user[2], user[3], user[4]);
                            }
                            // Sync Data to cartForm if it is currently opened
                            if (Application.OpenForms.OfType<CartForm>().Any())
                            {
                                // Update and Sync infor user to cartForm
                                CartForm cartForm = Application.OpenForms.OfType<CartForm>().FirstOrDefault();
                                AddressForm addressForm = new AddressForm();
                                cartForm.openChildForm(addressForm);
                                cartForm.Refresh();
                                /*cartForm.*/
                            }
                        }    

                        /*conn.Close();
                        //Get Firstname by Email
                        SqlCommand cmd1 = new SqlCommand("SELECT Firstname,Lastname FROM [CUSTOMER] WHERE Email=@username ", conn);
                        cmd1.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        conn.Open();
                        string Firstname = (string)cmd1.ExecuteScalar();
                        conn.Close();*/
                        conn.Close();

                        MessageBox.Show("Đăng nhập thành công");
                        
                                
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                    }
                   
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

        private DataTable getUserByEmail(string email, SqlConnection conn)
        {

            SqlCommand cmd = new SqlCommand("[getUserByEmail]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UEmail", email));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        private List<string> getAllUserInformationByEmail(string email, SqlConnection conn)
        {
            DataTable dt = getUserByEmail(email, conn);
            DataRow row = dt.Rows[0];
            string userID = row["CustomerID"].ToString();
            string username = row["Firstname"].ToString() + " " + row["Lastname"].ToString();
            string userPhone = row["Phone"].ToString().Trim();
            string userAddress = row["Address"].ToString();
            string UserEmail = email;
            List<string> user = new List<string>();
            user.Add(userID);
            user.Add(username);
            user.Add(userPhone);
            user.Add(userAddress);
            user.Add(UserEmail);
            return user;
        }

       
    }

}
