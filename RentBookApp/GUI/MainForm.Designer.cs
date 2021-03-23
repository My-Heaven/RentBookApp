
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.Label();
            this.tabManage = new System.Windows.Forms.TabControl();
            this.tabQuanLi = new System.Windows.Forms.TabPage();
            this.lbBookstatus = new System.Windows.Forms.Label();
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
            this.tabQuanLiSach = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCreateBook = new System.Windows.Forms.TabPage();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.cbxBookType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPublishingYear = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabManage.SuspendLayout();
            this.tabQuanLi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tabQuanLiSach.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCreateBook.SuspendLayout();
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
            this.tabQuanLi.Controls.Add(this.lbBookstatus);
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
            // lbBookstatus
            // 
            this.lbBookstatus.AutoSize = true;
            this.lbBookstatus.Location = new System.Drawing.Point(384, 80);
            this.lbBookstatus.Name = "lbBookstatus";
            this.lbBookstatus.Size = new System.Drawing.Size(0, 13);
            this.lbBookstatus.TabIndex = 13;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(700, 364);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(700, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(62, 320);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(584, 150);
            this.dgvCart.TabIndex = 10;
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
            this.tabLichSu.Location = new System.Drawing.Point(4, 22);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichSu.Size = new System.Drawing.Size(991, 546);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử";
            this.tabLichSu.UseVisualStyleBackColor = true;
            // 
            // tabQuanLiSach
            // 
            this.tabQuanLiSach.Controls.Add(this.tabControl1);
            this.tabQuanLiSach.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLiSach.Name = "tabQuanLiSach";
            this.tabQuanLiSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLiSach.Size = new System.Drawing.Size(991, 546);
            this.tabQuanLiSach.TabIndex = 2;
            this.tabQuanLiSach.Text = "Quan Li Sach";
            this.tabQuanLiSach.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name Of Store";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCreateBook);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 543);
            this.tabControl1.TabIndex = 1;
            // 
            // tpCreateBook
            // 
            this.tpCreateBook.Controls.Add(this.btnCreateBook);
            this.tpCreateBook.Controls.Add(this.cbxBookType);
            this.tpCreateBook.Controls.Add(this.txtPrice);
            this.tpCreateBook.Controls.Add(this.txtQuantity);
            this.tpCreateBook.Controls.Add(this.txtPublishingYear);
            this.tpCreateBook.Controls.Add(this.txtAuthor);
            this.tpCreateBook.Controls.Add(this.txtBookTitle);
            this.tpCreateBook.Controls.Add(this.label8);
            this.tpCreateBook.Controls.Add(this.label7);
            this.tpCreateBook.Controls.Add(this.label6);
            this.tpCreateBook.Controls.Add(this.label5);
            this.tpCreateBook.Controls.Add(this.label4);
            this.tpCreateBook.Controls.Add(this.label3);
            this.tpCreateBook.Location = new System.Drawing.Point(4, 22);
            this.tpCreateBook.Name = "tpCreateBook";
            this.tpCreateBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateBook.Size = new System.Drawing.Size(980, 517);
            this.tpCreateBook.TabIndex = 0;
            this.tpCreateBook.Text = "Thêm Sách";
            this.tpCreateBook.UseVisualStyleBackColor = true;
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(449, 387);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBook.TabIndex = 3;
            this.btnCreateBook.Text = "Create";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            // 
            // cbxBookType
            // 
            this.cbxBookType.FormattingEnabled = true;
            this.cbxBookType.Location = new System.Drawing.Point(399, 192);
            this.cbxBookType.Name = "cbxBookType";
            this.cbxBookType.Size = new System.Drawing.Size(232, 21);
            this.cbxBookType.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(399, 308);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(399, 269);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(232, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtPublishingYear
            // 
            this.txtPublishingYear.Location = new System.Drawing.Point(399, 230);
            this.txtPublishingYear.Name = "txtPublishingYear";
            this.txtPublishingYear.Size = new System.Drawing.Size(232, 20);
            this.txtPublishingYear.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(399, 154);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(232, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(399, 115);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(232, 20);
            this.txtBookTitle.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nắm Xuất Bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Sách";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabManage);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabManage.ResumeLayout(false);
            this.tabQuanLi.ResumeLayout(false);
            this.tabQuanLi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.tabQuanLiSach.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpCreateBook.ResumeLayout(false);
            this.tpCreateBook.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCreateBook;
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}