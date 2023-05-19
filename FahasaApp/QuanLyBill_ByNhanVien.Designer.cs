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
            this.seach_Bill = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_bill = new System.Windows.Forms.DataGridView();
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
            this.seach_Bill.Location = new System.Drawing.Point(39, 16);
            this.seach_Bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seach_Bill.Name = "seach_Bill";
            this.seach_Bill.PasswordChar = '\0';
            this.seach_Bill.PlaceholderText = "";
            this.seach_Bill.SelectedText = "";
            this.seach_Bill.Size = new System.Drawing.Size(679, 36);
            this.seach_Bill.TabIndex = 7;
            this.seach_Bill.TextChanged += new System.EventHandler(this.seach_Bill_TextChanged_1);
            // 
            // dataGridView_bill
            // 
            this.dataGridView_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bill.Location = new System.Drawing.Point(39, 120);
            this.dataGridView_bill.Name = "dataGridView_bill";
            this.dataGridView_bill.RowHeadersWidth = 51;
            this.dataGridView_bill.Size = new System.Drawing.Size(1069, 278);
            this.dataGridView_bill.TabIndex = 6;
            this.dataGridView_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bill_CellContentClick);
            // 
            // QuanLyBill_ByNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 415);
            this.Controls.Add(this.seach_Bill);
            this.Controls.Add(this.dataGridView_bill);
            this.Name = "QuanLyBill_ByNhanVien";
            this.Text = "QuanLyBill_ByNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox seach_Bill;
        private System.Windows.Forms.DataGridView dataGridView_bill;
    }
}