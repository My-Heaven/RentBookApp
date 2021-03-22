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
        String fullname;
        bool role;
        public MainForm(String fullname, bool role)
        {
            InitializeComponent();
            lbStaff.Text = fullname;
            this.fullname = fullname;
            this.role = role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnThemSach.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
