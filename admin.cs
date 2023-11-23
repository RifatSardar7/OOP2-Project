using System;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new user_control().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new dashboard().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new revenue().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0298746338222");
        }
    }
}
