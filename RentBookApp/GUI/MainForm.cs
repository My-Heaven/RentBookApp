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
        String txtUsername;
        List<BookDTO> listBooks;
        DataTable dtBooks;
        int TongSoNgay;
        bool saveForAdd = true;
        DataTable books;
        Form1 f1;
        public MainForm(String fullname, String txtUsername)
        {
            InitializeComponent();
            lbStaff.Text = fullname;
            this.fullname = fullname;
            this.txtUsername = txtUsername;
            txtRentDate.Text = DateTime.Now.ToShortDateString();
            loadData();
            loadDgvBooks(string.Empty);
            dgvBooks.ClearSelection();
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
        void loadDgvBooks(string bookTitle)
        {
            BooksDAO dao = new BooksDAO();
            books = dao.getBook(bookTitle);
            dgvBooks.DataSource = books;
            dgvBooks.ClearSelection();
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
                foreach (BookTypeDTO type in bookTypes)
                {
                    if (type.typeID == dto.typeID)
                    {
                        lbloaisach.Text = type.typeName;
                    }
                }
                lbtacgia.Text = dto.author;
                lbnamxuatban.Text = dto.publishingYear.ToString();
                lbBookstatus.Text = "";
            }
            else
            {
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
            lblIndex.Text = index + "";
        }
        void setEmpty()
        {
            lbtensach.Text = string.Empty;
            lbloaisach.Text = string.Empty;
            lbtacgia.Text = string.Empty;
            lbnamxuatban.Text = string.Empty;
            searchBook.Text = string.Empty;
            cusPhone.Text = string.Empty;
            lblFullName.Text = string.Empty;
            lbBookstatus.Text = string.Empty;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            listBooks = null;
            setEmpty();
            loadData();
        }
        bool checkOrder()
        {
            if (string.IsNullOrEmpty(this.txtUsername))
            {
                MessageBox.Show("Chưa đăng nhập");
                return false;
            }
            if (string.IsNullOrEmpty(this.cusPhone.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtRentDate.Text.Trim()))
            {
                MessageBox.Show("Không có ngày thuê");
                return false;
            }
            try
            {
                dpReturnDate.Value.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày trả không hợp lệ");
                return false;
            }
            DateTime ngaymuon = Convert.ToDateTime(txtRentDate.Text);
            DateTime ngaytra = Convert.ToDateTime(dpReturnDate.Value.ToShortDateString());
            TimeSpan Time = ngaytra - ngaymuon;
            this.TongSoNgay = Time.Days;
            if (TongSoNgay <= 0)
            {
                MessageBox.Show("Ngày thuê không hợp lệ");
                return false;
            }
            if (listBooks == null)
            {
                MessageBox.Show("Không có sách để thuê");
                return false;
            }

            return true;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (checkOrder() == true)
            {
                float price = 0;
                foreach (BookDTO b in listBooks)
                {
                    price += b.price;
                }
                price = price * TongSoNgay;
                OrderDTO dto = new OrderDTO
                {
                    creater = this.txtUsername,
                    Costomer = this.cusPhone.Text,
                    orderDate = this.txtRentDate.Text,
                    returnDate = this.dpReturnDate.Value.ToShortDateString(),
                    status = true,
                    price = price

                };
                OrderDAO dao = new OrderDAO();
                bool result = dao.createOrder(dto);
                if (result == true)
                {
                    int orderID = dao.getOrderID();
                    foreach (BookDTO book in listBooks)
                    {
                        OrderDetailDTO ordto = new OrderDetailDTO
                        {
                            bookID = book.bookID,
                            orderID = orderID,
                            price = book.price
                        };
                        dao.createOrderDetail(ordto);
                    }
                    MessageBox.Show("Số tiền cần trả để mượn sách là : " + price);
                    listBooks = null;
                    setEmpty();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        void emptyTxt()
        {
            txtBookID.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtBookTitle.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtPublishingYear.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            }
            catch (FormatException fe)
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
                price = price,
                quantity = quantity,
                status = true

            };
            if (saveForAdd)
            {
                if (check)
                {
                    try
                    {
                        BooksDAO dao = new BooksDAO();
                        check = dao.addNewBook(book);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công");
                        emptyTxt();
                        btnUpdateBook.Enabled = true;
                        btnSave.Enabled = false;
                        btnRemoveBook.Enabled = true;
                        btnCreateBook.Enabled = true;
                        loadDgvBooks(string.Empty);
                        dgvBooks.Enabled = true;
                        btnHuy1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            else
            {
                if (check)
                {
                    try
                    {
                        BooksDAO dao = new BooksDAO();
                        book.bookID = int.Parse(txtBookID.Text);
                        check = dao.updateBook(book);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (check)
                    {
                        MessageBox.Show("Sửa thành công");
                        emptyTxt();
                        btnUpdateBook.Enabled = true;
                        btnSave.Enabled = false;
                        btnRemoveBook.Enabled = true;
                        btnCreateBook.Enabled = true;
                        loadDgvBooks(string.Empty);
                        btnHuy1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            btnCreateBook.Enabled = false;
            emptyTxt();
            btnRemoveBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            saveForAdd = true;
            btnSave.Enabled = true;
            dgvBooks.Enabled = false;
            btnHuy1.Enabled = true;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int index = dgvBooks.CurrentCell.RowIndex;
            if (index >= 0 && !string.IsNullOrEmpty(txtBookID.Text))
            {
                btnUpdateBook.Enabled = false;
                btnRemoveBook.Enabled = false;
                saveForAdd = false;
                btnCreateBook.Enabled = false;
                btnSave.Enabled = true;
                btnHuy1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chọn sách để sửa.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            int index = dgvBooks.CurrentCell.RowIndex;
            if (index >= 0)
            {
                try
                {
                    string bookID = txtBookID.Text;
                    BooksDAO dao = new BooksDAO();
                    bool check = dao.removeBook(bookID);
                    if (check)
                    {
                        MessageBox.Show("Xóa Thành công.");
                        loadDgvBooks(string.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chọn sách để Xóa.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            loadDgvBooks(search);
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            emptyTxt();
            dgvBooks.Enabled = true;
            btnCreateBook.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnRemoveBook.Enabled = true;
            btnSave.Enabled = false;
            btnHuy1.Enabled = false;
            dgvBooks.ClearSelection();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            CustomerDAO dao = new CustomerDAO();
            string result = dao.checkCustomer(phone);
            if (result != null)
            {
                lblfullNameH.Text = result;
                OrderDAO oDao = new OrderDAO();
                DataTable oder = oDao.getListOrder(phone);
                if (oder.Rows.Count == 0)
                {
                    MessageBox.Show("Khách hàng đã trả hết sách");
                }
                dgvHistory.DataSource = oder;
                dgvHistory.ClearSelection();
            }
            else
            {
                lblfullNameH.Text = "Khách hàng không tồn tại";
            }
        }

        private void dgvBooks_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txtBookID.Text = dgvBooks.Rows[rowIndex].Cells["bookID"].FormattedValue.ToString();
                txtBookTitle.Text = dgvBooks.Rows[rowIndex].Cells["bookTitle"].FormattedValue.ToString();
                txtAuthor.Text = dgvBooks.Rows[rowIndex].Cells["author"].FormattedValue.ToString();
                txtPrice.Text = dgvBooks.Rows[rowIndex].Cells["price"].FormattedValue.ToString();
                txtPublishingYear.Text = dgvBooks.Rows[rowIndex].Cells["publishingYear"].FormattedValue.ToString();
                txtQuantity.Text = dgvBooks.Rows[rowIndex].Cells["quantity"].FormattedValue.ToString();
                string type = dgvBooks.Rows[rowIndex].Cells["typeID"].FormattedValue.ToString();
                cbxBookType.SelectedItem = type;
            }
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                string orderID = dgvHistory.Rows[rowIndex].Cells["orderID"].FormattedValue.ToString();
                OrderDAO dao = new OrderDAO();
                DataTable detail = dao.getListOrderDetail(int.Parse(orderID));
                dgvDetail.DataSource = detail;
                dgvDetail.ClearSelection();
                panelDetail.Visible = true;
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvHistory.CurrentCell.RowIndex;
            string orderID = dgvHistory.Rows[rowIndex].Cells["orderID"].FormattedValue.ToString();
            OrderDAO dao = new OrderDAO();
            bool check = dao.traSach(int.Parse(orderID));
            if (check)
            {
                MessageBox.Show("Thành công");
                panelDetail.Visible = false;
                DataTable oder = dao.getListOrder(txtPhone.Text);
                dgvHistory.DataSource = oder;
                dgvHistory.ClearSelection();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
