﻿using System;
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
        public MainForm(String fullname)
        {
            InitializeComponent();
            lbStaff.Text = fullname;
            this.fullname = fullname;
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