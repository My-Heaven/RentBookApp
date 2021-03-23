
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
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.tabQuanLiSach = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabManage.SuspendLayout();
            this.tabQuanLi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tabQuanLiSach.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tabQuanLi.Controls.Add(this.textBox9);
            this.tabQuanLi.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLi.Name = "tabQuanLi";
            this.tabQuanLi.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLi.Size = new System.Drawing.Size(991, 546);
            this.tabQuanLi.TabIndex = 0;
            this.tabQuanLi.Text = "Trang Chủ";
            this.tabQuanLi.UseVisualStyleBackColor = true;
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
            this.lblFullName.Location = new System.Drawing.Point(127, 55);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(38, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "status:";
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
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(156, 77);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(206, 20);
            this.textBox9.TabIndex = 0;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabManage.ResumeLayout(false);
            this.tabQuanLi.ResumeLayout(false);
            this.tabQuanLi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.tabQuanLiSach.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox9;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}