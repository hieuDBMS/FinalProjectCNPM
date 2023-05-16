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
    public partial class FormOrderCrypstalReport : Form
    {
        public int orderID = 0;
        public FormOrderCrypstalReport(int OrderID)
        {
            InitializeComponent();
            this.orderID = OrderID;
        }

        private void FormOrderCrypstalReport_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(orderID.ToString());
            try
            {
                SqlDataAdapter da_detail = getDetailBill();
                SqlDataAdapter da_totalPrice = getTotalPrice();

                DataSet dataReport = new DataSet();
                da_detail.Fill(dataReport, "ORDER_BILL");
                da_totalPrice.Fill(dataReport, "TOTALPRICE");
                if (dataReport == null)
                {
                    //MessageBox.Show("EMpty");
                }
                else
                {
                    //MessageBox.Show("Not Empty");
                }
                //Add data to cryreport
                OrderCrystalReport Order_Detail_Report = new OrderCrystalReport();
                Order_Detail_Report.SetDataSource(dataReport);

                //Add crypreport to viewer
                crystalReportViewer.ReportSource = Order_Detail_Report;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private SqlDataAdapter getDetailBill()
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[getOrderBill]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conn.Close();
            return da;
        }
        private SqlDataAdapter getTotalPrice()
        {
            SqlConnection conn = new SqlConnection(Program.getConnectString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[getTotalBillPrice]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conn.Close();
            return da;
        }
    }
}
