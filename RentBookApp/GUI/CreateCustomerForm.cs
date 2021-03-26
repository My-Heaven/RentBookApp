using RentBookApp.DAO;
using RentBookApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBookApp.GUI
{
    public partial class CreateCustomerForm : Form
    {
        MainForm f = null;
        public CreateCustomerForm(MainForm mainForm)
        {
            InitializeComponent();
            f = mainForm;
        }

        private void CreateCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Enabled = true;
        }
        bool check()
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống");
                return false;
            }
            try
            {
                int.Parse(txtPhone.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("số điện thoại phải nhập số");
                return false;
            }
            if (string.IsNullOrEmpty(txtFullname.Text))
            {
                MessageBox.Show("Tên không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống");
                return false;
            }
            return true;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CustomerDAO dao = new CustomerDAO();
            CustomerDTO dto = new CustomerDTO
            {
                Phone = txtPhone.Text,
                Fullname = txtFullname.Text,
                Address = txtAddress.Text
            };
            if (check())
            {
                bool result = dao.CreateCustomer(dto);
            
            if(result == true)
            {
                MessageBox.Show("Tạo khách hàng thành công");
                f.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo khách hàng thất bại");
            }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            f.Enabled = true;
            this.Close();
        }
    }
}
