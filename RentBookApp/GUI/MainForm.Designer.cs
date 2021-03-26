
namespace RentBookApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.Label();
            this.tabManage = new System.Windows.Forms.TabControl();
            this.tabQuanLi = new System.Windows.Forms.TabPage();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRentDate = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lbnamxuatban = new System.Windows.Forms.Label();
            this.lbtacgia = new System.Windows.Forms.Label();
            this.lbloaisach = new System.Windows.Forms.Label();
            this.lbtensach = new System.Windows.Forms.Label();
            this.lbBookstatus = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblPublishingYear = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cusPhone = new System.Windows.Forms.TextBox();
            this.searchBook = new System.Windows.Forms.TextBox();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblfullNameH = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tabQuanLiSach = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.cbxBookType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPublishingYear = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabManage.SuspendLayout();
            this.tabQuanLi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tabLichSu.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.tabQuanLiSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân Viên:";
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Location = new System.Drawing.Point(847, 9);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(0, 13);
            this.lbStaff.TabIndex = 2;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.tabQuanLi);
            this.tabManage.Controls.Add(this.tabLichSu);
            this.tabManage.Controls.Add(this.tabQuanLiSach);
            this.tabManage.Location = new System.Drawing.Point(2, 39);
            this.tabManage.Name = "tabManage";
            this.tabManage.SelectedIndex = 0;
            this.tabManage.Size = new System.Drawing.Size(999, 572);
            this.tabManage.TabIndex = 3;
            // 
            // tabQuanLi
            // 
            this.tabQuanLi.Controls.Add(this.btnCreateOrder);
            this.tabQuanLi.Controls.Add(this.dpReturnDate);
            this.tabQuanLi.Controls.Add(this.label10);
            this.tabQuanLi.Controls.Add(this.label9);
            this.tabQuanLi.Controls.Add(this.txtRentDate);
            this.tabQuanLi.Controls.Add(this.lblIndex);
            this.tabQuanLi.Controls.Add(this.lbnamxuatban);
            this.tabQuanLi.Controls.Add(this.lbtacgia);
            this.tabQuanLi.Controls.Add(this.lbloaisach);
            this.tabQuanLi.Controls.Add(this.lbtensach);
            this.tabQuanLi.Controls.Add(this.lbBookstatus);
            this.tabQuanLi.Controls.Add(this.btnHuy);
            this.tabQuanLi.Controls.Add(this.btnRemove);
            this.tabQuanLi.Controls.Add(this.btnAdd);
            this.tabQuanLi.Controls.Add(this.dgvCart);
            this.tabQuanLi.Controls.Add(this.lblPublishingYear);
            this.tabQuanLi.Controls.Add(this.lblAuthor);
            this.tabQuanLi.Controls.Add(this.lblBookType);
            this.tabQuanLi.Controls.Add(this.lblFullName);
            this.tabQuanLi.Controls.Add(this.btnAddCustomer);
            this.tabQuanLi.Controls.Add(this.label12);
            this.tabQuanLi.Controls.Add(this.lblBookTitle);
            this.tabQuanLi.Controls.Add(this.label11);
            this.tabQuanLi.Controls.Add(this.cusPhone);
            this.tabQuanLi.Controls.Add(this.searchBook);
            this.tabQuanLi.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLi.Name = "tabQuanLi";
            this.tabQuanLi.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLi.Size = new System.Drawing.Size(991, 546);
            this.tabQuanLi.TabIndex = 0;
            this.tabQuanLi.Text = "Trang Chủ";
            this.tabQuanLi.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(855, 364);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOrder.TabIndex = 19;
            this.btnCreateOrder.Text = "Tạo order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // dpReturnDate
            // 
            this.dpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpReturnDate.Location = new System.Drawing.Point(700, 80);
            this.dpReturnDate.Name = "dpReturnDate";
            this.dpReturnDate.Size = new System.Drawing.Size(114, 20);
            this.dpReturnDate.TabIndex = 18;
            this.dpReturnDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ngày trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày thuê";
            // 
            // txtRentDate
            // 
            this.txtRentDate.Location = new System.Drawing.Point(700, 30);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.ReadOnly = true;
            this.txtRentDate.Size = new System.Drawing.Size(114, 20);
            this.txtRentDate.TabIndex = 16;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(814, 364);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(0, 13);
            this.lblIndex.TabIndex = 15;
            this.lblIndex.Visible = false;
            // 
            // lbnamxuatban
            // 
            this.lbnamxuatban.AutoSize = true;
            this.lbnamxuatban.Location = new System.Drawing.Point(153, 263);
            this.lbnamxuatban.Name = "lbnamxuatban";
            this.lbnamxuatban.Size = new System.Drawing.Size(0, 13);
            this.lbnamxuatban.TabIndex = 14;
            // 
            // lbtacgia
            // 
            this.lbtacgia.AutoSize = true;
            this.lbtacgia.Location = new System.Drawing.Point(153, 214);
            this.lbtacgia.Name = "lbtacgia";
            this.lbtacgia.Size = new System.Drawing.Size(0, 13);
            this.lbtacgia.TabIndex = 14;
            // 
            // lbloaisach
            // 
            this.lbloaisach.AutoSize = true;
            this.lbloaisach.Location = new System.Drawing.Point(153, 172);
            this.lbloaisach.Name = "lbloaisach";
            this.lbloaisach.Size = new System.Drawing.Size(0, 13);
            this.lbloaisach.TabIndex = 14;
            // 
            // lbtensach
            // 
            this.lbtensach.AutoSize = true;
            this.lbtensach.Location = new System.Drawing.Point(156, 128);
            this.lbtensach.Name = "lbtensach";
            this.lbtensach.Size = new System.Drawing.Size(0, 13);
            this.lbtensach.TabIndex = 14;
            // 
            // lbBookstatus
            // 
            this.lbBookstatus.AutoSize = true;
            this.lbBookstatus.Location = new System.Drawing.Point(384, 80);
            this.lbBookstatus.Name = "lbBookstatus";
            this.lbBookstatus.Size = new System.Drawing.Size(0, 13);
            this.lbBookstatus.TabIndex = 13;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(700, 414);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(700, 364);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(700, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(62, 320);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(584, 150);
            this.dgvCart.TabIndex = 10;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // lblPublishingYear
            // 
            this.lblPublishingYear.AutoSize = true;
            this.lblPublishingYear.Location = new System.Drawing.Point(59, 263);
            this.lblPublishingYear.Name = "lblPublishingYear";
            this.lblPublishingYear.Size = new System.Drawing.Size(76, 13);
            this.lblPublishingYear.TabIndex = 9;
            this.lblPublishingYear.Text = "Năm xuất bản:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(58, 214);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 13);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Tác giả:";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(59, 172);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(56, 13);
            this.lblBookType.TabIndex = 9;
            this.lblBookType.Text = "Loại sách:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Enabled = false;
            this.lblFullName.Location = new System.Drawing.Point(153, 49);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 13);
            this.lblFullName.TabIndex = 6;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(384, 22);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(139, 23);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Khách hàng mới";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "SDT Khách Hàng";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(58, 129);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(57, 13);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Tên Sách:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã Sách";
            // 
            // cusPhone
            // 
            this.cusPhone.Location = new System.Drawing.Point(156, 26);
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(206, 20);
            this.cusPhone.TabIndex = 0;
            this.cusPhone.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // searchBook
            // 
            this.searchBook.Location = new System.Drawing.Point(156, 77);
            this.searchBook.Name = "searchBook";
            this.searchBook.Size = new System.Drawing.Size(206, 20);
            this.searchBook.TabIndex = 0;
            this.searchBook.TextChanged += new System.EventHandler(this.searchBook_TextChanged);
            // 
            // tabLichSu
            // 
            this.tabLichSu.Controls.Add(this.panelDetail);
            this.tabLichSu.Controls.Add(this.dgvHistory);
            this.tabLichSu.Controls.Add(this.lblfullNameH);
            this.tabLichSu.Controls.Add(this.label16);
            this.tabLichSu.Controls.Add(this.txtPhone);
            this.tabLichSu.Location = new System.Drawing.Point(4, 22);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichSu.Size = new System.Drawing.Size(991, 546);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử";
            this.tabLichSu.UseVisualStyleBackColor = true;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.btnTraSach);
            this.panelDetail.Controls.Add(this.label17);
            this.panelDetail.Controls.Add(this.dgvDetail);
            this.panelDetail.Location = new System.Drawing.Point(198, 311);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(629, 206);
            this.panelDetail.TabIndex = 11;
            this.panelDetail.Visible = false;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(291, 174);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(75, 23);
            this.btnTraSach.TabIndex = 2;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Chi tiết";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Enabled = false;
            this.dgvDetail.Location = new System.Drawing.Point(3, 33);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(623, 121);
            this.dgvDetail.TabIndex = 0;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(100, 132);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(794, 163);
            this.dgvHistory.TabIndex = 10;
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellClick);
            // 
            // lblfullNameH
            // 
            this.lblfullNameH.AutoSize = true;
            this.lblfullNameH.Enabled = false;
            this.lblfullNameH.Location = new System.Drawing.Point(402, 86);
            this.lblfullNameH.Name = "lblfullNameH";
            this.lblfullNameH.Size = new System.Drawing.Size(0, 13);
            this.lblfullNameH.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(307, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "SDT Khách Hàng";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(405, 63);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 20);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // tabQuanLiSach
            // 
            this.tabQuanLiSach.Controls.Add(this.dgvBooks);
            this.tabQuanLiSach.Controls.Add(this.txtSearch);
            this.tabQuanLiSach.Controls.Add(this.label14);
            this.tabQuanLiSach.Controls.Add(this.btnRemoveBook);
            this.tabQuanLiSach.Controls.Add(this.btnUpdateBook);
            this.tabQuanLiSach.Controls.Add(this.btnHuy1);
            this.tabQuanLiSach.Controls.Add(this.btnSave);
            this.tabQuanLiSach.Controls.Add(this.btnCreateBook);
            this.tabQuanLiSach.Controls.Add(this.cbxBookType);
            this.tabQuanLiSach.Controls.Add(this.txtPrice);
            this.tabQuanLiSach.Controls.Add(this.txtQuantity);
            this.tabQuanLiSach.Controls.Add(this.txtPublishingYear);
            this.tabQuanLiSach.Controls.Add(this.txtAuthor);
            this.tabQuanLiSach.Controls.Add(this.txtBookID);
            this.tabQuanLiSach.Controls.Add(this.txtBookTitle);
            this.tabQuanLiSach.Controls.Add(this.label8);
            this.tabQuanLiSach.Controls.Add(this.label7);
            this.tabQuanLiSach.Controls.Add(this.label6);
            this.tabQuanLiSach.Controls.Add(this.label5);
            this.tabQuanLiSach.Controls.Add(this.label13);
            this.tabQuanLiSach.Controls.Add(this.label4);
            this.tabQuanLiSach.Controls.Add(this.label3);
            this.tabQuanLiSach.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLiSach.Name = "tabQuanLiSach";
            this.tabQuanLiSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLiSach.Size = new System.Drawing.Size(991, 546);
            this.tabQuanLiSach.TabIndex = 2;
            this.tabQuanLiSach.Text = "Quản lý sách";
            this.tabQuanLiSach.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(35, 340);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(847, 150);
            this.dgvBooks.TabIndex = 22;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 516);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(232, 20);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tìm kiếm";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(664, 144);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBook.TabIndex = 18;
            this.btnRemoveBook.Text = "Xóa";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(664, 88);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBook.TabIndex = 18;
            this.btnUpdateBook.Text = "Sửa";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnHuy1
            // 
            this.btnHuy1.Enabled = false;
            this.btnHuy1.Location = new System.Drawing.Point(807, 88);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(75, 23);
            this.btnHuy1.TabIndex = 17;
            this.btnHuy1.Text = "Hủy";
            this.btnHuy1.UseVisualStyleBackColor = true;
            this.btnHuy1.Click += new System.EventHandler(this.btnHuy1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(807, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(664, 33);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBook.TabIndex = 16;
            this.btnCreateBook.Text = "Thêm";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // cbxBookType
            // 
            this.cbxBookType.FormattingEnabled = true;
            this.cbxBookType.Location = new System.Drawing.Point(192, 146);
            this.cbxBookType.Name = "cbxBookType";
            this.cbxBookType.Size = new System.Drawing.Size(232, 21);
            this.cbxBookType.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(192, 262);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(192, 223);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(232, 20);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtPublishingYear
            // 
            this.txtPublishingYear.Location = new System.Drawing.Point(192, 184);
            this.txtPublishingYear.Name = "txtPublishingYear";
            this.txtPublishingYear.Size = new System.Drawing.Size(232, 20);
            this.txtPublishingYear.TabIndex = 12;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(192, 108);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(232, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(192, 33);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(232, 20);
            this.txtBookID.TabIndex = 14;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(192, 69);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(232, 20);
            this.txtBookTitle.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nắm Xuất Bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại sách";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Mã Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thư viện liên khương";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.error.ContainerControl = this;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(926, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 608);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabManage);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabManage.ResumeLayout(false);
            this.tabQuanLi.ResumeLayout(false);
            this.tabQuanLi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.tabLichSu.ResumeLayout(false);
            this.tabLichSu.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.tabQuanLiSach.ResumeLayout(false);
            this.tabQuanLiSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.TabControl tabManage;
        private System.Windows.Forms.TabPage tabQuanLi;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.TabPage tabQuanLiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchBook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cusPhone;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblPublishingYear;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lbBookstatus;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label lbnamxuatban;
        private System.Windows.Forms.Label lbtacgia;
        private System.Windows.Forms.Label lbloaisach;
        private System.Windows.Forms.Label lbtensach;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.ComboBox cbxBookType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPublishingYear;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRentDate;
        private System.Windows.Forms.DateTimePicker dpReturnDate;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblfullNameH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnTraSach;
    }
}