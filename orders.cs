using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace OOP2Project
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        

        private void btnadd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtorderid.Text, txtproduct.Text, txtorderdate.Text, txtcustomername.Text, txtcustomerid.Text, txtphone.Text);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtorderid.Text = "";
            txtproduct.Text = "";
            txtorderdate.Text = "";
            txtcustomername.Text = "";
            txtcustomerid.Text = "";
            txtphone.Text = "";
        }
        Bitmap bitmap;
        private void btnprint_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Seller().Show();
        }
    }
}
