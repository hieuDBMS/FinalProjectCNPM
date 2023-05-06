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
    public partial class CartForm : Form
    {
        Form activeChildForm = null;
        bool initDataGridView = true;
        int paymentMethod = -1;
        float totalPrice = 0;
        List<Book> books = Program.mySettings.shoppingCart.getBookChose();
        public CartForm()
        {            
            InitializeComponent();
        }

        public void openChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                //Dispose the current childForm
                activeChildForm.Close();
            }
            activeChildForm = childForm;
            if (activeChildForm != null)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelAddress.Controls.Add(childForm);
                panelAddress.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            checkUserAuthentication();
            showShopCart();
        }
        private void checkUserAuthentication()
        {
            if(string.IsNullOrEmpty(Properties.Settings.Default.userID))
            {
                NoticeUserLogin_CartForm noticeUserLoginForm= new NoticeUserLogin_CartForm();
                openChildForm(noticeUserLoginForm);
            }
            else
            {
                AddressForm addressForm = new AddressForm();
                openChildForm(addressForm);
            }
        }
        private void showShopCart()
        {
            dataGridViewProduct.DataSource = createDataTable();
            initDataGridView = true;
            updateTotalPrice();
        }
        private DataTable createDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Image", typeof(byte[]));
            dt.Columns.Add("BookName_Price", typeof(string));
            dt.Columns.Add("BookQuantity", typeof(string));
           
            if(books.Count> 0)
            {
                foreach (Book book in books)
                {
                    string nameAndPrice = book.getBookTitle + "\n\n\n\n" + book.getBookPrice;
                    dt.Rows.Add(book.getBookImage, nameAndPrice, book.getBookQuantity.ToString());
                }
            }
            
            return dt;
        }

        private void dataGridViewProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if(initDataGridView)
                dataGridViewProduct.ClearSelection();
        }
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProduct.Columns["BtnDecrease"].Index)
            {
                int rowIndex = e.RowIndex;
                
                DataGridViewRow row = dataGridViewProduct.Rows[rowIndex];
                int bookQuantity = int.Parse(row.Cells[5].Value.ToString());
                if(bookQuantity > 1)
                {
                    dataGridViewProduct.Rows[rowIndex].Cells[5].Value = bookQuantity -1;
                    updateBookQuantity(rowIndex, bookQuantity - 1);
                    // Refresh the modified row to show the updated data
                    dataGridViewProduct.InvalidateRow(e.RowIndex);
                }               
            }
            if (e.ColumnIndex == dataGridViewProduct.Columns["BtnIncrease"].Index)
            {
                int rowIndex = e.RowIndex;

                DataGridViewRow row = dataGridViewProduct.Rows[rowIndex];
                int bookQuantity = int.Parse(row.Cells[5].Value.ToString());
                if (bookQuantity < 99999)
                {
                    dataGridViewProduct.Rows[rowIndex].Cells[5].Value = bookQuantity + 1;
                    updateBookQuantity(rowIndex, bookQuantity+1);
                    // Refresh the modified row to show the updated data
                    dataGridViewProduct.InvalidateRow(e.RowIndex);
                }
            }
            if (e.ColumnIndex == dataGridViewProduct.Columns["BtnRemove"].Index)
            {
                int rowIndex = e.RowIndex;
                removeBook(rowIndex);
                //update shopCart
                showShopCart();
                dataGridViewProduct.Refresh();
            }

        }
        private void removeBook(int index)
        {
            Book book = books[index];
            /*books.RemoveAt(index);*/
            if (Application.OpenForms.OfType<MainForm>().Any())
            {
                // Remove book and update shop cart, books
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                
                mainForm.AddRemoveBookToShopCart(book.getBookID, false);

                // update books
                books = Program.mySettings.shoppingCart.getBookChose();
            }
        }
        private void updateBookQuantity(int index,int newQuantity)
        {
            Book book = books[index];
            book.setBookQuantity = newQuantity;
            updateMySettingsAfterChangeQuantity();
            updateTotalPrice();
        }
        private void updateMySettingsAfterChangeQuantity()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.UpdateMultipleSameAdd(books);
            Program.mySettings.shoppingCart = cart;
            Program.mySettings.Save();         
        }
        private void updateTotalPrice()
        {
            float TotalPrice = 0;
            if(books.Count > 0)
            {
                foreach (Book book in books)
                {
                    TotalPrice += formatPrice(book.getBookPrice)*book.getBookQuantity;
                }
                labelTotalPrice.Text = TotalPrice.ToString() + " vnđ";
                totalPrice = TotalPrice;
            }
            else
            {
                labelTotalPrice.Text = "0 vnđ";
            }          
        }
        private float formatPrice(string price)
        {
            
            if (price.Contains(" vnđ"))
            {
                price = price.Replace(" vnđ","");
                return float.Parse(price)*1000;
            }
            if (price.Contains(" vnd"))
            {
                price = price.Replace(" vnd", "");
                return float.Parse(price)*1000;
            }
            return 0;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.userID))
            {
                
                DialogResult result = MessageBox.Show("Vui lòng đăng nhập để sử dụng chức năng thanh toán", "Đăng nhập", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
            else
            {
                if( books.Count() != 0)
                {
                    DialogResult result = MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        ///create order first
                        ///update order detail of that order by ID                      
                        if (paymentMethod != -1)
                        {
                            int OrderID = createOrder();
                            foreach (Book book in books)
                            {
                                createOrderDetail(OrderID, book.getBookID, book.getBookQuantity);
                            }
                            MessageBox.Show("Thanh toán thành công!");
                            reFreshCartForm();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn phương thức thanh toán");
                        }
                        
                    }
                    else if (result == DialogResult.Cancel)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sách để có thể sử dụng chức năng thanh toán!");
                }
                    
            }
            

        }

        private int createOrder()
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[createOrder]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderDate", DateTime.Today));
            cmd.Parameters.Add(new SqlParameter("@CustomerID", Properties.Settings.Default.userID));
            cmd.Parameters.Add(new SqlParameter("@PaymentID", paymentMethod));
            int newOrderID = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            MessageBox.Show("New Order ID: " + newOrderID.ToString());
            return newOrderID;
            /*SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);*/
        }

        private void createOrderDetail(int orderID, int bookID, int bookQuantity)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[createOrderDetail]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            cmd.Parameters.Add(new SqlParameter("@BookID", bookID));
            cmd.Parameters.Add(new SqlParameter("@Quantity", bookQuantity));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void reFreshCartForm()
        {
            Program.refreshSettings();
            books = Program.mySettings.shoppingCart.getBookChose();
            showShopCart();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            paymentMethod = 2;
            refreshColorPaymentMethodBtn();
            btnBank.FillColor= Color.Silver;
        }

        private void btnDirectPayment_Click(object sender, EventArgs e)
        {
            paymentMethod = 1;
            refreshColorPaymentMethodBtn();
            btnDirectPayment.FillColor = Color.Silver;
        }

        private void btnMoMo_Click(object sender, EventArgs e)
        {
            paymentMethod = 3;
            refreshColorPaymentMethodBtn();
            btnMoMo.FillColor = Color.Silver;
        }

        private void refreshColorPaymentMethodBtn()
        {
            btnBank.FillColor = Color.White;
            btnMoMo.FillColor = Color.White;
            btnDirectPayment.FillColor = Color.White;
        }
    }
}
