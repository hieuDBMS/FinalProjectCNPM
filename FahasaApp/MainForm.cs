using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class MainForm : Form
    {
        List<Panel> subMenuControl = new List<Panel>();
        List<Button> typeBookControl = new List<Button>();
        private int rowCount = 0;
        DataTable dtTest = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            initControlLists();
            hideSubMenu();
        }
        private void MainForm_Load(object sender, EventArgs e)
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

            //Init first data for Mainform
            try
            {
                SqlConnection conn = new SqlConnection(Program.getConnectString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("[GetFirst10Books]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0 )
                {
                    rowCount = dt.Rows.Count;
                    dt.Columns.Add("BookInfor");
                    dt.Columns.Add("PriceInfor");
                    foreach (DataRow row in dt.Rows)
                    {                   
                        row["BookInfor"] = row["BookTitle"] + "\n\n" + getNameCategory((int)row["CategoryID"]) + "\n\n" + getNameAuthor((int)row["AuthorID"]) + "\n";
                        String StatusBar = "Còn hàng";
                        if ( (int)row["BookQuantity"] == 0 )
                        {
                            StatusBar = "Hết Hàng";
                        }
                
                        row["PriceInfor"] = "\n" + row["Price"] + "\n\n" + "Tình Trạng: " + StatusBar;
                    }
                    dataGridViewBookShow.AutoGenerateColumns = false;
                    dataGridViewBookShow.DataSource = dt;
                    dataGridViewBookShow.ClearSelection();
                    dtTest = dt;
                }
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void initControlLists()
        {
            //Initate panel comtrol for SubMenu
            subMenuControl.Add(panelChildrenBookSubmenu);
            subMenuControl.Add(panelBiography_MemoirsSubMenu);
            subMenuControl.Add(panelEconomySubMenu);
            subMenuControl.Add(panelForeignLanguageBooksSubMenu);
            subMenuControl.Add(panelLiteratureSubMenu);
            subMenuControl.Add(panelPsychology_LifeSkillsSubMenu);
            subMenuControl.Add(panelRaiseUpChildSubMenu);
            subMenuControl.Add(panelText_ReferenceBookSubMenu);

            //Initate Button control for topics of Books
            typeBookControl.Add(btnChildrenBook);
            typeBookControl.Add(btnBiography_MemoirBook);
            typeBookControl.Add(btnEconomyBook);
            typeBookControl.Add(btnForeignLanguagesBook);
            typeBookControl.Add(btnLiteratureBook);
            typeBookControl.Add(btnPsychology_LifeSkillsBook);
            typeBookControl.Add(btnRaiseUpChildBook);
            typeBookControl.Add(btnText_ReferenceBook);

            //Initate icon for toggle pictureBox
            pictureBoxIconToggle.Image = imageList20.Images[0];
            //Initate icon for favorite books
            pictureBoxFavoriteIcon.Image = imageList40.Images[0];
            //Initate icon for shop cart picturebox
            pictureBoxShopCart.Image = imageList40.Images[1];
        }

        private void hideSubMenu()
        {
            foreach (Control SubMenu in subMenuControl)
            {
                SubMenu.Visible = false;
            }
            panelToggleDownAccount.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //Close all subMenu before opening the new one
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void pictureBoxIconToggle_Click(object sender, EventArgs e)
        {
            // Suspend layout updates
            panelToggleDownAccount.SuspendLayout();

            if (panelToggleDownAccount.Visible)
            {
                panelToggleDownAccount.Visible = false;
                pictureBoxIconToggle.Image = imageList20.Images[0];
            }
            else
            {
                panelToggleDownAccount.Visible = true;
                pictureBoxIconToggle.Image = imageList20.Images[1];
            }

            // Resume layout updates
            panelToggleDownAccount.ResumeLayout();
        }
        private void labelUsername_Click(object sender, EventArgs e)
        {
            // Suspend layout updates
            panelToggleDownAccount.SuspendLayout();

            panelToggleDownAccount.Visible = !panelToggleDownAccount.Visible;

            // Resume layout updates
            panelToggleDownAccount.ResumeLayout(); 
        }

        private void btnChildrenBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelChildrenBookSubmenu);
        }

        private void btnLiteratureBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelLiteratureSubMenu);

        }

        private void btnEconomyBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEconomySubMenu);

        }

        private void btnPsychology_LifeSkillsBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPsychology_LifeSkillsSubMenu);

        }

        private void btnRaiseUpChildBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelRaiseUpChildSubMenu);

        }

        private void btnBiography_MemoirBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBiography_MemoirsSubMenu);
        }

        private void btnText_ReferenceBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelText_ReferenceBookSubMenu);

        }

        private void btnForeignLanguagesBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelForeignLanguageBooksSubMenu);

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchBox.Text = string.Empty;
            searchBox.ForeColor = Color.Black;
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            searchBox.Text = "    Nhập thông tin sách bạn muốn tìm kiếm...\r\n";
            searchBox.ForeColor = Color.Silver;
        }

        //Get All data about Author by ID
        private DataTable getAuthorBy_ID(int ID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetAuthorByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID",ID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //Get data about Name of Author
        private String getNameAuthor(int ID)
        {
            DataTable dt = getAuthorBy_ID(ID);
            DataRow firstRow = dt.Rows[0];
            String authorName = firstRow["AuthorName"].ToString();
            return authorName;
        }

        //Get All data about Category by ID
        private DataTable getCategoryBy_ID(int ID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetCategoryByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //Get data about Name of Category
        private String getNameCategory(int ID)
        {
            DataTable dt = getCategoryBy_ID(ID);
            DataRow firstRow = dt.Rows[0];
            String categoryName = firstRow["CategoryName"].ToString();
            String subCategoryNAme = firstRow["SubCategoryName"].ToString();
            return categoryName + " - " +subCategoryNAme;
        }

        //Handle event choose book to add to cart
        private void dataGridViewBookShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewBookShow.Columns["AddShopCart"].Index)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewBookShow.Rows[rowIndex];
                String test = row.Cells[1].Value.ToString();
                MessageBox.Show(test);
            }
        }

        private void dataGridViewBookShow_Scroll(object sender, ScrollEventArgs e)
        {
            int totalHeight = 0;
            foreach (DataGridViewRow row in dataGridViewBookShow.Rows)
                totalHeight += row.Height;

            if (totalHeight - dataGridViewBookShow.Height < dataGridViewBookShow.VerticalScrollingOffset)
            {
                SqlConnection conn = new SqlConnection(Program.getConnectString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("[GetNext10Books]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CURRENT_COUNT_ROW", rowCount));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Add columns to show books information briefly
                if (dt.Rows.Count > 0)
                {
                    dt.Columns.Add("BookInfor");
                    dt.Columns.Add("PriceInfor");
                    foreach (DataRow row in dt.Rows)
                    {
                        row["BookInfor"] = row["BookTitle"] + "\n\n" + getNameCategory((int)row["CategoryID"]) + "\n\n" + getNameAuthor((int)row["AuthorID"]) + "\n";
                        String StatusBar = "Còn hàng";
                        if ((int)row["BookQuantity"] == 0)
                        {
                            StatusBar = "Hết Hàng";
                        }

                        row["PriceInfor"] = "\n" + row["Price"] + "\n\n" + "Tình Trạng: " + StatusBar;
                    }
                    dataGridViewBookShow.Invoke((MethodInvoker)delegate ()
                    {
                        dtTest.Merge(dt);
                        dataGridViewBookShow.DataSource = null;
                        dataGridViewBookShow.Rows.Clear();
                        dataGridViewBookShow.DataSource = dtTest;
                        dataGridViewBookShow.Invalidate();
                        dataGridViewBookShow.Refresh();
                        dataGridViewBookShow.Update();
                        dataGridViewBookShow.CurrentCell = dataGridViewBookShow.Rows[rowCount - 1].Cells[0];
                        dataGridViewBookShow.ClearSelection();
                        if (dt.Rows.Count == 10)
                        {
                            rowCount += 10;
                        }
                        else
                        {
                            rowCount += dt.Rows.Count;
                        }

                    });
                    conn.Close();
                }
               
            }
        }
    }
}
