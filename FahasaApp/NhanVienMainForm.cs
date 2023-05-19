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
    public partial class NhanVienMainForm : Form
    {
        private QuanLyCustomer_ByNhanVien customerForm;
        private QuanLyBill_ByNhanVien billForm;
        public NhanVienMainForm()
        {
            InitializeComponent();
            InitializeChildForms();
            ShowChildForm(billForm);
        }

        private void panelGridView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeChildForms()
        {
            customerForm = new QuanLyCustomer_ByNhanVien();
            billForm = new QuanLyBill_ByNhanVien();

            SetupChildForm(customerForm);
            SetupChildForm(billForm);
        }

        private void ShowChildForm(Form childForm)
        {
            // Ẩn tất cả các form con
            foreach (Form form in panelGridView.Controls.OfType<Form>())
            {
                form.Hide();
            }

            // Hiển thị form cần xem
            childForm.Show();
        }

        private void SetupChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelGridView.Controls.Add(childForm);
        }

        private void DonhangBtn_Click(object sender, EventArgs e)
        {
            ShowChildForm(billForm);

            DonhangBtn.FillColor = Color.Red;
            DonhangBtn.ForeColor = Color.White;

            KhachhangBtn.FillColor = Color.White;
            KhachhangBtn.ForeColor = Color.Red;
        }

        private void KhachhangBtn_Click(object sender, EventArgs e)
        {
            ShowChildForm(customerForm);


            //Change Button color
            KhachhangBtn.FillColor = Color.Red;
            KhachhangBtn.ForeColor = Color.White;

            DonhangBtn.FillColor = Color.White;
            DonhangBtn.ForeColor = Color.Red;
        }
    }
}
