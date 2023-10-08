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
    public partial class Form4 : Form
    {

        SqlConnection conn;
        public Form4()
        {
            InitializeComponent();
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Akash\\Downloads\\WFA_Movie-ticket-booking-system (1)\\WFA_Movie-ticket-booking-system\\DemoWindowApp\\Database1.mdf\";Integrated Security=True";
            conn = new SqlConnection(conStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            conn.Open();
            string sql = "UPDATE admin SET Password=@NPassword WHERE UserName=@UserName AND Password=@CPassword";
            SqlCommand c = new SqlCommand(sql, conn);
            c.Parameters.AddWithValue("@UserName", tbUserName.Text);
            c.Parameters.AddWithValue("@NPassword", tbNPassword.Text);
            c.Parameters.AddWithValue("@CPassword", tbCPassword.Text);
            int rowsAffected=c.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show(this, "Password Update Successfull", "Reset Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Password Update Failed", "Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
