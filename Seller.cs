﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Project
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new products().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new orders().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new revenue().Show();
        }
    }
}
