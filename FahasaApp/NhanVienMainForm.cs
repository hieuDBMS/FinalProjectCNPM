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
        }

        private void KhachhangBtn_Click(object sender, EventArgs e)
        {
            ShowChildForm(customerForm);
        }
    }
}
