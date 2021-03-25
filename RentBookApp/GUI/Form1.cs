using RentBookApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            EmployeeDAO dao = new EmployeeDAO();
            string result = dao.CheckLogin(txtUsername.Text, txtPassword.Text);
            if(result != null)
            {
                MainForm mf = new MainForm(result , txtUsername.Text);
                mf.FormClosed += new FormClosedEventHandler(frm_MainFormClosed);
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }

        }
        private void frm_MainFormClosed(object sender, FormClosedEventArgs e){
            this.Show();
            txtPassword.Text = string.Empty;
        }

    }
}
