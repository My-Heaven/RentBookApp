using RentBookApp.DAO;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CustomerDAO dao = new CustomerDAO();
            bool result = dao.CreateCustomer(txtPhone.Text, txtFullname.Text, txtAddress.Text);
        }
    }
}
