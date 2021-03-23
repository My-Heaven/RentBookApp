
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.tabQuanLiSach = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pnThemSach = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tabManage.SuspendLayout();
            this.tabQuanLi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabQuanLiSach.SuspendLayout();
            this.pnThemSach.SuspendLayout();
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
            this.tabQuanLi.Controls.Add(this.lblFullName);
            this.tabQuanLi.Controls.Add(this.button2);
            this.tabQuanLi.Controls.Add(this.btnRemove);
            this.tabQuanLi.Controls.Add(this.btnAdd);
            this.tabQuanLi.Controls.Add(this.dataGridView1);
            this.tabQuanLi.Controls.Add(this.label12);
            this.tabQuanLi.Controls.Add(this.label13);
            this.tabQuanLi.Controls.Add(this.label11);
            this.tabQuanLi.Controls.Add(this.textBox10);
            this.tabQuanLi.Controls.Add(this.txtBookTitle);
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
            this.btnRemove.Location = new System.Drawing.Point(676, 429);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(676, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Khách Hàng";
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
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(127, 27);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(206, 20);
            this.textBox10.TabIndex = 0;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(127, 74);
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
            this.tabQuanLiSach.Controls.Add(this.button1);
            this.tabQuanLiSach.Controls.Add(this.pnThemSach);
            this.tabQuanLiSach.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLiSach.Name = "tabQuanLiSach";
            this.tabQuanLiSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLiSach.Size = new System.Drawing.Size(991, 546);
            this.tabQuanLiSach.TabIndex = 2;
            this.tabQuanLiSach.Text = "Quan Li Sach";
            this.tabQuanLiSach.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Them Sach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnThemSach
            // 
            this.pnThemSach.Controls.Add(this.textBox6);
            this.pnThemSach.Controls.Add(this.label10);
            this.pnThemSach.Controls.Add(this.textBox1);
            this.pnThemSach.Controls.Add(this.label9);
            this.pnThemSach.Controls.Add(this.textBox2);
            this.pnThemSach.Controls.Add(this.label6);
            this.pnThemSach.Controls.Add(this.textBox5);
            this.pnThemSach.Controls.Add(this.label8);
            this.pnThemSach.Controls.Add(this.textBox3);
            this.pnThemSach.Controls.Add(this.label5);
            this.pnThemSach.Controls.Add(this.textBox4);
            this.pnThemSach.Controls.Add(this.label7);
            this.pnThemSach.Controls.Add(this.textBox7);
            this.pnThemSach.Controls.Add(this.label4);
            this.pnThemSach.Controls.Add(this.textBox8);
            this.pnThemSach.Controls.Add(this.label3);
            this.pnThemSach.Location = new System.Drawing.Point(201, 67);
            this.pnThemSach.Name = "pnThemSach";
            this.pnThemSach.Size = new System.Drawing.Size(612, 451);
            this.pnThemSach.TabIndex = 2;
            this.pnThemSach.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(224, 260);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(213, 20);
            this.textBox6.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngay";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tac Gia";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(224, 213);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 20);
            this.textBox5.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mo Ta";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loai";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 20);
            this.textBox4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nam Xuat Ban";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(224, 312);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(213, 20);
            this.textBox7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ten Sach";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(224, 359);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(213, 20);
            this.textBox8.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ma Sach";
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
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(127, 123);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(206, 20);
            this.txtBookTitle.TabIndex = 0;
            this.txtBookTitle.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tên Sách";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(384, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Khách hàng mới";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(127, 55);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(38, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "status:";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabQuanLiSach.ResumeLayout(false);
            this.pnThemSach.ResumeLayout(false);
            this.pnThemSach.PerformLayout();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnThemSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button button2;
    }
}