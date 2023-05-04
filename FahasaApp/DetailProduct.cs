using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class DetailProduct : Form
    {
        Book bookDetail = null;
        DataTable commentTable = new DataTable();
        bool dataGridInit = false;

        public DetailProduct(Book BookImage)
        {
            InitializeComponent();
            this.bookDetail = BookImage;
        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            try
            {
                
                setBookInformation();
                setDataGridView_UserComment(bookDetail.getBookID);
                dataGridInit = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }        
        }

        private void setBookInformation()
        {
            using (MemoryStream stream = new MemoryStream(bookDetail.getBookImage))
            {
                // Create an Image object from the MemoryStream
                Image image = Image.FromStream(stream);
                pictureBoxBookImage.Image = image;             
                /*pictureBoxBookImage.SizeMode = PictureBoxSizeMode.Zoom;*/
            }
            labelBookTitle.Text = bookDetail.getBookTitle.Trim();
            labelBookAuthor.Text = "Tác giả: "+bookDetail.getAuthor.Trim();
            labelBookPublisher.Text = "Nhà xuất bản: "+bookDetail.getPublisher.Trim();
            labelBookPublication.Text = "Ngày xuất bản: "+bookDetail.getPublicationDate.Trim();
            labelBookPrice.Text = bookDetail.getBookPrice.Trim();
            labelBookCover.Text = "Lọa Bìa Sách: "+bookDetail.getBookCover.Trim();
            labelBookCategory.Text = "Thể loại: "+bookDetail.getBookCategory.Trim();
        }
        private void setDataGridView_UserComment(int bookID)
        {
            getAllUserComment(bookID);
            DataTable dt = commentTable.Copy();
            if (dt.Rows.Count > 0)
            {
                labelNoUserComment.Visible = false;
                dt = formatCommentTable(dt);
                dataGridViewAllUserComment.AutoGenerateColumns = false;
                dataGridViewAllUserComment.DataSource = dt;
                dataGridViewAllUserComment.CurrentCell = null;
                dataGridViewAllUserComment.ClearSelection();
            }
            else
            {
                labelNoUserComment.Visible = true;
            }
        }
        private void getAllUserComment(int bookID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[getBookCommentByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", bookID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(commentTable);
            conn.Close();
            da.Dispose();
        }

        private DataTable formatCommentTable(DataTable dt)
        {
            dt.Columns.Add("username");
            dt.Columns.Add("StarImage",typeof(Image));
            foreach (DataRow row in dt.Rows)
            {
                DataTable dataUserTable = getUserByID(int.Parse(row["UserID"].ToString()));
                string username = getUserName(dataUserTable);
                row["username"] = username;
                /*Bitmap starImage = new Bitmap(imageList80.Images[0]);*/
                int star = int.Parse(row["Star"].ToString());
                row["StarImage"] = imageList100.Images[star-1];

            }
            return dt;
        }

        private DataTable getUserByID(int userID)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[getUserByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", userID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        private string getUserName(DataTable dtUser)
        {
            DataRow firstRow = dtUser.Rows[0];
            String firstName = firstRow["Firstname"].ToString();
            String lastName = firstRow["Lastname"].ToString();

            return firstName + " " + lastName;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxChooseStar.SelectedIndex;
            if (selectedIndex != -1 && !string.IsNullOrEmpty(txtUserComment.Text))
            {
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(Program.getConnectString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("[storeUserComment]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UID", 2));
                cmd.Parameters.Add(new SqlParameter("@BID", bookDetail.getBookID));
                cmd.Parameters.Add(new SqlParameter("@Star", selectedIndex));
                cmd.Parameters.Add(new SqlParameter("@Comment", txtUserComment.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                setDataGridView_UserComment(bookDetail.getBookID);
                dataGridViewAllUserComment.Refresh();
            }
        }
        private void dataGridViewAllUserComment_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridInit)
            {
                dataGridInit = false;
                dataGridViewAllUserComment.ClearSelection();
            }
        }
    }
}
