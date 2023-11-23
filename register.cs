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

    public partial class register : Form
    {
        string connectionString = @"Data Source=LAPTOP-UKG5KBRG;Initial Catalog=Registration;Integrated Security=True;";
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textfirstname.Text == "" && textpassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textpassword.Text != textconfirm.Text)
                MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textfirstname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textlastname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", textcontact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", textaddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserType", textuser.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textpassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    Clear();
                }
            }
        }
        void Clear()
        {
            textfirstname.Text = textlastname.Text = textcontact.Text = textaddress.Text = textuser.Text =  textpassword.Text = textconfirm.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
