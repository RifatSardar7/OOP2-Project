using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP2Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                txtid.Focus();
                
                errorProvider1.SetError(this.txtid, "Enter your ID!");
                button1.Enabled = false;
                
            }
            else
            {
                button1.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                txtpass.Focus();
                
                errorProvider2.SetError(this.txtpass, "Enter your password!");
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
                errorProvider2.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-UKG5KBRG;Initial Catalog=Login;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from logintable where id ='" + txtid.Text + "' and password='" + txtpass.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                string cmbItemValue = comboBox1.SelectedItem.ToString();
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    if(dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("You are logged in as " + dt.Rows[i][2]);
                        if(comboBox1.SelectedIndex == 0)
                        {
                            admin a = new admin();
                            a.Show();
                            this.Hide();
                        }
                        else if(comboBox1.SelectedIndex == 1)
                        {
                            Seller s = new Seller();
                            s.Show();
                            this.Hide();
                        }
                        else
                        {
                            distributor d = new distributor();
                            d.Show();
                            this.Hide();
                        }
                        
                    }
                }

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
