﻿using System;
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
            dataGridView_bill.RowPrePaint += dataGridView_bill_RowPrePaint;
            dataGridView_bill.CellPainting += dataGridView_bill_CellPainting;
            dataGridView_bill.EnableHeadersVisualStyles = false;
        }

        public void LoadData()
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

            this.FormBorderStyle = FormBorderStyle.Sizable;
            //


            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetAllOrdersWithDetails]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            dataGridView_bill.DataSource = dt;

            if (dataGridView_bill.DataSource != null)
            {
                dataGridView_bill.RowHeadersVisible = false;
                dataGridView_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Ẩn các cột không cần thiết
                foreach (DataGridViewColumn col in dataGridView_bill.Columns)
                {
                    if (col.Name != "Mã HĐ" && col.Name != "Ngày Đặt" && col.Name != "Mã KH" && col.Name != "Tổng Tiền" && col.Name != "Payment ID")
                    {
                        col.Visible = false;
                    }
                }

                dataGridView_bill.Columns["Mã HĐ"].HeaderText = "Mã HD";
                dataGridView_bill.Columns["Ngày Đặt"].HeaderText = "Ngày Đặt";
                dataGridView_bill.Columns["Mã KH"].HeaderText = "Mã KH";
                dataGridView_bill.Columns["Tổng tiền"].HeaderText = "Tổng Tiền";
                dataGridView_bill.Columns["Payment ID"].HeaderText = "Payment ID";

                dataGridView_bill.Columns["Mã HĐ"].FillWeight = 5;
                dataGridView_bill.Columns["Ngày Đặt"].FillWeight = 30;
                dataGridView_bill.Columns["Mã KH"].FillWeight = 25;
                dataGridView_bill.Columns["Tổng tiền"].FillWeight = 15;
                dataGridView_bill.Columns["Payment ID"].FillWeight = 7;


                foreach (DataGridViewColumn col in dataGridView_bill.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (col.Name == "Mã HĐ" || col.Name == "Mã KH" || col.Name == "Payment ID" || col.Name == "Ngày Đặt")
                    {
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                int orderID = Convert.ToInt32(dataGridView_bill.CurrentRow.Cells["Mã HĐ"].Value);

                // Xóa dòng từ DataTable
                DataTable dataTable = (DataTable)dataGridView_bill.DataSource;
                DataRow rowToDelete = dataTable.AsEnumerable().FirstOrDefault(row => Convert.ToInt32(row["Mã HĐ"]) == orderID);
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
            int OrderID = Convert.ToInt32(dataGridView_bill.CurrentRow.Cells["Mã HĐ"].Value);
            Edit_Bill a = new Edit_Bill(this, OrderID);
            a.ShowDialog();
        }

        private void dataGridView_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        private void TaikhoanBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Account form = new AdminForm_Account();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void KhachhangBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Customer form = new AdminForm_Customer();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void NhanvienBtn_Click(object sender, EventArgs e)
        {
            AdminFrom_NhanVien form = new AdminFrom_NhanVien();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void KhosachBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Bookstore form = new AdminForm_Bookstore();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void seach_Bill_TextChanged(object sender, EventArgs e)
        {
            // If the edit was caused by pressing Enter on the keyboard, do not perform a search immediately.
            if (enterPressed)
            {
                enterPressed = false;
                return;
            }

            // If the search text is empty, load the data
            if (string.IsNullOrWhiteSpace(seach_Bill.Text))
            {
                LoadData();
                return;
            }

            // Perform a search after a delay (e.g., 500ms) after stopping typing.
            if (searchTimer == null)
            {
                searchTimer = new Timer();
                searchTimer.Interval = 500; // Delay before performing a search (milliseconds)
                searchTimer.Tick += (s, ev) =>
                {
                    SearchCustomers();
                    searchTimer.Stop();
                };
            }
            else
            {
                searchTimer.Stop();
            }

            searchTimer.Start();
        }

        private void SearchCustomers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllOrdersWithDetails", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu được nhập", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable filteredDataTable;

                // Check if the search text contains any special characters or if it is empty
                if (!string.IsNullOrWhiteSpace(seach_Bill.Text)) // Perform filtering only if the search text is not empty
                {
                    var filteredData = dataTable.AsEnumerable()
                        .Where(row => row.ItemArray.Any(c => c.ToString().Contains(seach_Bill.Text)));

                    if (!filteredData.Any()) // No data found
                    {
                        // Temporarily remove the event handler to prevent infinite loops
                        seach_Bill.TextChanged -= seach_Bill_TextChanged;
                        seach_Bill.Text = string.Empty; // Clear the text before showing the error message
                        seach_Bill.TextChanged += seach_Bill_TextChanged;

                        MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    filteredDataTable = filteredData.CopyToDataTable(); // Copy filtered data to the new DataTable
                }
                else
                {
                    // If there is no search text, display the original dataTable
                    filteredDataTable = dataTable;
                }

                dataGridView_bill.DataSource = filteredDataTable;

                if (dataGridView_bill.DataSource != null)
                {
                    // Set the fill mode
                    dataGridView_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView_bill.Columns["Mã HĐ"].HeaderText = "Mã HD";
                    dataGridView_bill.Columns["Ngày Đặt"].HeaderText = "Ngày Đặt";
                    dataGridView_bill.Columns["Mã KH"].HeaderText = "Mã KH";
                    dataGridView_bill.Columns["Tổng tiền"].HeaderText = "Tổng Tiền";
                    dataGridView_bill.Columns["Payment ID"].HeaderText = "Payment ID";

                    dataGridView_bill.Columns["Mã HĐ"].FillWeight = 5;
                    dataGridView_bill.Columns["Ngày Đặt"].FillWeight = 30;
                    dataGridView_bill.Columns["Mã KH"].FillWeight = 25;
                    dataGridView_bill.Columns["Tổng tiền"].FillWeight = 15;
                    dataGridView_bill.Columns["Payment ID"].FillWeight = 7;
                }
            }
        }

        private bool enterPressed = false;
        private Timer searchTimer;
        private void seach_Bill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(seach_Bill.Text))
                {
                    // If the search text is empty, load the data
                    LoadData();
                    return;
                }

                enterPressed = true;
                SearchCustomers();
                e.Handled = true; // Mark the event as handled to prevent the KeyPress event from being triggered.
            }
        }
    }
}
