using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class AdminForm_Bill : Form
    {
        public AdminForm_Bill()
        {
            InitializeComponent();
            LoadData();
            XoaBtn.Click += XoaBtn_Click;
            dataGridView_bill.RowPrePaint += dataGridView_bill_RowPrePaint;
            dataGridView_bill.CellPainting += dataGridView_bill_CellPainting;
            dataGridView_bill.EnableHeadersVisualStyles = false;
        }

        public void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("[GetAllOrdersWithCustomerAddress]", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_bill.DataSource = dataTable;

                if (dataGridView_bill.DataSource != null)
                {
                    // Remove the first column (RowHeader column)
                    dataGridView_bill.RowHeadersVisible = false;

                    // Set the fill mode
                    dataGridView_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Define the fill weights for columns
                    dataGridView_bill.Columns["Mã HD"].FillWeight = 5;
                    dataGridView_bill.Columns["Ngày Đặt"].FillWeight = 15;
                    dataGridView_bill.Columns["Mã KH"].FillWeight = 7;
                    dataGridView_bill.Columns["Tổng Tiền"].FillWeight = 15;
                    dataGridView_bill.Columns["Địa Chỉ"].FillWeight = 23;
                    dataGridView_bill.Columns["Payment ID"].FillWeight = 9;

                    // Center align for header cells and some specific columns
                    foreach (DataGridViewColumn col in dataGridView_bill.Columns)
                    {
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        if (col.Name == "Mã HD" || col.Name == "Mã KH" || col.Name == "Payment ID")
                        {
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
        }

        private void dataGridView_bill_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView_bill.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Arial", 9.5f, FontStyle.Regular);
            if (e.RowIndex % 2 == 0)
                dataGridView_bill.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                dataGridView_bill.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(239, 212, 212);

            dataGridView_bill.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

        }

        private void dataGridView_bill_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.CellStyle.BackColor = Color.FromArgb(201, 33, 39);
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.Font = new Font("Arial", 9.5f, FontStyle.Bold);
            }
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.Font = new Font("Arial", 9.5f, FontStyle.Regular);
            }
            dataGridView_bill.GridColor = Color.White;
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            Add_Bill a = new Add_Bill(this);
            a.ShowDialog();
        }

        private async void XoaBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra dòng được chọn trong DataGridView
            if (dataGridView_bill.CurrentRow != null)
            {
                int orderID = Convert.ToInt32(dataGridView_bill.CurrentRow.Cells["Mã HD"].Value);

                // Xóa dòng từ DataTable
                DataTable dataTable = (DataTable)dataGridView_bill.DataSource;
                DataRow rowToDelete = dataTable.AsEnumerable().FirstOrDefault(row => Convert.ToInt32(row["Mã HD"]) == orderID);
                if (rowToDelete != null)
                    dataTable.Rows.Remove(rowToDelete);

                // Cập nhật lại Database
                string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("deleteOrderByID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để xóa!");
                    }
                }

                await Task.Delay(2000); // Wait for 2 seconds
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
            }
        }

        private void SuaBtn_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dataGridView_bill.CurrentRow.Cells["Mã HD"].Value);
            Edit_Bill a = new Edit_Bill(this, OrderID);
            a.ShowDialog();
        }

        private void dataGridView_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
    }
}
