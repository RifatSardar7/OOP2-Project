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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin().Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(label10.Text);

            if (val < 120)
            {
                val += 1;
                label10.Text = val.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(label11.Text);

            if (val < 120)
            {
                val += 1;
                label11.Text = val.ToString();
            }
            else
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(label12.Text);

            if (val < 120)
            {
                val += 1;
                label12.Text = val.ToString();
            }
            else
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(label13.Text);

            if (val < 120)
            {
                val += 1;
                label13.Text = val.ToString();
            }
            else
            {
                timer4.Stop();
            }
        }
    }
}
