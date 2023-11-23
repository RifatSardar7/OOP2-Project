using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP2Project
{
    public partial class distributor : Form
    {
        string connString = "Data Source=LAPTOP-UKG5KBRG;Initial Catalog=Seller;Integrated Security=True";
        public distributor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from sellertable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete sellertable where UserId  =@UserId", conn);
            cmd.Parameters.AddWithValue("@UserId", int.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Delated successfully");
            btnshow.PerformClick();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from sellertable where UserId  =@UserId", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@UserId", int.Parse(textBox2.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update sellertable set UserName = @UserName, UserId = @UserId where UserId  =@UserId", conn);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@UserID", int.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully");
            btnshow.PerformClick();

        }
    }
}
