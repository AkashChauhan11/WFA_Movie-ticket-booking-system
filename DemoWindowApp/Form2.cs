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
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlDataReader sdr;
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Akash\\Source\\Repos\\WFA_Movie-ticket-booking-system\\DemoWindowApp\\Database1.mdf;Integrated Security=True");
            getInitialdata();
        }

       public void getInitialdata()
        {
            string sql = "SELECT * FROM MovieDetails";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string screen = sdr["screenNo"].ToString();
                if (screen == "1")
                {
                    lbl_movie_s1.Text = sdr["MovieName"].ToString();
                    lbl_lang_s1.Text = sdr["Language"].ToString();
                    string screen1PicPath = sdr["poster"].ToString();
                    pictureBox1.Image = Image.FromFile(@screen1PicPath);
                }
                if (screen == "2")
                {
                    lbl_movie_s2.Text = sdr["MovieName"].ToString();
                    lbl_lang_s2.Text = sdr["Language"].ToString();
                    string screen2PicPath = sdr["poster"].ToString();
                    pictureBox2.Image = Image.FromFile(@screen2PicPath);
                }
                if (screen == "3")
                {
                    lbl_movie_s3.Text = sdr["MovieName"].ToString();
                    lbl_lang_s3.Text = sdr["Language"].ToString();
                    string screen3PicPath = sdr["poster"].ToString();
                    pictureBox3.Image = Image.FromFile(@screen3PicPath);
                }

            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageMovieScreen manageMoviescreen = new ManageMovieScreen();
            manageMoviescreen.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(screenNo:1,movieName:lbl_movie_s1.Text,showTime:dd_showTime_s1.Text,date:date_picker.SelectionRange.Start.ToShortDateString());
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(screenNo: 2, movieName: lbl_movie_s2.Text, showTime: dd_showTime_s2.Text, date: date_picker.SelectionRange.Start.ToShortDateString());
            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(screenNo: 3, movieName: lbl_movie_s3.Text, showTime: dd_showTime_s3.Text, date: date_picker.SelectionRange.Start.ToShortDateString());
            form.Show();
        }

        public void resetScreen()
        {
            this.Controls.Clear();
            InitializeComponent();
            getInitialdata();

        }
    }
}
