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
        String fullname;
        bool role;
        public Form1()
        {
            InitializeComponent();
        }
        String cs = @"Data Source=TANDAT\SQLEXPRESS;Initial Catalog=RentBooksApp;Persist Security Info=True;User ID=sa;Password=dat123";

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select [fullname],[roleId] from[dbo].[tblAccount] where[username] = @username and [password] = @password", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.HasRows)
                {
                    
                    while (sdr.Read())
                    {
                        fullname = sdr.GetString(0);
                        role = sdr.GetBoolean(1);
                    }
                    MessageBox.Show("Dang nhap thanh cong !");
                    this.Hide();
                    MainForm mf = new MainForm(fullname,role);
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
