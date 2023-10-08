using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowApp
{
    public partial class Form3 : Form
    {
        SqlConnection conn;
        public Form3()
        {
            InitializeComponent();
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Akash\\Downloads\\WFA_Movie-ticket-booking-system (1)\\WFA_Movie-ticket-booking-system\\DemoWindowApp\\Database1.mdf\";Integrated Security=True";
            conn = new SqlConnection(conStr);
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string querry = " select * from admin Where UserName=@UserName AND Password=@Password";

            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@UserName", tbUserName.Text.ToString());
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               
                this.Hide();
                var form = new Form2();
                form.Closed += (s, args) => this.Close();
                form.Show();
                conn.Close();
              
            }
            else
            {
                MessageBox.Show(this, "Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
