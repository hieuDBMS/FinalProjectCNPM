using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class Edit_Book : Form
    {
        private string bookCover = null;
        byte[] bookImage = null;
        string bookPublication = null;
      
        private int bookId;
        public Edit_Book(int BookID)
        {
            InitializeComponent();
            bookId = BookID;

        }
        private void Edit_Book_Load(object sender, EventArgs e)
        {
            centerForm();
            getComboBoxCategory();
            getComboBoxPublisher();
            initBookInformation();
            txtBookTitle.Focus();
        }

        private void centerForm()
        {
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

        private void getComboBoxCategory()
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[getAllCategory]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            if (dt.Rows.Count > 0)
            {
                comboBoxBookCategory.DisplayMember = "CategoryType";
                comboBoxBookCategory.ValueMember = "CategoryID";
                comboBoxBookCategory.DataSource = dt;
                comboBoxBookCategory.SelectedIndex = -1;
            }
        }
        private void getComboBoxPublisher()
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[getAllPublisher]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            if (dt.Rows.Count > 0)
            {
                comboBoxBookPublisher.DisplayMember = "Name";
                comboBoxBookPublisher.ValueMember = "PublisherID";
                comboBoxBookPublisher.DataSource = dt;
                comboBoxBookPublisher.SelectedIndex = -1;
            }
        }

        private void initBookInformation()
        {
            DataTable dt = getBookByID();
            DataRow firstRow = dt.Rows[0];
            bookImage = (byte[])firstRow["Image"];
            using (MemoryStream ms = new MemoryStream(bookImage))
            {
                Image image = Image.FromStream(ms);
                pictureBoxBook.Image = image;
            }
            txtBookTitle.Text = firstRow["BookTitle"].ToString();
            comboBoxBookCategory.SelectedValue = firstRow["CategoryID"];
            comboBoxBookCover.SelectedItem = firstRow["BookCover"];
            txtBookQuantity.Text = firstRow["BookQuantity"].ToString();
            txtBookPrice.Text = getPriceFormat(firstRow["Price"].ToString());
            dateTimePicker.Value = getDateFormat(firstRow["PublicationDate"].ToString());
            txtBookAuthor.Text = getNameAuthor(int.Parse(firstRow["AuthorID"].ToString()));
            comboBoxBookPublisher.SelectedValue = firstRow["PublisherID"];
        }

        private DataTable getBookByID()
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetBookByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", bookId));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            return dt;
        }

        private DataTable getAuthorBy_ID(int ID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetAuthorByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        private String getNameAuthor(int ID)
        {
            DataTable dt = getAuthorBy_ID(ID);
            DataRow firstRow = dt.Rows[0];
            String authorName = firstRow["AuthorName"].ToString();
            return authorName;
        }

        private string getPriceFormat(string price)
        {
            string result = price.Replace(" vnđ", "");
            return result;
        }
        private DateTime getDateFormat(string dateValue)
        {
            DateTime dateTimeValue = DateTime.Parse(dateValue.ToString());
            return dateTimeValue;
        }

        private void comboBoxBookCover_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBookCover.SelectedIndex != -1)
            {
                bookCover = comboBoxBookCover.SelectedItem.ToString();
            }
        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value;
            string publicationDateStr = selectedDate.ToString("yyyy-MM-dd");
            bookPublication = publicationDateStr;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string imageName = Path.GetFileName(filePath);
                    byte[] imageBytes = File.ReadAllBytes(filePath);

                    if (imageBytes != null)
                    {
                        MessageBox.Show("Get successfully");
                        bookImage = imageBytes;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image image = Image.FromStream(ms);
                            pictureBoxBook.Image = image;
                        }
                    }
                    else
                    {
                        MessageBox.Show("False");

                    }
                }
            }
        }
        ///////////////////////////////////////////////////Click to update//////////////////////////////////////////////////////
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi cập nhập sách");
            }
            else
            {
                string bookTitle = txtBookTitle.Text.Trim();
                int bookCategoryID = int.Parse(comboBoxBookCategory.SelectedValue.ToString());
                string bookCover = comboBoxBookCover.SelectedItem.ToString();
                string bookQuantity = txtBookQuantity.Text;
                string bookPrice = txtBookPrice.Text + " vnđ";
                string book_Publication = bookPublication;
                int bookAuthorID = getAuthorID(txtBookAuthor.Text);
                int bookPublisherID = int.Parse(comboBoxBookPublisher.SelectedValue.ToString());
                byte[] book_Image = bookImage;

                SqlConnection conn = new SqlConnection(Program.getConnectString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("[updateBookForAdmin]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BookID", bookId));
                cmd.Parameters.Add(new SqlParameter("@BookTitle", bookTitle));
                cmd.Parameters.Add(new SqlParameter("@BookCover", bookCover));
                cmd.Parameters.Add(new SqlParameter("@BookQuantity", bookQuantity));
                cmd.Parameters.Add(new SqlParameter("@PublicationDate", book_Publication));
                cmd.Parameters.Add(new SqlParameter("@AuthorID", bookAuthorID));
                cmd.Parameters.Add(new SqlParameter("@PublisherID", bookPublisherID));
                cmd.Parameters.Add(new SqlParameter("@CategoryID", bookCategoryID));
                cmd.Parameters.Add(new SqlParameter("@Price", bookPrice));
                cmd.Parameters.Add(new SqlParameter("@Image", book_Image));
                cmd.ExecuteNonQuery();
                conn.Close();

                updateAdminBookStore();

                MessageBox.Show("Cập nhập thông tin sách thành công");
            }
        }

        private void updateAdminBookStore()
        {
            if (Application.OpenForms.OfType<AdminForm_Bookstore>().Any())
            {
                // Update and Sync infor user to mainform
                AdminForm_Bookstore adminBook = Application.OpenForms.OfType<AdminForm_Bookstore>().FirstOrDefault();
                adminBook.LoadData();
            }
        }
        private bool checkEmpty()
        {
            if (string.IsNullOrEmpty(txtBookTitle.Text) || string.IsNullOrEmpty(txtBookPrice.Text)
                || string.IsNullOrEmpty(txtBookQuantity.Text) || string.IsNullOrEmpty(txtBookAuthor.Text)
                || comboBoxBookCategory.SelectedIndex == -1 || comboBoxBookCover.SelectedIndex == -1
                || comboBoxBookPublisher.SelectedIndex == -1 || bookPublication == null || bookImage == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Return Author ID if exist, else add a new Author and return it's ID.
        private int getAuthorID(string authorName)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[checkAuthor]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AuthorName", authorName));
            int AuthorID = (int)cmd.ExecuteScalar();
            conn.Close();

            return AuthorID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
