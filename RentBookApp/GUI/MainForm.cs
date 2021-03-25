﻿using RentBookApp.DAO;
using RentBookApp.DTO;
using RentBookApp.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBookApp
{
    public partial class MainForm : Form
    {
        List<BookTypeDTO> bookTypes = null;
        String fullname;
        List<BookDTO> listBooks;
        DataTable dtBooks;
        public MainForm(String fullname)
        {
            InitializeComponent();
            lbStaff.Text = fullname;
            this.fullname = fullname;
            loadData();
        }
        void loadData()
        {
            dtBooks = new DataTable();
            dtBooks.Columns.Add("Tên sách", typeof(string));
            dtBooks.Columns.Add("Loại sách", typeof(int));
            dtBooks.Columns.Add("Tác giả", typeof(string));
            dtBooks.Columns.Add("Năm xuất bản", typeof(int));
            if (listBooks != null)
            {
                for (int i = 0; i < this.listBooks.Count; i++)
                {
                    dtBooks.Rows.Add(this.listBooks[i].bookTitle, this.listBooks[i].typeID, this.listBooks[i].author, this.listBooks[i].publishingYear);
                }
            }
            dgvCart.DataSource = dtBooks;
            dgvCart.AutoResizeColumns();
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string phone = cusPhone.Text;
            CustomerDAO dao = new CustomerDAO();
            string result = dao.checkCustomer(phone);
            if (result != null)
            {
                lblFullName.Text = result;
            }
            else
            {
                lblFullName.Text = "Khách hàng không tồn tại";
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomerForm crf = new CreateCustomerForm(this);
            this.Enabled = false;
            crf.Show();
        }

        private void searchBook_TextChanged(object sender, EventArgs e)
        {

            string bookId = searchBook.Text;
            BooksDAO dao = new BooksDAO();
            BookDTO dto = dao.findBook(bookId);
            if (dto != null)
            {
                lbtensach.Text = dto.bookTitle;
                foreach(BookTypeDTO type in bookTypes){
                    if(type.typeID== dto.typeID)
                    {
                        lbloaisach.Text = type.typeName;
                    }
                }
                lbtacgia.Text = dto.author;
                lbnamxuatban.Text = dto.publishingYear.ToString();
                lbBookstatus.Text = "";
            }
            else{
                lbBookstatus.Text = "Không tìm thấy";
                lbtensach.Text = "";
                lbloaisach.Text = "";
                lbtacgia.Text = "";
                lbnamxuatban.Text = "";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData();
            bookTypes = BookTypeDAO.getBookTypes();
            cbxBookType.DisplayMember = "typeName";
            cbxBookType.ValueMember = "typeID";
            cbxBookType.DataSource = bookTypes;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
        bool checkBook()
        {
            bool result = true;
            string bookTitle = txtBookTitle.Text.Trim();
            if (string.IsNullOrEmpty(bookTitle))
            {
                result = false;
                error.SetError(txtBookTitle, "Nhập tên sách!!!!");
            }
            else
            {
                if (bookTitle.Length > 100)
                {
                    result = false;
                    error.SetError(txtBookTitle, "<= 100 ký tự!!!!");
                }
            }
            BookTypeDTO type = (BookTypeDTO)cbxBookType.SelectedItem;
            int bookType = type.typeID;
            string author = txtAuthor.Text.Trim();
            if (string.IsNullOrEmpty(author))
            {
                result = false;
                error.SetError(txtAuthor, "Nhập Tác Giả!!!!");
            }
            else
            {
                if (author.Length > 100)
                {
                    result = false;
                    error.SetError(txtAuthor, "<=100 ký tự!!!!");
                }
            }
            try
            {
            }
            catch (FormatException fe)
            {
                result = false;
                error.SetError(txtQuantity, "<=100 ký tự!!!!");
            }
            return result;
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            bool check = true;
            string bookTitle = txtBookTitle.Text.Trim();
            if (string.IsNullOrEmpty(bookTitle))
            {
                check = false;
                error.SetError(txtBookTitle, "Nhận tên sách");
            }
            else
            {
                if (bookTitle.Length > 100)
                {
                    check = false;
                    error.SetError(txtBookTitle, "<=100 ký tự");
                }
            }
            string author = txtAuthor.Text.Trim();
            if (string.IsNullOrEmpty(author))
            {
                check = false;
                error.SetError(txtAuthor, "Nhận tên tác giả");
            }
            else
            {
                if (author.Length > 100)
                {
                    check = false;
                    error.SetError(txtAuthor, "<=100 ký tự");
                }
            }
            int typeID = (int)cbxBookType.SelectedValue;
            int publishingYear = 0;
            try
            {
                if (string.IsNullOrEmpty(txtPublishingYear.Text.Trim()))
                {
                    check = false;
                    error.SetError(txtPublishingYear, "Nhập năm xuất bản");
                }
                publishingYear = int.Parse(txtPublishingYear.Text.Trim());
                if (publishingYear < 1500)
                {
                    check = false;
                    error.SetError(txtPublishingYear, ">=1500");
                }
            }catch(FormatException fe)
            {
                check = false;
                error.SetError(txtPublishingYear, "Nhập số");
            }
            int quantity = 0;
            try
            {
                if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
                {
                    check = false;
                    error.SetError(txtQuantity, "Nhập Số lượng");
                }
                quantity = int.Parse(txtQuantity.Text.Trim());
                if (quantity <= 0)
                {
                    check = false;
                    error.SetError(txtQuantity, ">0");
                }
            }
            catch (FormatException fe)
            {
                check = false;
                error.SetError(txtQuantity, "Nhập số");
            }
            float price = 0;
            try
            {
                if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    check = false;
                    error.SetError(txtPrice, "Nhập giá");
                }
                price = float.Parse(txtPrice.Text.Trim());
                if (price <= 0)
                {
                    check = false;
                    error.SetError(txtPrice, ">0");
                }
            }
            catch (FormatException fe)
            {
                check = false;
                error.SetError(txtPrice, "Nhập số");
            }
            BookDTO book = new BookDTO
            {
                bookTitle = bookTitle,
                author = author,
                typeID = typeID,
                publishingYear = publishingYear,
                price=price,
                quantity=quantity,
                status=true

            };
            if (check)
            {
                try
                {
                    BooksDAO dao = new BooksDAO();
                    check = dao.addNewBook(book);
                }catch(Exception ex)
                {
                    check = false;
                    MessageBox.Show("ex");
                }
                if (check)
                {
                    MessageBox.Show("Thêm thành công");
                    txtAuthor.Text = string.Empty;
                    txtBookTitle.Text = string.Empty;
                    txtPrice.Text = string.Empty;
                    txtPublishingYear.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cusPhone.Text))
            {
                MessageBox.Show("Nhập khách hàng");
                return;
            }
            BooksDAO dao = new BooksDAO();
            BookDTO dto = dao.findBook(searchBook.Text);
            if (this.listBooks == null)
            {
                this.listBooks = new List<BookDTO>();
            }
            if (dto != null)
            {
                foreach (BookDTO book in listBooks)
                {
                    if (dto.bookID == book.bookID)
                    {
                        MessageBox.Show("Sách này đã được thêm, vui lòng thêm sách khác");
                        return;
                    }
                }
                listBooks.Add(dto);
                MessageBox.Show("Thêm sách thành công");
                loadData();
            }
            else
            {
                MessageBox.Show("Chọn sách để thêm");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBooks != null)
            {
                int index = -1;
                try
                {
                    index = int.Parse(lblIndex.Text);

                    listBooks.RemoveAt(index);
                    loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chọn sách để xóa");
                }
            }
            else
            {
                MessageBox.Show("Không có gì để xóa");
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            lblIndex.Text = index+"";
        }
    }
}
