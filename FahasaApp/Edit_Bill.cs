﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class Edit_Bill : Form
    {
        private AdminForm_Bill adminForm;
        private int orderID;
        public Edit_Bill(AdminForm_Bill adminForm, int orderID)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            this.orderID = orderID;
            TextBox_ID_HD.TextChanged += TextBox_ID_HD_TextChanged;
            LoadOrderData(orderID);
        }

        private void TextBox_ID_HD_TextChanged(object sender, EventArgs e)
        {
            int orderID;
            if (int.TryParse(TextBox_ID_HD.Text, out orderID))
            {
                LoadOrderData(orderID);
            }
        }

        private void LoadOrderData(int orderID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [ORDER] WHERE OrderID = @OrderID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TextBoxDate.Text = Convert.ToDateTime(reader["OrderDate"]).ToString("dd/MM/yyyy");
                    TextBoxID_DatHang.Text = reader["CustomerID"].ToString();
                    TextBoxTotalMoney.Text = reader["TotalPrice"].ToString() + " VNĐ";
                    TextBoxAddress.Text = reader["Address"].ToString();
                    TextBoxPaymentID.Text = reader["PaymentID"].ToString();
                }
                else
                {
                    TextBoxDate.Clear();
                    TextBoxID_DatHang.Clear();
                    TextBoxTotalMoney.Clear();
                    TextBoxAddress.Clear();
                    TextBoxPaymentID.Clear();
                }
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Get the input values
            int orderID = Convert.ToInt32(TextBox_ID_HD.Text);
            DateTime orderDate = DateTime.ParseExact(TextBoxDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int customerID = Convert.ToInt32(TextBoxID_DatHang.Text);
            float totalPrice = float.Parse(TextBoxTotalMoney.Text);
            string address = TextBoxAddress.Text;
            int paymentID = Convert.ToInt32(TextBoxPaymentID.Text);

            // Update the order in the database
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [ORDER] SET OrderDate = @OrderDate, CustomerID = @CustomerID, TotalPrice = @TotalPrice, Address = @Address, PaymentID = @PaymentID WHERE OrderID = @OrderID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderID);
                command.Parameters.AddWithValue("@OrderDate", orderDate);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@PaymentID", paymentID);
                connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    MessageBox.Show("Error updating data into Database!");
                else
                {
                    MessageBox.Show("Data has been updated successfully!");
                    // Refresh the gridview data, you need to implement this method on your own
                    // For example, if you have a method named LoadData in the parent form, you can call
                    // parentForm.LoadData();
                    this.Close();  // Close the current form
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
                    this.Close();

        }
    }
}
