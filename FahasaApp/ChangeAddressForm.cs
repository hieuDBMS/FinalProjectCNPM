using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FahasaApp
{
    public partial class ChangeAddressForm : Form
    {
        public ChangeAddressForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeAddressForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.username.ToString().Trim();
            txtUserAddress.Text = Properties.Settings.Default.userAddress.ToString().Trim();
            txtUserPhone.Text = Properties.Settings.Default.userPhone.ToString().Trim();
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.ToString().Trim().Replace("  ", " ");
            string newUserPhone = txtUserPhone.Text.ToString().Trim().Replace("  ", " ");
            string newUserAddress = txtUserAddress.Text.ToString().Trim().Replace("  ", " ");
            
            if(
                newUsername != Properties.Settings.Default.username.ToString().Trim() ||
                newUserAddress != Properties.Settings.Default.userAddress.ToString().Trim() || 
                newUserPhone != Properties.Settings.Default.userPhone.ToString().Trim()
              )
            {
                int UID = int.Parse(Properties.Settings.Default.userID);
                //save changed
                saveChangeUserInfor(UID,newUsername,newUserPhone,newUserAddress);
            }
            else
            {
                MessageBox.Show("Không có thay đổi thông tin, quay lại trang chính");
                BackToAddressForm();
            }
        }

        private void BackToAddressForm()
        {
            if (Application.OpenForms.OfType<CartForm>().Any())
            {
                // Update and Sync infor user to CartForm
                CartForm cartForm = Application.OpenForms.OfType<CartForm>().FirstOrDefault();
                AddressForm addressForm = new AddressForm();
                cartForm.openChildForm(addressForm);
                cartForm.Refresh();
            }
        }

        public void saveChangeUserInfor(int UID, string newUsername, string newUserPhone, string newUserAddress)
        {
            List<string> username = getFirstLastUsername(newUsername);

            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[updateUserInfor]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UID", UID));
            cmd.Parameters.Add(new SqlParameter("@UFirstname", username[0]));
            cmd.Parameters.Add(new SqlParameter("@ULastname", username[1]));
            cmd.Parameters.Add(new SqlParameter("@UPhone", newUserPhone));
            cmd.Parameters.Add(new SqlParameter("@UAddress", newUserAddress));

            cmd.ExecuteNonQuery();


            conn.Close();

            MessageBox.Show("Thay đổi thông tin thành công!");
            //Save and update , back to Address form
            updateFormsAfterSave();
        }

        private List<string> getFirstLastUsername(string username)
        {
            string[] nameParts = username.Split(' ');
            string lastName = nameParts[nameParts.Length - 1];
            Array.Resize(ref nameParts, nameParts.Length - 1);
            string firstName = string.Join(" ", nameParts);
            List<string> firstLastName = new List<string>();
            firstLastName.Add(firstName); 
            firstLastName.Add(lastName);
            return firstLastName;
        }
        private void updateFormsAfterSave()
        {
            /*Properties.Settings.Default.username = username;
            Properties.Settings.Default.userPhone = userPhone;
            Properties.Settings.Default.userAddress = userAddress;*/

            //Get user after saving changes
            int uID = int.Parse(Properties.Settings.Default.userID);
            List<string> user = getAllUserInformationByID(uID);
            updateForms(user);

        }
        private DataTable getUserByID(int UID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[getUserByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", UID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            return dt;
        }
        private List<string> getAllUserInformationByID(int UID)
        {
            DataTable dt = getUserByID(UID);
            DataRow row = dt.Rows[0];
            string userID = row["CustomerID"].ToString();
            string username = row["Firstname"].ToString() + " " + row["Lastname"].ToString();
            string userPhone = row["Phone"].ToString().Trim();
            string userAddress = row["Address"].ToString();

            List<string> user = new List<string>();
            user.Add(userID);
            user.Add(username);
            user.Add(userPhone);
            user.Add(userAddress);

            return user;
        }
        private void updateForms(List<string> user)
        {
            if (Application.OpenForms.OfType<MainForm>().Any())
            {
                // Update and Sync infor user to mainform
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                mainForm.SyncDataUser(user[0], user[1], user[2], user[3], null);
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

    }
}
