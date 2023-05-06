namespace FahasaApp
{
    partial class CartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelPay = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelTotalPrice = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTextPay = new System.Windows.Forms.Label();
            this.flowLayoutPanelPayButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.panelShowProduct = new System.Windows.Forms.Panel();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.BookName_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDecrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnIncrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChoosePayment = new System.Windows.Forms.Panel();
            this.btnMoMo = new Guna.UI2.WinForms.Guna2Button();
            this.btnDirectPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnBank = new Guna.UI2.WinForms.Guna2Button();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCartFormMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPay.SuspendLayout();
            this.flowLayoutPanelTotalPrice.SuspendLayout();
            this.flowLayoutPanelPayButton.SuspendLayout();
            this.panelShowProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelChoosePayment.SuspendLayout();
            this.tableLayoutPanelCartFormMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPay
            // 
            this.tableLayoutPanelPay.ColumnCount = 1;
            this.tableLayoutPanelPay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPay.Controls.Add(this.flowLayoutPanelTotalPrice, 0, 0);
            this.tableLayoutPanelPay.Controls.Add(this.flowLayoutPanelPayButton, 0, 1);
            this.tableLayoutPanelPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPay.Location = new System.Drawing.Point(3, 933);
            this.tableLayoutPanelPay.Name = "tableLayoutPanelPay";
            this.tableLayoutPanelPay.RowCount = 2;
            this.tableLayoutPanelPay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelPay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelPay.Size = new System.Drawing.Size(1105, 194);
            this.tableLayoutPanelPay.TabIndex = 2;
            // 
            // flowLayoutPanelTotalPrice
            // 
            this.flowLayoutPanelTotalPrice.Controls.Add(this.labelTotalPrice);
            this.flowLayoutPanelTotalPrice.Controls.Add(this.labelTextPay);
            this.flowLayoutPanelTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTotalPrice.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelTotalPrice.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelTotalPrice.Name = "flowLayoutPanelTotalPrice";
            this.flowLayoutPanelTotalPrice.Size = new System.Drawing.Size(1105, 67);
            this.flowLayoutPanelTotalPrice.TabIndex = 0;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.labelTotalPrice.Location = new System.Drawing.Point(910, 10);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(0, 10, 80, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(115, 29);
            this.labelTotalPrice.TabIndex = 2;
            this.labelTotalPrice.Text = "Tổng tiền";
            // 
            // labelTextPay
            // 
            this.labelTextPay.AutoSize = true;
            this.labelTextPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextPay.Location = new System.Drawing.Point(631, 10);
            this.labelTextPay.Margin = new System.Windows.Forms.Padding(0, 10, 50, 0);
            this.labelTextPay.Name = "labelTextPay";
            this.labelTextPay.Size = new System.Drawing.Size(229, 31);
            this.labelTextPay.TabIndex = 3;
            this.labelTextPay.Text = "Tổng Thanh Toán";
            // 
            // flowLayoutPanelPayButton
            // 
            this.flowLayoutPanelPayButton.Controls.Add(this.btnPay);
            this.flowLayoutPanelPayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPayButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelPayButton.Location = new System.Drawing.Point(0, 67);
            this.flowLayoutPanelPayButton.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelPayButton.Name = "flowLayoutPanelPayButton";
            this.flowLayoutPanelPayButton.Size = new System.Drawing.Size(1105, 127);
            this.flowLayoutPanelPayButton.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 10;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Red;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(875, 0);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(180, 45);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panelShowProduct
            // 
            this.panelShowProduct.Controls.Add(this.dataGridViewProduct);
            this.panelShowProduct.Controls.Add(this.guna2Panel1);
            this.panelShowProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowProduct.Location = new System.Drawing.Point(30, 200);
            this.panelShowProduct.Margin = new System.Windows.Forms.Padding(30, 20, 30, 0);
            this.panelShowProduct.Name = "panelShowProduct";
            this.panelShowProduct.Size = new System.Drawing.Size(1051, 580);
            this.panelShowProduct.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.ColumnHeadersVisible = false;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.BookName_Price,
            this.BtnDecrease,
            this.BookQuantity,
            this.BtnIncrease,
            this.BtnRemove});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.GridColor = System.Drawing.Color.LightSalmon;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProduct.MultiSelect = false;
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewProduct.RowTemplate.Height = 150;
            this.dataGridViewProduct.RowTemplate.ReadOnly = true;
            this.dataGridViewProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1051, 580);
            this.dataGridViewProduct.TabIndex = 8;
            this.dataGridViewProduct.VirtualMode = true;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            this.dataGridViewProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewProduct_DataBindingComplete);
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Image.DefaultCellStyle = dataGridViewCellStyle10;
            this.Image.FillWeight = 50F;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // BookName_Price
            // 
            this.BookName_Price.DataPropertyName = "BookName_Price";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookName_Price.DefaultCellStyle = dataGridViewCellStyle11;
            this.BookName_Price.FillWeight = 200F;
            this.BookName_Price.HeaderText = "BookName_Price";
            this.BookName_Price.Name = "BookName_Price";
            this.BookName_Price.ReadOnly = true;
            // 
            // BtnDecrease
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5, 55, 5, 55);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BtnDecrease.DefaultCellStyle = dataGridViewCellStyle12;
            this.BtnDecrease.FillWeight = 20F;
            this.BtnDecrease.HeaderText = "BtnDecrease";
            this.BtnDecrease.Name = "BtnDecrease";
            this.BtnDecrease.ReadOnly = true;
            this.BtnDecrease.Text = "--";
            this.BtnDecrease.UseColumnTextForButtonValue = true;
            // 
            // BookQuantity
            // 
            this.BookQuantity.DataPropertyName = "BookQuantity";
            this.BookQuantity.FillWeight = 8F;
            this.BookQuantity.HeaderText = "BookQuantity";
            this.BookQuantity.Name = "BookQuantity";
            this.BookQuantity.ReadOnly = true;
            // 
            // BtnIncrease
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5, 55, 5, 55);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BtnIncrease.DefaultCellStyle = dataGridViewCellStyle13;
            this.BtnIncrease.FillWeight = 20F;
            this.BtnIncrease.HeaderText = "BtnIncrease";
            this.BtnIncrease.Name = "BtnIncrease";
            this.BtnIncrease.ReadOnly = true;
            this.BtnIncrease.Text = "+";
            this.BtnIncrease.UseColumnTextForButtonValue = true;
            // 
            // BtnRemove
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(30);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Red;
            this.BtnRemove.DefaultCellStyle = dataGridViewCellStyle14;
            this.BtnRemove.FillWeight = 50F;
            this.BtnRemove.HeaderText = "BtnRemove";
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.ReadOnly = true;
            this.BtnRemove.Text = "Hủy mua";
            this.BtnRemove.UseColumnTextForButtonValue = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(0, 583);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1028, 59);
            this.guna2Panel1.TabIndex = 3;
            // 
            // panelChoosePayment
            // 
            this.panelChoosePayment.Controls.Add(this.btnMoMo);
            this.panelChoosePayment.Controls.Add(this.btnDirectPayment);
            this.panelChoosePayment.Controls.Add(this.btnBank);
            this.panelChoosePayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChoosePayment.Location = new System.Drawing.Point(3, 783);
            this.panelChoosePayment.Name = "panelChoosePayment";
            this.panelChoosePayment.Size = new System.Drawing.Size(1105, 144);
            this.panelChoosePayment.TabIndex = 3;
            // 
            // btnMoMo
            // 
            this.btnMoMo.BorderColor = System.Drawing.Color.Red;
            this.btnMoMo.BorderRadius = 10;
            this.btnMoMo.BorderThickness = 1;
            this.btnMoMo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoMo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoMo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoMo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoMo.FillColor = System.Drawing.Color.Transparent;
            this.btnMoMo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoMo.ForeColor = System.Drawing.Color.Black;
            this.btnMoMo.Location = new System.Drawing.Point(875, 26);
            this.btnMoMo.Name = "btnMoMo";
            this.btnMoMo.Size = new System.Drawing.Size(180, 45);
            this.btnMoMo.TabIndex = 2;
            this.btnMoMo.Text = "Thanh toán MoMo";
            this.btnMoMo.Click += new System.EventHandler(this.btnMoMo_Click);
            // 
            // btnDirectPayment
            // 
            this.btnDirectPayment.BorderColor = System.Drawing.Color.Red;
            this.btnDirectPayment.BorderRadius = 10;
            this.btnDirectPayment.BorderThickness = 1;
            this.btnDirectPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDirectPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDirectPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDirectPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDirectPayment.FillColor = System.Drawing.Color.Transparent;
            this.btnDirectPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectPayment.ForeColor = System.Drawing.Color.Black;
            this.btnDirectPayment.Location = new System.Drawing.Point(637, 26);
            this.btnDirectPayment.Name = "btnDirectPayment";
            this.btnDirectPayment.Size = new System.Drawing.Size(223, 45);
            this.btnDirectPayment.TabIndex = 1;
            this.btnDirectPayment.Text = "Thanh toán khi nhận hàng";
            this.btnDirectPayment.Click += new System.EventHandler(this.btnDirectPayment_Click);
            // 
            // btnBank
            // 
            this.btnBank.BorderColor = System.Drawing.Color.Red;
            this.btnBank.BorderRadius = 10;
            this.btnBank.BorderThickness = 1;
            this.btnBank.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBank.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBank.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBank.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBank.FillColor = System.Drawing.Color.Transparent;
            this.btnBank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.ForeColor = System.Drawing.Color.Black;
            this.btnBank.Location = new System.Drawing.Point(389, 26);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(231, 45);
            this.btnBank.TabIndex = 0;
            this.btnBank.Text = "Thanh toán ngân hàng";
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // panelAddress
            // 
            this.panelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddress.Location = new System.Drawing.Point(30, 0);
            this.panelAddress.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(1051, 180);
            this.panelAddress.TabIndex = 0;
            // 
            // tableLayoutPanelCartFormMain
            // 
            this.tableLayoutPanelCartFormMain.AutoScroll = true;
            this.tableLayoutPanelCartFormMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelCartFormMain.ColumnCount = 1;
            this.tableLayoutPanelCartFormMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCartFormMain.Controls.Add(this.panelAddress, 0, 0);
            this.tableLayoutPanelCartFormMain.Controls.Add(this.panelChoosePayment, 0, 2);
            this.tableLayoutPanelCartFormMain.Controls.Add(this.panelShowProduct, 0, 1);
            this.tableLayoutPanelCartFormMain.Controls.Add(this.tableLayoutPanelPay, 0, 3);
            this.tableLayoutPanelCartFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCartFormMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCartFormMain.Name = "tableLayoutPanelCartFormMain";
            this.tableLayoutPanelCartFormMain.RowCount = 4;
            this.tableLayoutPanelCartFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelCartFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanelCartFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelCartFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelCartFormMain.Size = new System.Drawing.Size(1111, 785);
            this.tableLayoutPanelCartFormMain.TabIndex = 0;
            // 
            // CartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1111, 785);
            this.Controls.Add(this.tableLayoutPanelCartFormMain);
            this.MaximumSize = new System.Drawing.Size(1127, 824);
            this.MinimumSize = new System.Drawing.Size(1127, 824);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.tableLayoutPanelPay.ResumeLayout(false);
            this.flowLayoutPanelTotalPrice.ResumeLayout(false);
            this.flowLayoutPanelTotalPrice.PerformLayout();
            this.flowLayoutPanelPayButton.ResumeLayout(false);
            this.panelShowProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelChoosePayment.ResumeLayout(false);
            this.tableLayoutPanelCartFormMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTextPay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPayButton;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.Panel panelShowProduct;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName_Price;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDecrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn BtnIncrease;
        private System.Windows.Forms.DataGridViewButtonColumn BtnRemove;
        private System.Windows.Forms.Panel panelChoosePayment;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCartFormMain;
        private Guna.UI2.WinForms.Guna2Button btnMoMo;
        private Guna.UI2.WinForms.Guna2Button btnDirectPayment;
        private Guna.UI2.WinForms.Guna2Button btnBank;
    }
}