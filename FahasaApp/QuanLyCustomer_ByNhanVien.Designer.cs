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
            this.seach_Customer = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
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
            this.seach_Customer.Location = new System.Drawing.Point(39, 16);
            this.seach_Customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seach_Customer.Name = "seach_Customer";
            this.seach_Customer.PasswordChar = '\0';
            this.seach_Customer.PlaceholderText = "";
            this.seach_Customer.SelectedText = "";
            this.seach_Customer.Size = new System.Drawing.Size(679, 36);
            this.seach_Customer.TabIndex = 5;
            this.seach_Customer.TextChanged += new System.EventHandler(this.seach_Customer_TextChanged);
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.Location = new System.Drawing.Point(39, 120);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.RowHeadersWidth = 51;
            this.dataGridView_customer.Size = new System.Drawing.Size(1069, 278);
            this.dataGridView_customer.TabIndex = 4;
            this.dataGridView_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customer_CellContentClick);
            // 
            // QuanLyCustomer_ByNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 415);
            this.Controls.Add(this.seach_Customer);
            this.Controls.Add(this.dataGridView_customer);
            this.Name = "QuanLyCustomer_ByNhanVien";
            this.Text = "QuanLyCustomer_ByNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox seach_Customer;
        private System.Windows.Forms.DataGridView dataGridView_customer;
    }
}