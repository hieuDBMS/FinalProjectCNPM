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
    public partial class QuanLyCustomer_ByNhanVien : Form
    {
        public QuanLyCustomer_ByNhanVien()
        {
            InitializeComponent();
            LoadData();
            dataGridView_customer.RowPrePaint += dataGridView_nhanvien_RowPrePaint;
            dataGridView_customer.CellPainting += dataGridView_customer_CellPainting;
            dataGridView_customer.CellDoubleClick += dataGridView_customer_CellDoubleClick;
            dataGridView_customer.EnableHeadersVisualStyles = false;
        }

        private void dataGridView_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();

        }


        public void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("getAccountsByPrivilige", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Privilige", 0); // Assuming the privilege for staff is 1
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_customer.DataSource = dataTable;

                if (dataGridView_customer.DataSource != null)
                {
                    // Remove the first column (RowHeader column)
                    dataGridView_customer.RowHeadersVisible = false;

                    // Set the fill mode
                    dataGridView_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (DataGridViewColumn col in dataGridView_customer.Columns)
                    {
                        if (col.Name != "USERID" && col.Name != "Họ tên" && col.Name != "Email" && col.Name != "Phone" && col.Name != "Address")
                        {
                            col.Visible = false;
                        }
                    }


                    dataGridView_customer.Columns["USERID"].HeaderText = "Mã KH";
                    dataGridView_customer.Columns["Họ tên"].HeaderText = "Họ Tên";
                    dataGridView_customer.Columns["Email"].HeaderText = "Email";
                    dataGridView_customer.Columns["Phone"].HeaderText = "Số Điện Thoại";
                    dataGridView_customer.Columns["Address"].HeaderText = "Địa Chỉ";

                    // Define the fill weights for columns
                    dataGridView_customer.Columns["USERID"].FillWeight = 7;
                    dataGridView_customer.Columns["Họ tên"].FillWeight = 23;
                    dataGridView_customer.Columns["Email"].FillWeight = 23;
                    dataGridView_customer.Columns["Phone"].FillWeight = 23;
                    dataGridView_customer.Columns["Address"].FillWeight = 23;
                    // Center align for header cells and some specific columns
                    foreach (DataGridViewColumn col in dataGridView_customer.Columns)
                    {
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        if (col.Name == "USERID" || col.Name == "Phone")
                        {
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
            dataGridView_customer.ClearSelection();
        }

        private void dataGridView_customer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            dataGridView_customer.GridColor = Color.White;
        }

        private void dataGridView_nhanvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView_customer.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Arial", 9.5f, FontStyle.Regular);
            if (e.RowIndex % 2 == 0)
                dataGridView_customer.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                dataGridView_customer.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(239, 212, 212);

            dataGridView_customer.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

        }


        private async void XoaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView_customer.CurrentRow != null)
            {
                int userID = Convert.ToInt32(dataGridView_customer.CurrentRow.Cells["UserID"].Value);

                DataTable dataTable = (DataTable)dataGridView_customer.DataSource;
                DataRow rowToDelete = dataTable.AsEnumerable().FirstOrDefault(row => Convert.ToInt32(row["UserID"]) == userID);
                if (rowToDelete != null)
                    dataTable.Rows.Remove(rowToDelete);

                string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Assuming you have a stored procedure named deleteStaff
                    SqlCommand command = new SqlCommand("deleteCustomer", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", userID);
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

                await Task.Delay(2000);
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

            int customerID = int.Parse(dataGridView_customer.Rows[e.RowIndex].Cells["USERID"].Value.ToString());


            var result = MessageBox.Show($"Bạn có chắc chắn muốn chỉnh sửa dữ liệu của khách hàng có mã là {customerID} không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                var secondResult = MessageBox.Show($"Bạn có chắc chắn muốn chỉnh sửa dữ liệu của khách hàng có mã là {customerID} không? Nhấn OK để Sửa & Nhấn No để Xóa Dữ Liệu", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (secondResult == DialogResult.Yes)
                {
                    AdminForm_Customer a = new AdminForm_Customer();
                    var editCustomerForm = new Edit_Customer(a, customerID);
                    editCustomerForm.Show();
                    editCustomerForm.FormClosed += (s, ev) => { LoadData(); };
                }
                else if (secondResult == DialogResult.No)
                {
                    XoaBtn_Click(sender, e);
                }
            }
        }


        private void seach_Customer_TextChanged(object sender, EventArgs e)
        {
            // If the edit was caused by pressing Enter on the keyboard, do not perform a search immediately.
            if (enterPressed)
            {
                enterPressed = false;
                return;
            }

            // If the search text is empty, load the data
            if (string.IsNullOrWhiteSpace(seach_Customer.Text))
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

        private bool isNotified = false;

        private void SearchCustomers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("getAccountsByPrivilige", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Privilige", 0); // Assuming the privilege for customers is 0

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
                if (!string.IsNullOrWhiteSpace(seach_Customer.Text)) // Perform filtering only if the search text is not empty
                {
                    var filteredData = dataTable.AsEnumerable()
                        .Where(row => row.Field<string>("USERID").Contains(seach_Customer.Text)
                                      || row.Field<string>("Họ tên").Contains(seach_Customer.Text)
                                      || row.Field<string>("Phone").Contains(seach_Customer.Text)
                                      || row.Field<string>("Email").Contains(seach_Customer.Text));
                    if (!filteredData.Any()) // No data found
                    {
                        // Temporarily remove the event handler to prevent infinite loops
                        seach_Customer.TextChanged -= seach_Customer_TextChanged;
                        seach_Customer.Text = string.Empty; // Clear the text before showing the error message
                        seach_Customer.TextChanged += seach_Customer_TextChanged;

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

                dataGridView_customer.DataSource = filteredDataTable;

                if (dataGridView_customer.DataSource != null)
                        {
                            // Set the fill mode
                            dataGridView_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            // Define column headers
                            dataGridView_customer.Columns["USERID"].HeaderText = "Mã KH";
                            dataGridView_customer.Columns["Họ tên"].HeaderText = "Họ Tên";
                            dataGridView_customer.Columns["Email"].HeaderText = "Email";
                            dataGridView_customer.Columns["Phone"].HeaderText = "Số Điện Thoại";
                            dataGridView_customer.Columns["Address"].HeaderText = "Địa Chỉ";

                            // Define the fill weights for columns
                            dataGridView_customer.Columns["USERID"].FillWeight = 7;
                            dataGridView_customer.Columns["Họ tên"].FillWeight = 23;
                            dataGridView_customer.Columns["Email"].FillWeight = 23;
                            dataGridView_customer.Columns["Phone"].FillWeight = 23;
                            dataGridView_customer.Columns["Address"].FillWeight = 23;
                        }
                    }
                }

        private bool enterPressed = false;
        private Timer searchTimer;
        private void seach_Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(seach_Customer.Text))
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