using RentBookApp.DAO;
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
        public MainForm(String fullname)
        {
            InitializeComponent();
            lbStaff.Text = fullname;
            this.fullname = fullname;
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
                lbloaisach.Text = dto.typeID.ToString();
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
            string bookType = type.typeID;
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
            int typeID = (int)cbxBookType.SelectedItem;
            MessageBox.Show(typeID.ToString());
        }
    }
}
