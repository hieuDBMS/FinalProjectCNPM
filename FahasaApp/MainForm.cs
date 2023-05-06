using FahasaApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FahasaApp
{
 #region Hieu
    public partial class MainForm : Form
    {
        List<Panel> subMenuControl = new List<Panel>();
        List<Button> typeBookControl = new List<Button>();
        Dictionary<string, string> dateList = new Dictionary<string, string>();

        private int rowCount = 0;   // for load more data to mainform
        private int rowCountCateogy = 0; // for load more data of category datagridview

        DataTable currentDataTable = new DataTable();
        DataTable currentCategoryTable = new DataTable();
        DataTable DayWeekMonthYear_BooksTable= new DataTable();
        DataTable currentMainDataTable = new DataTable();
        DataTable allBooks = new DataTable();

        ///
        Form activeChildForm = null;
        DataGridView currentDataGridView = null;

        int currentCategoryID = -1;
        public int currentRowCell = 0; //may be used for detail product
        public bool findBooks = false; // for handle scroll event
        public bool dateSearch = false; // for handle search book by day week month year week
        public bool isStartingFocus = true;
        public bool hasDataDetailProductForm = false;


        public MainForm()
        {
            InitializeComponent();
            initControlLists();
            hideSubMenu();


            //InitiaForm before login - vin
            InitiaForm();
 

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
                da.Dispose();
                if (dt.Rows.Count > 0 )
                {
                    rowCount = dt.Rows.Count;
                    dt = createColumn_And_ChangeInformationOfColumn(dt);
                    dataGridViewBookShow.AutoGenerateColumns = false;
                    dataGridViewBookShow.DataSource = dt;
                    dataGridViewBookShow.ClearSelection();
                    currentMainDataTable = dt;
                    //set current Datatable is main Form when initalize the Form Main.
                    currentDataTable = currentMainDataTable;
                }
                /*MessageBox.Show()*/
                
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
            typeBookControl.Add(btnBiography_MemoryBook);
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
            //Initate icon for icon fire
            iconFire.Image = imageList40.Images[2];

            //Init list date for Book searching following by day, week, motnh, year
            dateList.Add("Ngày","Day");
            dateList.Add("Tuần","Week");
            dateList.Add("Tháng","Month");
            dateList.Add("Năm","Year");

            //Init current Datagridview
            currentDataGridView = dataGridViewBookShow;

            //Set backButton InVisible
            BackButton.Visible = false;

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

            // panelToggleDownAccount.Visible = !panelToggleDownAccount.Visible;
            pictureBoxIconToggle_Click(sender, e);
            // Resume layout updates
            panelToggleDownAccount.ResumeLayout(); 
        }

        //Find book in Childrent Books
        private void btnChildrenBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelChildrenBookSubmenu);
            
        }
        private void btnFindManga_Comic_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(17);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        private void btnFindKienThucBachKhoa_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(18);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        private void btnFindTranhKyNangSong_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(19);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        private void btnFindVuaHocVuaChoi_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(20);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Find book in Literature Books
        private void btnLiteratureBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelLiteratureSubMenu);

        }
        private void btnFindTieuThuyet_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(1);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        private void btnFindTruyenNgan_TanVan_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(2);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindLightNovel_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(3);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindNgonTinh_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(4);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Find book in Economy Books
        private void btnEconomyBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEconomySubMenu);

        }
        private void btnFindNhanVat_BaiHocKinhDoanh_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(5);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindQuanTri_LanhDao_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(6);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindMarketing_BanHang_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(7);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindPhanTichKinhTe_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(8);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Find book in Psychology_LifeSkillsBook Books
        private void btnPsychology_LifeSkillsBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPsychology_LifeSkillsSubMenu);
        }
        private void btnFindKyNangSong_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(9);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindRenLuyenNhanCach_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(10);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindTamLy_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(11);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindSachChoTuoiMoiLon_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(12);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Find book in RaiseUpChild Books
        private void btnRaiseUpChildBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelRaiseUpChildSubMenu);
        }
        private void btnFindCamNangLamChaMe_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(13);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindPhuongPhapGiaoDucTre_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(14);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindPhatTrienTriTueChoTre_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(15);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindPhatTrienKyNangChoTre_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(16);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Find book in Biography_Memory Books
        private void btnBiography_MemoryBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBiography_MemoirsSubMenu);
        }

        private void btnFindCauChuyenCuocDoi_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(21);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindChinhTri_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(22);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindKinhTe_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(23);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindNgheThuatGiaiTri_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(24);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Find book in Text_Reference Books
        private void btnText_ReferenceBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelText_ReferenceBookSubMenu);
        }

        private void btnFindSachGiaoKhoa_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(25);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindSachThamKhao_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(26);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindSachChoGiaoVien_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(27);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindMauGiao_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(28);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Find book in ForeignLanguages Books
        private void btnForeignLanguagesBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelForeignLanguageBooksSubMenu);
        }

        private void btnFindSachTiengAnh_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(29);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindSachTiengNhat_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(30);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindSachTiengHoa_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(31);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }

        private void btnFindSachTiengHan_Click(object sender, EventArgs e)
        {
            getBookByCategoryID_RefreshSearchBox(32);
            searchBox_Leave(sender, e); //remove the focus on searchBox
            closeChildFormAndOpenGridView();
        }
        //

        //Button to the Home screen
        private void btnHome_Click(object sender, EventArgs e)
        {
            closeChildFormAndOpenGridView();
            hideSubMenu();
            searchBox.Text = string.Empty; //clear current text, replace the filtered with currentDatatable and set notice text for search box
            searchBox_Leave(sender,e);  //this line will
            comboBoxSearch_DayMonthYear.SelectedIndex = -1;
            dateSearch = false; // refresh search engine
            // Replace the datatable of category book with currentDatatable
            if (currentCategoryID != -1)
            {
                currentCategoryID = -1;
                currentDataTable = currentMainDataTable;
                updateDatagrideViewBySubCategory(currentDataTable,false);
            }
            else
            {
                currentDataTable = currentMainDataTable;
                updateDatagrideViewBySubCategory(currentDataTable, false);
            }
            dataGridViewBookShow.CurrentCell = dataGridViewBookShow.Rows[0].Cells[0];  // move to the top of the datatable

            //refresh category instances
            currentCategoryTable.Rows.Clear();
            currentCategoryTable.Columns.Clear();
            rowCountCateogy = 0;
        }

        private void updateDatagrideViewBySubCategory(DataTable dt, bool flagToCreate) 
        {
            dataGridViewBookShow.Invoke((MethodInvoker)delegate ()
            {
                dataGridViewBookShow.DataSource = null;
                dataGridViewBookShow.Rows.Clear();
                if (flagToCreate) // used to identify the dataTable is adjusted or not
                {
                    currentDataTable = createColumn_And_ChangeInformationOfColumn(dt);
                    dataGridViewBookShow.DataSource = currentDataTable;
                }

                else
                    dataGridViewBookShow.DataSource = dt;

                dataGridViewBookShow.Invalidate();
                dataGridViewBookShow.Refresh();
                dataGridViewBookShow.Update();
                dataGridViewBookShow.ClearSelection();               
            });
        }

        private void getBookByCategoryID_RefreshSearchBox(int categoryID)
        {
            //Clear the previous table before get the new one
            currentCategoryTable.Rows.Clear();
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetBooksByCategory]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", categoryID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            currentCategoryTable = dt;
            ///
            currentDataTable = currentCategoryTable;
            ///
            currentCategoryID = categoryID;
            rowCountCateogy = dt.Rows.Count;
            updateDatagrideViewBySubCategory(currentDataTable, true);

            searchBox.ForeColor = Color.Silver;
            searchBox.Text = "    Nhập thông tin sách bạn muốn tìm kiếm...\r\n";
            isStartingFocus = true;
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
            da.Dispose();
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
            da.Dispose();
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

        //Get All data about Publisher by ID
        private DataTable getPublisherBy_ID(int ID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetPublisherByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        //Get data about Name of Publisher
        private String getNamePublisher(int ID)
        {
            DataTable dt = getPublisherBy_ID(ID);
            DataRow firstRow = dt.Rows[0];
            String publisherName = firstRow["Name"].ToString();
            return publisherName;
        }

        //Get all data about Book by ID
        private DataTable getBookByID(int ID)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetBookByID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        //Handle event choose book to add to cart
        private void dataGridViewBookShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewBookShow.Columns["AddShopCart"].Index)
            {
                int rowIndex = e.RowIndex;
                currentRowCell = rowIndex;
                DataGridViewRow row = dataGridViewBookShow.Rows[rowIndex];
                int bookID = int.Parse(row.Cells[4].Value.ToString());
                AddRemoveBookToShopCart(bookID,true);

            }
            else
            {
                currentRowCell = e.RowIndex;
                DataGridViewRow row = dataGridViewBookShow.Rows[currentRowCell];
                /*byte[] bookImage = (byte[])row.Cells[0].Value;*/
                int bookID = int.Parse(row.Cells[4].Value.ToString());
                               
                /*MessageBox.Show(publicationDate + "/" + publisher + "/" + author);*/
                Book detailBook = createBookInstance(bookID);
                if(detailBook != null)
                {
                    DetailProduct dProduct = new DetailProduct(detailBook);
                    openChildForm(dProduct);
                }              
            }
        }

        public void AddRemoveBookToShopCart(int bookID, bool flagUpdate)
        {
            Book book = createBookInstance(bookID);

            Program.updateMySetting(book, flagUpdate);
            //MessageBox.Show(Program.getQuantity().ToString());
        }

        public void RemoveBookFromShopCart(int bookID)
        {
            Book book = createBookInstance(bookID);
            Program.updateMySetting(book, false);
        }

        private Book createBookInstance(int bookID)
        {
            Book detailBook = null;
            DataTable bookTable = getBookByID(bookID);

            if (bookTable.Rows.Count > 0)
            {
                byte[] bookImage = (byte[])bookTable.Rows[0]["Image"];
                DateTime tempPublication = (DateTime)bookTable.Rows[0]["PublicationDate"];

                string category = getNameCategory((int)bookTable.Rows[0]["CategoryID"]);
                string publicationDate = tempPublication.ToString("dd-MM-yyyy");
                string publisher = getNamePublisher((int)bookTable.Rows[0]["PublisherID"]);
                string author = getNameAuthor((int)bookTable.Rows[0]["AuthorID"]);


                /*MessageBox.Show(publicationDate + "/" + publisher + "/" + author);*/
                detailBook = new Book(bookID, bookTable.Rows[0]["BookTitle"].ToString(), bookTable.Rows[0]["BookCover"].ToString(), category, bookTable.Rows[0]["Price"].ToString(),
                    publicationDate, publisher, author, bookImage);
                return detailBook;
            }
            else
            {
                MessageBox.Show("Sách hiện đang không khả dụng !");
                return null;
            }
         
            
        }


        private void dataGridViewBookShow_Scroll(object sender, ScrollEventArgs e)
        {
            if (!findBooks && !dateSearch)
            {             
                int totalHeight = 0;
                foreach (DataGridViewRow row in dataGridViewBookShow.Rows)
                    totalHeight += row.Height;

                if (totalHeight - dataGridViewBookShow.Height < dataGridViewBookShow.VerticalScrollingOffset)
                {
                    int RowCount = -1;
                    if (currentCategoryID != -1)
                        RowCount = rowCountCateogy;
                    else
                        RowCount = rowCount;

                    SqlConnection conn = new SqlConnection(Program.getConnectString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[GetNext10Books]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CURRENT_COUNT_ROW", RowCount));
                    cmd.Parameters.Add(new SqlParameter("@CATEGORY_ID", currentCategoryID));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    //Add columns to show books information briefly
                    if (dt.Rows.Count > 0)
                    {
                        dt = createColumn_And_ChangeInformationOfColumn(dt);
                        dataGridViewBookShow.Invoke((MethodInvoker)delegate ()
                        {
                            DataTable dataToUpdate = new DataTable();
                            if(currentCategoryID == -1)
                            {
                                currentMainDataTable.Merge(dt);
                                currentDataTable = currentMainDataTable;
                                //currentDataTable.Merge(dt);
                                dataToUpdate = currentDataTable;
                            }
                            else
                            {
                                currentCategoryTable.Merge(dt);
                                // Set currentTable is CategoryTable
                                currentDataTable = currentCategoryTable;
                                dataToUpdate = currentDataTable;
                            }                               
                            dataGridViewBookShow.DataSource = null;
                            dataGridViewBookShow.Rows.Clear();
                            dataGridViewBookShow.DataSource = dataToUpdate;
                            dataGridViewBookShow.Invalidate();
                            dataGridViewBookShow.Refresh();
                            dataGridViewBookShow.Update();
                            dataGridViewBookShow.CurrentCell = dataGridViewBookShow.Rows[RowCount - 1].Cells[0];
                            dataGridViewBookShow.ClearSelection();
                            //add rowcount for Main Table
                            if(currentCategoryID == -1)
                            {
                                if (dt.Rows.Count == 10)
                                {
                                    rowCount += 10;
                                }
                                else
                                {
                                    rowCount += dt.Rows.Count;
                                }
                            }
                            //add rowcount for category
                            else
                            {
                                if (dt.Rows.Count == 10)
                                {
                                    rowCountCateogy += 10;
                                }
                                else
                                {
                                    rowCountCateogy += dt.Rows.Count;
                                }
                            }                            

                        });
                        conn.Close();
                    }

                }
            }
            
        }

        //Add BookInfor and PriceInfor column for dt, and customer the data of that column
        private DataTable createColumn_And_ChangeInformationOfColumn(DataTable dt)
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
            return dt;
        }

        //Handle event click mouse on searchBox
        private void searchBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (searchBox.Text == "    Nhập thông tin sách bạn muốn tìm kiếm...\r\n")
            {
                isStartingFocus = false;
                searchBox.Text = string.Empty;
                searchBox.ForeColor = Color.Black;
                
            }
        }

        //Handle event remove mouse on searchBox
        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchBox.Text))
            {
                searchBox.Text = "    Nhập thông tin sách bạn muốn tìm kiếm...\r\n";
                searchBox.ForeColor = Color.Silver;
                isStartingFocus = true;
            }    
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "    Nhập thông tin sách bạn muốn tìm kiếm...\r\n")
            {
                //Get all books from data if Search function is triggered
                if(allBooks.Rows.Count == 0) 
                {
                    getAllBooks();                  
                }

                if (allBooks.Rows.Count > 0)
                {
                    // Create a new DataTable with the same schema as the original table
                    DataTable filteredTable = allBooks.Clone();
                    
                    string searchContent = searchBox.Text.ToLower().Trim();

                    //Find book once the searchContent is not empty
                    if (!String.IsNullOrEmpty(searchContent))
                    {
                        foreach (DataRow row in allBooks.Rows)
                        {
                            //find book title
                            if (row["BookTitle"].ToString().ToLower().Trim().Contains(searchContent) )
                            {
                                filteredTable.ImportRow(row);
                            }
                            //Find publication date
                            else if (DateTime.Parse(row["PublicationDate"].ToString()).ToString("d/M/yyyy").Trim().Contains(searchContent) )
                            {
                                filteredTable.ImportRow(row);
                            }
                            //Find author
                            else if (getNameAuthor(int.Parse(row["AuthorID"].ToString())).ToLower().Trim().Contains(searchContent) )
                            {
                                filteredTable.ImportRow(row);
                            }
                            //Find category
                            else if (getNameCategory(int.Parse(row["CategoryID"].ToString())).ToLower().Trim().Contains(searchContent) )
                            {
                                filteredTable.ImportRow(row);
                            }
                            //Find publisher
                            else if (getNamePublisher(int.Parse(row["PublisherID"].ToString())).ToLower().Trim().Contains(searchContent))
                            {
                                filteredTable.ImportRow(row);
                            }
                        }
                        //MessageBox.Show(count.ToString());
                    }

                    //When found the book
                    if (filteredTable.Rows.Count > 0)
                    {
                        filteredTable = createColumn_And_ChangeInformationOfColumn(filteredTable);
                        findBooks = true;
                        txtNoticeBookNotFound.Visible = false;
                        //MessageBox.Show(currentDataTable.Rows.Count.ToString() + "can find > 0" + "/" + searchContent);
                    }
                    //When book can not be found
                    if (filteredTable.Rows.Count == 0 && searchContent != "")
                    {
                        txtNoticeBookNotFound.Visible = true;
                        findBooks = true;
                        //MessageBox.Show(currentDataTable.Rows.Count.ToString() + "can be found" + "/" + searchContent);
                    }
                    //When the text in the searchBox is deleted emptily and is not a startingfocus, back to the currentDatable of books
                    if (filteredTable.Rows.Count == 0 && searchContent == "" && !isStartingFocus)
                    {
                        currentCategoryID = -1;
                        filteredTable = currentDataTable;                        
                        txtNoticeBookNotFound.Visible = false;
                        findBooks = false;
                        //remove all book when search function end
                        removeAllBooks();
                        //MessageBox.Show(currentDataTable.Rows.Count.ToString() + "search box is empty");
                    }
                    //Update datagrid when the textchange and the search box is not a starting focus
                    if (!isStartingFocus)
                    {
                        dataGridViewBookShow.Invoke((MethodInvoker)delegate ()
                        {
                            dataGridViewBookShow.DataSource = null;
                            dataGridViewBookShow.Rows.Clear();
                            dataGridViewBookShow.DataSource = filteredTable;
                            dataGridViewBookShow.Invalidate();
                            dataGridViewBookShow.Refresh();
                            dataGridViewBookShow.Update();
                            dataGridViewBookShow.ClearSelection();                           
                        });
                    }               
                }
            }
            
        }

        private void getAllBooks()
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetAllBooks]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(allBooks);
            conn.Close();
            da.Dispose();
        }

        private void removeAllBooks()
        {
            allBooks.Clear();
        }

        private void comboBoxSearch_DayMonthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateSearch = true;
            foreach (KeyValuePair<string, string> dateType in dateList)
            {
                if (comboBoxSearch_DayMonthYear.Text == dateType.Key)
                {
                    //Refresh the searchBox
                    searchBox_Leave(sender, e);
                    //Get searched books
                    SqlConnection conn = new SqlConnection(Program.getConnectString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[GetBooksBy" + dateType.Value + "]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(DayWeekMonthYear_BooksTable);
                    conn.Close();
                    da.Dispose();
                    //MessageBox.Show("[GetBooksBy" + date + "]");
                    dataGridViewBookShow.DataSource = createColumn_And_ChangeInformationOfColumn(DayWeekMonthYear_BooksTable); ;
                    dataGridViewBookShow.Refresh();
                    dataGridViewBookShow.Update();
                    dataGridViewBookShow.ClearSelection();
                    //Refresh data table
                    DayWeekMonthYear_BooksTable = new DataTable();
                    break;
                }

            }
        }
