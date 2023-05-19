using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class Add_Book : Form
    {
        byte[] bookImage = null;
        string bookPublication = null;
        //string bookCategory = null;
        string bookCover = null;
        private AdminForm_Bookstore adminForm;
        public Add_Book(AdminForm_Bookstore adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;

            //txtBookCategory.ReadOnly = true;  // Prevent user input

            // Fetch the max ID from the database and increment by 1
            /*string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("getMaxBookID", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int MaxBookID = reader["MaxBookID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MaxBookID"]);
                    txtBookCategory.Text = (MaxBookID + 1).ToString();
                }
            }*/
        }

        private void TextBoxBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPriceMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNumberBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value;
            string publicationDateStr = selectedDate.ToString("yyyy-MM-dd");
            bookPublication = publicationDateStr;
        }

        private void Add_Book_Load(object sender, EventArgs e)
        {
            getComboBoxCategory();
            getComboBoxPublisher();
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

        private void comboBoxBookCover_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxBookCover.SelectedIndex != -1)
            {
                bookCover = comboBoxBookCover.SelectedItem.ToString();
                MessageBox.Show(bookCover);
            }

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
                        labelImageName.Text = imageName;
                        bookImage = imageBytes;
                    }
                    else
                    {
                        MessageBox.Show("False");
                        labelImageName.Text = null;
                    }
                    // do something with the image bytes, such as store them in a variable or pass them to a method
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (checkEmpty())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi nhập sách mới");
            }
            else
            {
                string bookTitle = txtBookTitle.Text.Trim();
                int bookCategoryID = int.Parse(comboBoxBookCategory.SelectedValue.ToString());
                string bookCover = comboBoxBookCover.SelectedItem.ToString();
                string bookQuantity = txtBookQuantity.Text;
                string bookPrice = txtBookPrice.Text +" vnđ";
                string book_Publication = bookPublication;
                int bookAuthorID = getAuthorID(txtBookAuthor.Text);
                int bookPublisherID = int.Parse(comboBoxBookPublisher.SelectedValue.ToString());
                byte[] book_Image = bookImage;

                if(checkBookExist(bookTitle, bookAuthorID))
                {
                    MessageBox.Show("Sách đã tồn tại");
                }
                else
                {

                    SqlConnection conn = new SqlConnection(Program.getConnectString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[addNewBook]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
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

                    //clear input after add successfully
                    clearInput();
                    clearInput();
                    MessageBox.Show("Thêm sách thành công!");
                }
            }
        }

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

        private bool checkEmpty()
        {
            if (string.IsNullOrEmpty(txtBookTitle.Text) || string.IsNullOrEmpty(txtBookPrice.Text) 
                || string.IsNullOrEmpty(txtBookQuantity.Text) || string.IsNullOrEmpty(txtBookAuthor.Text)
                || comboBoxBookCategory.SelectedIndex == -1 || comboBoxBookCover.SelectedIndex == -1 
                || comboBoxBookPublisher.SelectedIndex == -1 || bookPublication ==null || bookImage == null)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        
        private bool checkBookExist(string title, int authorID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[checkBookExist]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@BookTitle", title));
            cmd.Parameters.Add(new SqlParameter("@AuthorID", authorID));


            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }

        private void clearInput()
        {
            txtBookTitle.Text = string.Empty;
            comboBoxBookCategory.SelectedItem = null;
            comboBoxBookCover.SelectedItem = null;
            txtBookQuantity.Text = string.Empty;
            txtBookPrice.Text = string.Empty;
            ///publication day
            dateTimePicker.Value = DateTime.Now;
            bookPublication = null;
            ///
            txtBookAuthor.Text = string.Empty;
            comboBoxBookPublisher.SelectedItem = null;
            bookImage = null;
            labelImageName.Text = string.Empty;
        }
    }
}
