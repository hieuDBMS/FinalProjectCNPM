namespace FahasaApp
{
    partial class DetailProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailProduct));
            this.tableLayoutPanelMain_All = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDetailBook = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelBookImage = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxBookImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelBookTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuyNow = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCart = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelBookInformation = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBookPublisher = new System.Windows.Forms.Label();
            this.labelBookPublication = new System.Windows.Forms.Label();
            this.labelBookCategory = new System.Windows.Forms.Label();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanelAuthor = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.labelBookCover = new System.Windows.Forms.Label();
            this.tableLayoutPanelCommentOfUser = new System.Windows.Forms.TableLayoutPanel();
            this.labelUserComment = new System.Windows.Forms.Label();
            this.flowLayoutPanelChooseStar = new System.Windows.Forms.FlowLayoutPanel();
            this.labelChooseStar = new System.Windows.Forms.Label();
            this.comboBoxChooseStar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtUserComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAccess = new Guna.UI2.WinForms.Guna2Button();
            this.panelAllUserComment = new System.Windows.Forms.Panel();
            this.labelNoUserComment = new System.Windows.Forms.Label();
            this.dataGridViewAllUserComment = new System.Windows.Forms.DataGridView();
            this.UserIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Star = new System.Windows.Forms.DataGridViewImageColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList100 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanelMain_All.SuspendLayout();
            this.tableLayoutPanelDetailBook.SuspendLayout();
            this.flowLayoutPanelBookImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImage)).BeginInit();
            this.flowLayoutPanelBookTitle.SuspendLayout();
            this.flowLayoutPanelButton.SuspendLayout();
            this.flowLayoutPanelBookInformation.SuspendLayout();
            this.flowLayoutPanelAuthor.SuspendLayout();
            this.tableLayoutPanelCommentOfUser.SuspendLayout();
            this.flowLayoutPanelChooseStar.SuspendLayout();
            this.panelAllUserComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUserComment)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain_All
            // 
            this.tableLayoutPanelMain_All.AutoScroll = true;
            this.tableLayoutPanelMain_All.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain_All.ColumnCount = 1;
            this.tableLayoutPanelMain_All.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain_All.Controls.Add(this.tableLayoutPanelDetailBook, 0, 0);
            this.tableLayoutPanelMain_All.Controls.Add(this.tableLayoutPanelCommentOfUser, 0, 1);
            this.tableLayoutPanelMain_All.Controls.Add(this.panelAllUserComment, 0, 2);
            this.tableLayoutPanelMain_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain_All.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain_All.Name = "tableLayoutPanelMain_All";
            this.tableLayoutPanelMain_All.RowCount = 3;
            this.tableLayoutPanelMain_All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanelMain_All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelMain_All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanelMain_All.Size = new System.Drawing.Size(1111, 785);
            this.tableLayoutPanelMain_All.TabIndex = 0;
            // 
            // tableLayoutPanelDetailBook
            // 
            this.tableLayoutPanelDetailBook.ColumnCount = 3;
            this.tableLayoutPanelDetailBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDetailBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDetailBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDetailBook.Controls.Add(this.flowLayoutPanelBookImage, 0, 1);
            this.tableLayoutPanelDetailBook.Controls.Add(this.flowLayoutPanelBookTitle, 0, 0);
            this.tableLayoutPanelDetailBook.Controls.Add(this.flowLayoutPanelButton, 1, 2);
            this.tableLayoutPanelDetailBook.Controls.Add(this.flowLayoutPanelBookInformation, 1, 1);
            this.tableLayoutPanelDetailBook.Controls.Add(this.flowLayoutPanelAuthor, 2, 1);
            this.tableLayoutPanelDetailBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDetailBook.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDetailBook.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDetailBook.Name = "tableLayoutPanelDetailBook";
            this.tableLayoutPanelDetailBook.RowCount = 3;
            this.tableLayoutPanelDetailBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDetailBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelDetailBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelDetailBook.Size = new System.Drawing.Size(1111, 500);
            this.tableLayoutPanelDetailBook.TabIndex = 2;
            // 
            // flowLayoutPanelBookImage
            // 
            this.flowLayoutPanelBookImage.Controls.Add(this.pictureBoxBookImage);
            this.flowLayoutPanelBookImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBookImage.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanelBookImage.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBookImage.Name = "flowLayoutPanelBookImage";
            this.tableLayoutPanelDetailBook.SetRowSpan(this.flowLayoutPanelBookImage, 2);
            this.flowLayoutPanelBookImage.Size = new System.Drawing.Size(222, 400);
            this.flowLayoutPanelBookImage.TabIndex = 18;
            // 
            // pictureBoxBookImage
            // 
            this.pictureBoxBookImage.Location = new System.Drawing.Point(20, 0);
            this.pictureBoxBookImage.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pictureBoxBookImage.MaximumSize = new System.Drawing.Size(190, 340);
            this.pictureBoxBookImage.MinimumSize = new System.Drawing.Size(190, 340);
            this.pictureBoxBookImage.Name = "pictureBoxBookImage";
            this.pictureBoxBookImage.Size = new System.Drawing.Size(190, 340);
            this.pictureBoxBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBookImage.TabIndex = 15;
            this.pictureBoxBookImage.TabStop = false;
            // 
            // flowLayoutPanelBookTitle
            // 
            this.tableLayoutPanelDetailBook.SetColumnSpan(this.flowLayoutPanelBookTitle, 3);
            this.flowLayoutPanelBookTitle.Controls.Add(this.labelBookTitle);
            this.flowLayoutPanelBookTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBookTitle.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBookTitle.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBookTitle.Name = "flowLayoutPanelBookTitle";
            this.flowLayoutPanelBookTitle.Size = new System.Drawing.Size(1111, 100);
            this.flowLayoutPanelBookTitle.TabIndex = 19;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookTitle.Location = new System.Drawing.Point(15, 5);
            this.labelBookTitle.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(292, 37);
            this.labelBookTitle.TabIndex = 19;
            this.labelBookTitle.Text = "Doraemon Tập 39";
            // 
            // flowLayoutPanelButton
            // 
            this.flowLayoutPanelButton.Controls.Add(this.btnBuyNow);
            this.flowLayoutPanelButton.Controls.Add(this.btnAddCart);
            this.flowLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButton.Location = new System.Drawing.Point(222, 425);
            this.flowLayoutPanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelButton.Name = "flowLayoutPanelButton";
            this.flowLayoutPanelButton.Size = new System.Drawing.Size(555, 75);
            this.flowLayoutPanelButton.TabIndex = 20;
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnBuyNow.BorderRadius = 10;
            this.btnBuyNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuyNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuyNow.FillColor = System.Drawing.Color.Red;
            this.btnBuyNow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyNow.ForeColor = System.Drawing.Color.White;
            this.btnBuyNow.Location = new System.Drawing.Point(50, 0);
            this.btnBuyNow.Margin = new System.Windows.Forms.Padding(50, 0, 100, 0);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(140, 45);
            this.btnBuyNow.TabIndex = 4;
            this.btnBuyNow.Text = "Mua Ngay";
            // 
            // btnAddCart
            // 
            this.btnAddCart.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnAddCart.BorderRadius = 10;
            this.btnAddCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCart.FillColor = System.Drawing.Color.Red;
            this.btnAddCart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.Color.White;
            this.btnAddCart.Location = new System.Drawing.Point(330, 0);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(140, 45);
            this.btnAddCart.TabIndex = 5;
            this.btnAddCart.Text = "Thêm Vào Giỏ";
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // flowLayoutPanelBookInformation
            // 
            this.flowLayoutPanelBookInformation.Controls.Add(this.labelBookPublisher);
            this.flowLayoutPanelBookInformation.Controls.Add(this.labelBookPublication);
            this.flowLayoutPanelBookInformation.Controls.Add(this.labelBookCategory);
            this.flowLayoutPanelBookInformation.Controls.Add(this.labelBookPrice);
            this.flowLayoutPanelBookInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBookInformation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBookInformation.Location = new System.Drawing.Point(222, 100);
            this.flowLayoutPanelBookInformation.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBookInformation.Name = "flowLayoutPanelBookInformation";
            this.flowLayoutPanelBookInformation.Size = new System.Drawing.Size(555, 325);
            this.flowLayoutPanelBookInformation.TabIndex = 21;
            // 
            // labelBookPublisher
            // 
            this.labelBookPublisher.AutoSize = true;
            this.labelBookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookPublisher.Location = new System.Drawing.Point(50, 20);
            this.labelBookPublisher.Margin = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.labelBookPublisher.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelBookPublisher.Name = "labelBookPublisher";
            this.labelBookPublisher.Size = new System.Drawing.Size(250, 25);
            this.labelBookPublisher.TabIndex = 16;
            this.labelBookPublisher.Text = "Nhà Xuất Bản: Kim Đồng";
            // 
            // labelBookPublication
            // 
            this.labelBookPublication.AutoSize = true;
            this.labelBookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookPublication.Location = new System.Drawing.Point(50, 85);
            this.labelBookPublication.Margin = new System.Windows.Forms.Padding(50, 40, 0, 0);
            this.labelBookPublication.Name = "labelBookPublication";
            this.labelBookPublication.Size = new System.Drawing.Size(205, 25);
            this.labelBookPublication.TabIndex = 17;
            this.labelBookPublication.Text = "Năm xuất bản: 1993";
            // 
            // labelBookCategory
            // 
            this.labelBookCategory.AutoSize = true;
            this.labelBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookCategory.Location = new System.Drawing.Point(50, 150);
            this.labelBookCategory.Margin = new System.Windows.Forms.Padding(50, 40, 0, 0);
            this.labelBookCategory.Name = "labelBookCategory";
            this.labelBookCategory.Size = new System.Drawing.Size(207, 25);
            this.labelBookCategory.TabIndex = 19;
            this.labelBookCategory.Text = "Thể loại :  Thiếu nhii";
            // 
            // labelBookPrice
            // 
            this.labelBookPrice.AutoSize = true;
            this.labelBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookPrice.ForeColor = System.Drawing.Color.Red;
            this.labelBookPrice.Location = new System.Drawing.Point(50, 215);
            this.labelBookPrice.Margin = new System.Windows.Forms.Padding(50, 40, 0, 0);
            this.labelBookPrice.Name = "labelBookPrice";
            this.labelBookPrice.Size = new System.Drawing.Size(147, 46);
            this.labelBookPrice.TabIndex = 18;
            this.labelBookPrice.Text = "45.000";
            // 
            // flowLayoutPanelAuthor
            // 
            this.flowLayoutPanelAuthor.Controls.Add(this.labelBookAuthor);
            this.flowLayoutPanelAuthor.Controls.Add(this.labelBookCover);
            this.flowLayoutPanelAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAuthor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAuthor.Location = new System.Drawing.Point(777, 100);
            this.flowLayoutPanelAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelAuthor.Name = "flowLayoutPanelAuthor";
            this.tableLayoutPanelDetailBook.SetRowSpan(this.flowLayoutPanelAuthor, 2);
            this.flowLayoutPanelAuthor.Size = new System.Drawing.Size(334, 400);
            this.flowLayoutPanelAuthor.TabIndex = 22;
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.AutoSize = true;
            this.labelBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookAuthor.Location = new System.Drawing.Point(0, 20);
            this.labelBookAuthor.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Size = new System.Drawing.Size(167, 25);
            this.labelBookAuthor.TabIndex = 21;
            this.labelBookAuthor.Text = "Tác giả: Fukuda";
            // 
            // labelBookCover
            // 
            this.labelBookCover.AutoSize = true;
            this.labelBookCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookCover.Location = new System.Drawing.Point(0, 85);
            this.labelBookCover.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.labelBookCover.Name = "labelBookCover";
            this.labelBookCover.Size = new System.Drawing.Size(181, 25);
            this.labelBookCover.TabIndex = 22;
            this.labelBookCover.Text = "BookCover: Cứng";
            // 
            // tableLayoutPanelCommentOfUser
            // 
            this.tableLayoutPanelCommentOfUser.ColumnCount = 2;
            this.tableLayoutPanelCommentOfUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelCommentOfUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelCommentOfUser.Controls.Add(this.labelUserComment, 0, 0);
            this.tableLayoutPanelCommentOfUser.Controls.Add(this.flowLayoutPanelChooseStar, 0, 1);
            this.tableLayoutPanelCommentOfUser.Controls.Add(this.txtUserComment, 1, 1);
            this.tableLayoutPanelCommentOfUser.Controls.Add(this.btnAccess, 1, 2);
            this.tableLayoutPanelCommentOfUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCommentOfUser.Location = new System.Drawing.Point(0, 500);
            this.tableLayoutPanelCommentOfUser.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCommentOfUser.Name = "tableLayoutPanelCommentOfUser";
            this.tableLayoutPanelCommentOfUser.RowCount = 3;
            this.tableLayoutPanelCommentOfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCommentOfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelCommentOfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelCommentOfUser.Size = new System.Drawing.Size(1111, 400);
            this.tableLayoutPanelCommentOfUser.TabIndex = 3;
            // 
            // labelUserComment
            // 
            this.labelUserComment.BackColor = System.Drawing.Color.Red;
            this.labelUserComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanelCommentOfUser.SetColumnSpan(this.labelUserComment, 2);
            this.labelUserComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserComment.ForeColor = System.Drawing.Color.White;
            this.labelUserComment.Location = new System.Drawing.Point(20, 30);
            this.labelUserComment.Margin = new System.Windows.Forms.Padding(20, 30, 0, 0);
            this.labelUserComment.Name = "labelUserComment";
            this.labelUserComment.Size = new System.Drawing.Size(450, 40);
            this.labelUserComment.TabIndex = 7;
            this.labelUserComment.Text = "Đánh giá, nhận xét từ khách hàng";
            this.labelUserComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelChooseStar
            // 
            this.flowLayoutPanelChooseStar.Controls.Add(this.labelChooseStar);
            this.flowLayoutPanelChooseStar.Controls.Add(this.comboBoxChooseStar);
            this.flowLayoutPanelChooseStar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelChooseStar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChooseStar.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanelChooseStar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelChooseStar.Name = "flowLayoutPanelChooseStar";
            this.flowLayoutPanelChooseStar.Size = new System.Drawing.Size(444, 260);
            this.flowLayoutPanelChooseStar.TabIndex = 8;
            // 
            // labelChooseStar
            // 
            this.labelChooseStar.AutoSize = true;
            this.labelChooseStar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChooseStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseStar.Location = new System.Drawing.Point(100, 50);
            this.labelChooseStar.Margin = new System.Windows.Forms.Padding(100, 50, 0, 0);
            this.labelChooseStar.Name = "labelChooseStar";
            this.labelChooseStar.Size = new System.Drawing.Size(216, 25);
            this.labelChooseStar.TabIndex = 0;
            this.labelChooseStar.Text = "Chất lượng sản phẩm";
            // 
            // comboBoxChooseStar
            // 
            this.comboBoxChooseStar.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxChooseStar.BorderRadius = 10;
            this.comboBoxChooseStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseStar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxChooseStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseStar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxChooseStar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxChooseStar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxChooseStar.ItemHeight = 30;
            this.comboBoxChooseStar.Items.AddRange(new object[] {
            "1 sao",
            "2 sao",
            "3 sao",
            "4 sao",
            "5 sao",
            ""});
            this.comboBoxChooseStar.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxChooseStar.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseStar.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.comboBoxChooseStar.Location = new System.Drawing.Point(140, 85);
            this.comboBoxChooseStar.Margin = new System.Windows.Forms.Padding(140, 10, 0, 0);
            this.comboBoxChooseStar.Name = "comboBoxChooseStar";
            this.comboBoxChooseStar.Size = new System.Drawing.Size(120, 36);
            this.comboBoxChooseStar.TabIndex = 2;
            this.comboBoxChooseStar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserComment
            // 
            this.txtUserComment.BorderColor = System.Drawing.Color.Silver;
            this.txtUserComment.BorderRadius = 10;
            this.txtUserComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserComment.DefaultText = "";
            this.txtUserComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUserComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserComment.ForeColor = System.Drawing.Color.Black;
            this.txtUserComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserComment.Location = new System.Drawing.Point(474, 130);
            this.txtUserComment.Margin = new System.Windows.Forms.Padding(30, 50, 0, 0);
            this.txtUserComment.MaximumSize = new System.Drawing.Size(620, 180);
            this.txtUserComment.MinimumSize = new System.Drawing.Size(620, 180);
            this.txtUserComment.Multiline = true;
            this.txtUserComment.Name = "txtUserComment";
            this.txtUserComment.PasswordChar = '\0';
            this.txtUserComment.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserComment.PlaceholderText = "Nội dung nhận xét...";
            this.txtUserComment.SelectedText = "";
            this.txtUserComment.Size = new System.Drawing.Size(620, 180);
            this.txtUserComment.TabIndex = 9;
            // 
            // btnAccess
            // 
            this.btnAccess.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnAccess.BorderRadius = 10;
            this.btnAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccess.FillColor = System.Drawing.Color.Red;
            this.btnAccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccess.ForeColor = System.Drawing.Color.White;
            this.btnAccess.Location = new System.Drawing.Point(954, 340);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(510, 0, 0, 0);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(140, 40);
            this.btnAccess.TabIndex = 10;
            this.btnAccess.Text = "Đánh giá";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // panelAllUserComment
            // 
            this.panelAllUserComment.Controls.Add(this.labelNoUserComment);
            this.panelAllUserComment.Controls.Add(this.dataGridViewAllUserComment);
            this.panelAllUserComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllUserComment.Location = new System.Drawing.Point(0, 900);
            this.panelAllUserComment.Margin = new System.Windows.Forms.Padding(0);
            this.panelAllUserComment.Name = "panelAllUserComment";
            this.panelAllUserComment.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.panelAllUserComment.Size = new System.Drawing.Size(1111, 500);
            this.panelAllUserComment.TabIndex = 4;
            // 
            // labelNoUserComment
            // 
            this.labelNoUserComment.AutoSize = true;
            this.labelNoUserComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoUserComment.Location = new System.Drawing.Point(100, 20);
            this.labelNoUserComment.Name = "labelNoUserComment";
            this.labelNoUserComment.Size = new System.Drawing.Size(292, 25);
            this.labelNoUserComment.TabIndex = 8;
            this.labelNoUserComment.Text = "Hiện không có bình luận nào.";
            this.labelNoUserComment.Visible = false;
            // 
            // dataGridViewAllUserComment
            // 
            this.dataGridViewAllUserComment.AllowUserToAddRows = false;
            this.dataGridViewAllUserComment.AllowUserToDeleteRows = false;
            this.dataGridViewAllUserComment.AllowUserToResizeColumns = false;
            this.dataGridViewAllUserComment.AllowUserToResizeRows = false;
            this.dataGridViewAllUserComment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllUserComment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllUserComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAllUserComment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAllUserComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUserComment.ColumnHeadersVisible = false;
            this.dataGridViewAllUserComment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIcon,
            this.UserName,
            this.Star,
            this.Comment});
            this.dataGridViewAllUserComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllUserComment.GridColor = System.Drawing.Color.LightSalmon;
            this.dataGridViewAllUserComment.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewAllUserComment.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.dataGridViewAllUserComment.MultiSelect = false;
            this.dataGridViewAllUserComment.Name = "dataGridViewAllUserComment";
            this.dataGridViewAllUserComment.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllUserComment.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllUserComment.RowHeadersVisible = false;
            this.dataGridViewAllUserComment.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewAllUserComment.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAllUserComment.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewAllUserComment.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAllUserComment.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllUserComment.RowTemplate.Height = 150;
            this.dataGridViewAllUserComment.RowTemplate.ReadOnly = true;
            this.dataGridViewAllUserComment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAllUserComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAllUserComment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllUserComment.Size = new System.Drawing.Size(1071, 480);
            this.dataGridViewAllUserComment.TabIndex = 7;
            this.dataGridViewAllUserComment.VirtualMode = true;
            this.dataGridViewAllUserComment.SelectionChanged += new System.EventHandler(this.dataGridViewAllUserComment_SelectionChanged);
            // 
            // UserIcon
            // 
            this.UserIcon.FillWeight = 10F;
            this.UserIcon.HeaderText = "UserIcon";
            this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
            this.UserIcon.MinimumWidth = 25;
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.ReadOnly = true;
            this.UserIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "username";
            this.UserName.FillWeight = 15F;
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 25;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Star
            // 
            this.Star.DataPropertyName = "StarImage";
            this.Star.FillWeight = 15F;
            this.Star.HeaderText = "Star";
            this.Star.MinimumWidth = 25;
            this.Star.Name = "Star";
            this.Star.ReadOnly = true;
            this.Star.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.FillWeight = 150F;
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 500;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // imageList100
            // 
            this.imageList100.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList100.ImageStream")));
            this.imageList100.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList100.Images.SetKeyName(0, "one_star.png");
            this.imageList100.Images.SetKeyName(1, "two_star.png");
            this.imageList100.Images.SetKeyName(2, "three_star.png");
            this.imageList100.Images.SetKeyName(3, "four_strar.png");
            this.imageList100.Images.SetKeyName(4, "five_star.png");
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 15F;
            this.dataGridViewImageColumn1.HeaderText = "UserIcon";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 78;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 20F;
            this.dataGridViewImageColumn2.HeaderText = "Star";
            this.dataGridViewImageColumn2.Image = global::FahasaApp.Properties.Resources.one_star;
            this.dataGridViewImageColumn2.MinimumWidth = 15;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 106;
            // 
            // DetailProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1111, 785);
            this.Controls.Add(this.tableLayoutPanelMain_All);
            this.MaximumSize = new System.Drawing.Size(1127, 824);
            this.MinimumSize = new System.Drawing.Size(1127, 824);
            this.Name = "DetailProduct";
            this.Text = "DetailProduct";
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            this.tableLayoutPanelMain_All.ResumeLayout(false);
            this.tableLayoutPanelDetailBook.ResumeLayout(false);
            this.flowLayoutPanelBookImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImage)).EndInit();
            this.flowLayoutPanelBookTitle.ResumeLayout(false);
            this.flowLayoutPanelBookTitle.PerformLayout();
            this.flowLayoutPanelButton.ResumeLayout(false);
            this.flowLayoutPanelBookInformation.ResumeLayout(false);
            this.flowLayoutPanelBookInformation.PerformLayout();
            this.flowLayoutPanelAuthor.ResumeLayout(false);
            this.flowLayoutPanelAuthor.PerformLayout();
            this.tableLayoutPanelCommentOfUser.ResumeLayout(false);
            this.flowLayoutPanelChooseStar.ResumeLayout(false);
            this.flowLayoutPanelChooseStar.PerformLayout();
            this.panelAllUserComment.ResumeLayout(false);
            this.panelAllUserComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUserComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain_All;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetailBook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBookImage;
        private System.Windows.Forms.PictureBox pictureBoxBookImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBookTitle;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButton;
        private Guna.UI2.WinForms.Guna2Button btnBuyNow;
        private Guna.UI2.WinForms.Guna2Button btnAddCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBookInformation;
        private System.Windows.Forms.Label labelBookPublisher;
        private System.Windows.Forms.Label labelBookPublication;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAuthor;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.Label labelBookCover;
        private System.Windows.Forms.Label labelBookCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCommentOfUser;
        private System.Windows.Forms.Label labelUserComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChooseStar;
        private System.Windows.Forms.Label labelChooseStar;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxChooseStar;
        private Guna.UI2.WinForms.Guna2TextBox txtUserComment;
        private Guna.UI2.WinForms.Guna2Button btnAccess;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ImageList imageList100;
        private System.Windows.Forms.Panel panelAllUserComment;
        private System.Windows.Forms.DataGridView dataGridViewAllUserComment;
        private System.Windows.Forms.DataGridViewImageColumn UserIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewImageColumn Star;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Label labelNoUserComment;
    }
}