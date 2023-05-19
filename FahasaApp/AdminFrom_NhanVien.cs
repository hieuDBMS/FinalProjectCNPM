using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class AdminFrom_NhanVien : Form
    {
        public AdminFrom_NhanVien()
        {
            InitializeComponent();
            LoadData();
            dataGridView_nhanvien.RowPrePaint += dataGridView_nhanvien_RowPrePaint;
            dataGridView_nhanvien.CellPainting += dataGridView_nhanvien_CellPainting;
            dataGridView_nhanvien.EnableHeadersVisualStyles = false;
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


            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("getAccountsByPrivilige", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Privilige", 1));  // Assuming the privilege for staff is 1
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_nhanvien.DataSource = dataTable;

                if (dataGridView_nhanvien.DataSource != null)
                {
                    // Remove the first column (RowHeader column)
                    dataGridView_nhanvien.RowHeadersVisible = false;

                    // Set the fill mode
                    dataGridView_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (DataGridViewColumn col in dataGridView_nhanvien.Columns)
                    {
                        if (col.Name != "STAFFID" && col.Name != "Họ tên" && col.Name != "Email" && col.Name != "Phone" && col.Name != "Address")
                        {
                            col.Visible = false;
                        }
                    }
                    foreach (DataGridViewColumn col in dataGridView_nhanvien.Columns)
                    {
                        if (col.Name != "STAFFID" && col.Name != "Họ tên" && col.Name != "Email" && col.Name != "Phone" && col.Name != "Address")
                        {
                            col.Visible = false;
                        }
                    }


                    dataGridView_nhanvien.Columns["STAFFID"].HeaderText = "Mã NV";
                    dataGridView_nhanvien.Columns["Họ tên"].HeaderText = "Họ Tên";
                    dataGridView_nhanvien.Columns["Email"].HeaderText = "Email";
                    dataGridView_nhanvien.Columns["Phone"].HeaderText = "Số Điện Thoại";
                    dataGridView_nhanvien.Columns["Address"].HeaderText = "Địa Chỉ";

                    // Define the fill weights for columns
                    dataGridView_nhanvien.Columns["STAFFID"].FillWeight = 7;
                    dataGridView_nhanvien.Columns["Họ tên"].FillWeight = 23;
                    dataGridView_nhanvien.Columns["Email"].FillWeight = 23;
                    dataGridView_nhanvien.Columns["Phone"].FillWeight = 23;
                    dataGridView_nhanvien.Columns["Address"].FillWeight = 23;
                    // Center align for header cells and some specific columns
                    foreach (DataGridViewColumn col in dataGridView_nhanvien.Columns)
                    {
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        if (col.Name == "STAFFID" || col.Name == "Phone")
                        {
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
        }



            private void dataGridView_nhanvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView_nhanvien.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Arial", 9.5f, FontStyle.Regular);
            if (e.RowIndex % 2 == 0)
                dataGridView_nhanvien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                dataGridView_nhanvien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(239, 212, 212);

            dataGridView_nhanvien.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

        }

        private void dataGridView_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        private void dataGridView_nhanvien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            dataGridView_nhanvien.GridColor = Color.White;
        }

        private async void XoaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView_nhanvien.CurrentRow != null)
            {
                int staffID = Convert.ToInt32(dataGridView_nhanvien.CurrentRow.Cells["StaffID"].Value);

                DataTable dataTable = (DataTable)dataGridView_nhanvien.DataSource;
                DataRow rowToDelete = dataTable.AsEnumerable().FirstOrDefault(row => Convert.ToInt32(row["StaffID"]) == staffID);
                if (rowToDelete != null)
                    dataTable.Rows.Remove(rowToDelete);

                string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Assuming you have a stored procedure named deleteStaff
                    SqlCommand command = new SqlCommand("deleteStaff", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StaffID", staffID);
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


        private void ThemBtn_Click(object sender, EventArgs e)
        {
            Add_NhanVien a = new Add_NhanVien(this);
            a.ShowDialog();
        }

        private void SuaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView_nhanvien.CurrentRow != null)
            {
                int accountID = Convert.ToInt32(dataGridView_nhanvien.CurrentRow.Cells["StaffID"].Value);

                // Tạo một instance của Edit_NhanVien và truyền ID vào
                Edit_NhanVien editForm = new Edit_NhanVien(this, accountID);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
            }
        }

        private void AdminFrom_NhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void KhosachBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Bookstore form = new AdminForm_Bookstore();
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

        private void DonhangBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Bill form = new AdminForm_Bill();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void TaikhoanBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Account form = new AdminForm_Account();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void seach_NhanVien_TextChanged(object sender, EventArgs e)
        {
            // If the edit was caused by pressing Enter on the keyboard, do not perform a search immediately.
            if (enterPressed)
            {
                enterPressed = false;
                return;
            }

            // If the search text is empty, load the data
            if (string.IsNullOrWhiteSpace(seach_NhanVien.Text))
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
                SqlCommand command = new SqlCommand("getAccountsByPrivilige", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Privilige", 1); // Assuming the privilege for customers is 0

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
                if (!string.IsNullOrWhiteSpace(seach_NhanVien.Text)) // Perform filtering only if the search text is not empty
                {
                    var filteredData = dataTable.AsEnumerable()
                        .Where(row => row.Field<string>("STAFFID").Contains(seach_NhanVien.Text)
                                      || row.Field<string>("Họ tên").Contains(seach_NhanVien.Text)
                                      || row.Field<string>("Phone").Contains(seach_NhanVien.Text)
                                      || row.Field<string>("Email").Contains(seach_NhanVien.Text));
                    if (!filteredData.Any()) // No data found
                    {
                        // Temporarily remove the event handler to prevent infinite loops
                        seach_NhanVien.TextChanged -= seach_NhanVien_TextChanged;
                        seach_NhanVien.Text = string.Empty; // Clear the text before showing the error message
                        seach_NhanVien.TextChanged += seach_NhanVien_TextChanged;

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

                dataGridView_nhanvien.DataSource = filteredDataTable;

                if (dataGridView_nhanvien.DataSource != null)
                {
                    // Set the fill mode
                    dataGridView_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Define column headers
                    dataGridView_nhanvien.Columns["STAFFID"].HeaderText = "Mã NV";
                    dataGridView_nhanvien.Columns["Họ tên"].HeaderText = "Họ Tên";
                    dataGridView_nhanvien.Columns["Email"].HeaderText = "Email";
                    dataGridView_nhanvien.Columns["Phone"].HeaderText = "Số Điện Thoại";
                    dataGridView_nhanvien.Columns["Address"].HeaderText = "Địa Chỉ";

                    // Define the fill weights for columns
                    dataGridView_nhanvien.Columns["STAFFID"].FillWeight = 7;
                    dataGridView_nhanvien.Columns["Họ tên"].FillWeight = 23;
                    dataGridView_nhanvien.Columns["Email"].FillWeight = 23;
                    dataGridView_nhanvien.Columns["Phone"].FillWeight = 23;
                    dataGridView_nhanvien.Columns["Address"].FillWeight = 23;
                }
            }
        }

        private bool enterPressed = false;
        private Timer searchTimer;
        private void seach_Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(seach_NhanVien.Text))
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
