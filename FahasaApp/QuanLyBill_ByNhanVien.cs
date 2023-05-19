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
    public partial class QuanLyBill_ByNhanVien : Form
    {
        public QuanLyBill_ByNhanVien()
        {
            InitializeComponent();
            LoadData();
            dataGridView_bill.RowPrePaint += dataGridView_bill_RowPrePaint;
            dataGridView_bill.CellPainting += dataGridView_bill_CellPainting;
            dataGridView_bill.CellDoubleClick += dataGridView_customer_CellDoubleClick;
            dataGridView_bill.EnableHeadersVisualStyles = false;
        }

        private void dataGridView_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
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
        private void dataGridView_customer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // If a header cell is clicked, do nothing
            {
                return;
            }

            int billID = int.Parse(dataGridView_bill.Rows[e.RowIndex].Cells["Mã HĐ"].Value.ToString());


            var result = MessageBox.Show($"Bạn có chắc chắn muốn chỉnh sửa dữ liệu của khách hàng có mã là {billID} không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                var secondResult = MessageBox.Show($"Bạn có chắc chắn muốn chỉnh sửa dữ liệu của khách hàng có mã là {billID} không? Nhấn OK để Sửa & Nhấn No để Xóa Dữ Liệu", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (secondResult == DialogResult.Yes)
                {
                    AdminForm_Bill a = new AdminForm_Bill();
                    var editBillForm = new Edit_Bill(a, billID);
                    editBillForm.Show();
                    editBillForm.FormClosed += (s, ev) => { LoadData(); };
                }
                else if (secondResult == DialogResult.No)
                {
                    // Call the function to delete the customer data here.
                    XoaBtn_Click(sender, e);
                    LoadData();
                }
            }
        }
        

        private bool isNotified = false;

        private void seach_Bill_TextChanged_1(object sender, EventArgs e)
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
                        seach_Bill.TextChanged -= seach_Bill_TextChanged_1;
                        seach_Bill.Text = string.Empty; // Clear the text before showing the error message
                        seach_Bill.TextChanged += seach_Bill_TextChanged_1;

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
