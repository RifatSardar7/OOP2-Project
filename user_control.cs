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
    public partial class user_control : Form
    {
        string connString = "Data Source=LAPTOP-UKG5KBRG;Initial Catalog=Users;Integrated Security=True";
        public user_control()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin().Show();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into usertable values (@UserName,@UserId)", conn);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@UserId", int.Parse(textBox2.Text));
           
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data inserted successfully");
            btnshow.PerformClick();

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from usertable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from usertable where UserId  =@UserId", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@UserId", int.Parse(textBox2.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete usertable where UserId  =@UserId", conn);
            cmd.Parameters.AddWithValue("@UserId", int.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Delated successfully");
            btnshow.PerformClick();

        }

        private void user_control_Load(object sender, EventArgs e)
        {
            btnshow.PerformClick();
        }
    }
}
