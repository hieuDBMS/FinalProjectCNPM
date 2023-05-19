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
    public partial class AdminForm_Bookstore : Form
    {
        DataTable currentTable = new DataTable();
        DataTable allBookTable = new DataTable();
        bool isStartingFocus = true;
        public AdminForm_Bookstore()
        {
            InitializeComponent();
           // LoadData();
            XoaBtn.Click += XoaBtn_Click;
            dataGridView_book.RowPrePaint += dataGridView_book_RowPrePaint;
            dataGridView_book.CellPainting += dataGridView_book_CellPainting;
            dataGridView_book.EnableHeadersVisualStyles = false;
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
                SqlCommand command = new SqlCommand("[getBooksForAdmin]", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                currentTable = dataTable;
                allBookTable = dataTable;
                dataGridView_book.DataSource = dataTable;

                if (dataGridView_book.DataSource != null)
                {
                    // Remove the first column (RowHeader column)
                    dataGridView_book.RowHeadersVisible = false;

                    // Set the fill mode
                    dataGridView_book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Define the fill weights for columns
                    dataGridView_book.Columns["Mã Sách"].FillWeight = 7;
                    dataGridView_book.Columns["Tên Sách"].FillWeight = 45;
                    dataGridView_book.Columns["Giá Tiền"].FillWeight = 22;
                    dataGridView_book.Columns["Số Lượng"].FillWeight = 9;

                    // Center align for header cells and some specific columns
                    foreach (DataGridViewColumn col in dataGridView_book.Columns)
                    {
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        if (col.Name == "Mã Sách" || col.Name == "Giá Tiền" || col.Name == "Số Lượng")
                        {
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            setFormCenter();
            LoadData();
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            Add_Book a = new Add_Book(this);
            a.ShowDialog();
        }

        private async void XoaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView_book.CurrentRow != null)
            {
                int bookID = Convert.ToInt32(dataGridView_book.CurrentRow.Cells["Mã Sách"].Value);

                string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("deleteBook", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookID", bookID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                }

                await Task.Delay(2000); // Wait for 2 seconds
                LoadData();
            }
            
        }



        private void SuaBtn_Click(object sender, EventArgs e)
        {
            int BookID = Convert.ToInt32(dataGridView_book.CurrentRow.Cells["Mã Sách"].Value);
            Edit_Book a = new Edit_Book(BookID);
            a.ShowDialog();
        }

        private void dataGridView_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadData();
        }

        private void dataGridView_book_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            dataGridView_book.GridColor = Color.White;
        }

        private void dataGridView_book_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView_book.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Arial", 9.5f, FontStyle.Regular);
            if (e.RowIndex % 2 == 0)
                dataGridView_book.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                dataGridView_book.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(239, 212, 212);

            dataGridView_book.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

        }

        private void NhanvienBtn_Click(object sender, EventArgs e)
        {
            AdminFrom_NhanVien form = new AdminFrom_NhanVien();
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

        private void seach_Bookstore_TextChanged(object sender, EventArgs e)
        {
            //Format the searchText
            string searchContent = searchBookStore.Text.ToLower().Trim();
            // Create a new DataTable with the same schema as the original table
            DataTable filteredTable = currentTable.Clone();
            if (!string.IsNullOrEmpty(searchBookStore.Text))
            {           
                if(allBookTable.Rows.Count > 0)
                {
                    foreach (DataRow row in allBookTable.Rows)
                    {
                        //find book title
                        if (row["Mã Sách"].ToString().ToLower().Trim().Contains(searchContent))
                        {
                            filteredTable.ImportRow(row);
                        }
                        //Find publication date
                        else if (row["Tên Sách"].ToString().ToLower().Trim().Contains(searchContent))
                        {
                            filteredTable.ImportRow(row);
                        }
                        //Find author
                        else if (row["Giá Tiền"].ToString().ToLower().Trim().Contains(searchContent))
                        {
                            filteredTable.ImportRow(row);
                        }
                        //Find category
                        else if (row["Số Lượng"].ToString().ToLower().Trim().Contains(searchContent))
                        {
                            filteredTable.ImportRow(row);
                        }                       
                    }
                }               
            }
            if (filteredTable.Rows.Count > 0)
            {
                labelNoBookFound.Visible = false;
                currentTable = filteredTable;

            }
            if (filteredTable.Rows.Count == 0 && searchContent != "")
            {
                labelNoBookFound.Visible = true;
                currentTable = filteredTable;
                //MessageBox.Show(currentDataTable.Rows.Count.ToString() + "can be found" + "/" + searchContent);
            }
            if (filteredTable.Rows.Count == 0 && searchContent == "" && !isStartingFocus)
            {
                filteredTable = allBookTable;
                currentTable = filteredTable;
            }
            if (!isStartingFocus)
            {
                updateDataGridView(currentTable);
            }
            
        }

        private void updateDataGridView(DataTable dt)
        {
            dataGridView_book.DataSource = null;
            dataGridView_book.Rows.Clear();
            dataGridView_book.DataSource = dt;
            dataGridView_book.Refresh();
            dataGridView_book.Update();
            dataGridView_book.ClearSelection();
            dataGridView_book.ClearSelection();
        }

        private void searchBookStore_MouseClick(object sender, MouseEventArgs e)
        {
            isStartingFocus = false;
        }

        private void searchBookStore_MouseLeave(object sender, EventArgs e)
        {
            isStartingFocus = false;
        }

        private void setFormCenter()
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
        }
    }
}
