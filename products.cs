using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Project
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("Items already Exists");
                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill the text box first");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            MessageBox.Show("Total items are : " + count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void products_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Products", 250);
        

        }

        private void showAll()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(50, 50);

            String[] paths = { };
            paths = Directory.GetFiles("E:/images");

            try
            {
                foreach (string path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            listView1.SmallImageList = imgs;
            listView1.Items.Add("Controller", 0);
            listView1.Items.Add("Laptop", 1);
            listView1.Items.Add("Headset", 2);
            listView1.Items.Add("Cooler", 3);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Seller().Show();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listView1.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(selected);
        }

        
    }
}