/// <summary>
/// Section to Detail Book
/// </summary>
        
        private void openChildForm(Form childForm)
        {
            ///store current Datagridview
            currentDataGridView = dataGridViewBookShow;
            if(activeChildForm != null)
            {
                //Dispose the current childForm
                activeChildForm.Close();
            }
            activeChildForm= childForm;
            if(activeChildForm != null)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle= FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelShowBoooks.Controls.Add(childForm);
                panelShowBoooks.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                hasDataDetailProductForm = true;
            }
            hideAndShowSearchSection_BackButton();
        }
        private void closeChildFormAndOpenGridView()
        {
            if(activeChildForm != null)
            {
                panelShowBoooks.Controls.Remove(activeChildForm);
                panelShowBoooks.Tag = null;
                panelShowBoooks.Controls.Add(currentDataGridView);
                activeChildForm.Close();
                hasDataDetailProductForm = false;
                hideAndShowSearchSection_BackButton();
            }

        }

        private void hideAndShowSearchSection_BackButton()
        {
            if(hasDataDetailProductForm)
            {
                TitleSearch.Visible = false;
                iconFire.Visible = false;
                comboBoxSearch_DayMonthYear.Visible = false;
                BackButton.Visible = true;

            }
            else
            {
                TitleSearch.Visible = true;
                iconFire.Visible = true;
                comboBoxSearch_DayMonthYear.Visible = true;
                BackButton.Visible = false;

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            closeChildFormAndOpenGridView();
        }

        private void pictureBoxShopCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            openChildForm(cartForm);
        }
        #endregion

        #region Vin

        private static string InitialUserName;
        private static string InitialBTNSignInText;
        private static string InitialBTNSigupText;

        private void OpenLoginForm(object sender, EventArgs e)
        {
            LoginForm Loginform = new LoginForm();
            Loginform.Show();
            
        }
        
        private void OpenRegisterForm(object sender, EventArgs e)
        {
            //Hide Panel
            pictureBoxIconToggle_Click(sender, e);

            RegisterForm RegisForm = new RegisterForm();   
            RegisForm.Show();
        }

        private void OpenInforUserForm(object sender, EventArgs e)
        {
            //Hide Panel
            pictureBoxIconToggle_Click(sender, e);


            LoginForm Loginform = new LoginForm();
            Loginform.Show();
        }

        private void LogoutAccount(object sender, EventArgs e)
        {
            //Hide Panel
            pictureBoxIconToggle_Click(sender, e);


            labelUsername.Text = InitialUserName;
            btnSignIn.Text  = InitialBTNSignInText;
            btnSignUp.Text = InitialBTNSigupText;

            // Change Event Label Click
            this.btnSignIn.Click += new System.EventHandler(this.OpenLoginForm);
            this.btnSignIn.Click -= new System.EventHandler(this.OpenInforUserForm);

            this.btnSignUp.Click += new System.EventHandler(this.OpenRegisterForm);
            this.btnSignUp.Click -= new System.EventHandler(this.LogoutAccount);

            MessageBox.Show("Bạn đã đăng xuất");
        }

        private void InitiaForm()
        {
            InitialUserName = labelUsername.Text;
            InitialBTNSignInText = btnSignIn.Text;
            InitialBTNSigupText = btnSignUp.Text;
        }

        public void SyncDataUser(string userID,string username,string userPhone, string userAddress)
        {
            labelUsername.Text = username;
            Properties.Settings.Default.userID = userID;
            Properties.Settings.Default.username= username;
            Properties.Settings.Default.userPhone = userPhone;
            Properties.Settings.Default.userAddress = userAddress;
            btnSignIn.Text = "Thông tin ";
            btnSignUp.Text = "Đăng xuất";
            this.Refresh();

            // Change Event Label Click
            this.btnSignIn.Click -= new System.EventHandler(this.OpenLoginForm);
            this.btnSignIn.Click += new System.EventHandler(this.OpenInforUserForm);

            this.btnSignUp.Click -= new System.EventHandler(this.OpenRegisterForm);
            this.btnSignUp.Click += new System.EventHandler(this.LogoutAccount);

            panelToggleDownAccount.Visible= false;
        }



        #endregion

    }

}
