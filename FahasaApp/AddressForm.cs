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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = "Họ và tên: "+Properties.Settings.Default.username.ToString().Trim();
            labelUserAddress.Text = "Địa chỉ: "+Properties.Settings.Default.userAddress.ToString().Trim();
            labelUserPhone.Text = "Số điện thoại: "+Properties.Settings.Default.userPhone.ToString().Trim();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CartForm>().Any())
            {
                // Update and Sync infor user to mainform
                CartForm cartForm = Application.OpenForms.OfType<CartForm>().FirstOrDefault();
                ChangeAddressForm changeAddressForm = new ChangeAddressForm();
                cartForm.openChildForm(changeAddressForm);
                cartForm.Refresh();
                /*cartForm.*/
            }
        }
    }
}
