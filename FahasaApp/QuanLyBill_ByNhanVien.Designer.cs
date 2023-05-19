namespace FahasaApp
{
    partial class QuanLyBill_ByNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seach_Bill = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_bill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // seach_Bill
            // 
            this.seach_Bill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seach_Bill.DefaultText = "";
            this.seach_Bill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.seach_Bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.seach_Bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seach_Bill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seach_Bill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seach_Bill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seach_Bill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seach_Bill.Location = new System.Drawing.Point(29, 52);
            this.seach_Bill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seach_Bill.Name = "seach_Bill";
            this.seach_Bill.PasswordChar = '\0';
            this.seach_Bill.PlaceholderText = "";
            this.seach_Bill.SelectedText = "";
            this.seach_Bill.Size = new System.Drawing.Size(872, 29);
            this.seach_Bill.TabIndex = 7;
            this.seach_Bill.TextChanged += new System.EventHandler(this.seach_Bill_TextChanged_1);
            // 
            // dataGridView_bill
            // 
            this.dataGridView_bill.AllowUserToAddRows = false;
            this.dataGridView_bill.AllowUserToDeleteRows = false;
            this.dataGridView_bill.AllowUserToOrderColumns = true;
            this.dataGridView_bill.AllowUserToResizeColumns = false;
            this.dataGridView_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bill.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bill.GridColor = System.Drawing.Color.Red;
            this.dataGridView_bill.Location = new System.Drawing.Point(29, 98);
            this.dataGridView_bill.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_bill.Name = "dataGridView_bill";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bill.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_bill.RowHeadersWidth = 51;
            this.dataGridView_bill.Size = new System.Drawing.Size(1076, 262);
            this.dataGridView_bill.TabIndex = 6;
            this.dataGridView_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bill_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // QuanLyBill_ByNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seach_Bill);
            this.Controls.Add(this.dataGridView_bill);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyBill_ByNhanVien";
            this.Text = "QuanLyBill_ByNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox seach_Bill;
        private System.Windows.Forms.DataGridView dataGridView_bill;
        private System.Windows.Forms.Label label1;
    }
}