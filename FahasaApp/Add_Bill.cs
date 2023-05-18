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
    public partial class Add_Bill : Form
    {
        private AdminForm_Bill adminForm;
        public Add_Bill(AdminForm_Bill adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;

            TextBox_ID_HD.ReadOnly = true;  // Prevent user input

            // Fetch the max ID from the database and increment by 1
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(OrderID) AS MaxOrderID FROM [ORDER]";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int MaxOrderID = reader["MaxOrderID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MaxOrderID"]);
                    TextBox_ID_HD.Text = (MaxOrderID + 1).ToString();
                }
            }
        }


        private void TextBox_ID_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxID_DatHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxTotalMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPaymentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the input values
            DateTime orderDate = DateTime.ParseExact(TextBoxDate.Text, "dd/MM/yyyy", null);
            int customerID = Int32.Parse(TextBoxID_DatHang.Text);
            double totalPrice = Double.Parse(TextBoxTotalMoney.Text.Replace(" VNĐ", ""));
            string address = TextBoxAddress.Text;
            int paymentID = Int32.Parse(TextBoxPaymentID.Text);

            // Insert the new order into the database
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [ORDER] (OrderDate, CustomerID, TotalPrice, Address, PaymentID) VALUES (@OrderDate, @CustomerID, @TotalPrice, @Address, @PaymentID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderDate", orderDate);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@PaymentID", paymentID);
                connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    MessageBox.Show("Error inserting data into the database!");
                else
                {
                    MessageBox.Show("Data has been inserted successfully!");
                    adminForm.LoadData();  // Call the method to refresh the gridview data
                    this.Close();  // Close the current form
                }
            }
        }
    }
}
