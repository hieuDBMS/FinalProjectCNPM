using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class NoticeUserLogin_CartForm : Form
    {
        public NoticeUserLogin_CartForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm= new LoginForm();
            loginForm.Show();
            
        }

        /*private void checkLoginSuccess()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.userID))
            {
                if (Application.OpenForms.OfType<CartForm>().Any())
                {
                    // Update and Sync infor user to mainform
                    CartForm cartForm = Application.OpenForms.OfType<CartForm>().FirstOrDefault();
                    AddressForm addressForm = new AddressForm();
                    cartForm.openChildForm(addressForm);
                    cartForm.Refresh();
                    *//*cartForm.*//*
                }
            }
        }*/
    }
}
