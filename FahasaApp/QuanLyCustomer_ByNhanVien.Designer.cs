namespace FahasaApp
{
    partial class QuanLyCustomer_ByNhanVien
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
            this.seach_Customer = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // seach_Customer
            // 
            this.seach_Customer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seach_Customer.DefaultText = "";
            this.seach_Customer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.seach_Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.seach_Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seach_Customer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seach_Customer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seach_Customer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seach_Customer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seach_Customer.Location = new System.Drawing.Point(29, 48);
            this.seach_Customer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seach_Customer.Name = "seach_Customer";
            this.seach_Customer.PasswordChar = '\0';
            this.seach_Customer.PlaceholderText = "";
            this.seach_Customer.SelectedText = "";
            this.seach_Customer.Size = new System.Drawing.Size(509, 29);
            this.seach_Customer.TabIndex = 5;
            this.seach_Customer.TextChanged += new System.EventHandler(this.seach_Customer_TextChanged);
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.GridColor = System.Drawing.Color.Red;
            this.dataGridView_customer.Location = new System.Drawing.Point(29, 98);
            this.dataGridView_customer.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_customer.Name = "dataGridView_customer";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_customer.RowHeadersWidth = 51;
            this.dataGridView_customer.RowTemplate.Height = 30;
            this.dataGridView_customer.Size = new System.Drawing.Size(1076, 262);
            this.dataGridView_customer.TabIndex = 4;
            this.dataGridView_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customer_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm Kiếm Khách Hàng";
            // 
            // QuanLyCustomer_ByNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seach_Customer);
            this.Controls.Add(this.dataGridView_customer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyCustomer_ByNhanVien";
            this.Text = "QuanLyCustomer_ByNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox seach_Customer;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.Label label1;
    }
}