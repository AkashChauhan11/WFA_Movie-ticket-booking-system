﻿using System;
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
    public partial class ManageMovieScreen : Form
    {
        SqlConnection conn;
        SqlDataReader sdr;
        public ManageMovieScreen()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Akash\\Source\\Repos\\WFA_Movie-ticket-booking-system\\DemoWindowApp\\Database1.mdf;Integrated Security=True");
            getInitialdata();
        }

        //poster paths
        string screen1PicPath;
        string screen2PicPath = "";
        string screen3PicPath = "";

        //movie names
        string screen1MovieName = "";
        string screen2MovieName="";
        string screen3MovieName = "";

        //movie languages
        string screen1MovieLang = "";
        string screen2MovieLang = "";
        string screen3MovieLang = "";



        public void getInitialdata()
        {
            string sql = "SELECT * FROM MovieDetails";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string screen = sdr["screenNo"].ToString();
                if(screen == "1")
                {
                    screen1MovieName = sdr["MovieName"].ToString();
                    screen1MovieLang = sdr["Language"].ToString();
                    screen1PicPath = sdr["poster"].ToString();
                    txt_movie_s1.Text = screen1MovieName;
                    txt_lang_s1.Text = screen1MovieLang;
                    picBox_screen1.Image = Image.FromFile(@screen1PicPath);
                }
                if (screen == "2")
                {
                    screen2MovieName = sdr["MovieName"].ToString();
                    screen2MovieLang = sdr["Language"].ToString();
                    screen2PicPath = sdr["poster"].ToString();
                    txt_movie_s2.Text = screen2MovieName;
                    txt_lang_s2.Text = screen2MovieLang;
                    picBox_screen2.Image = Image.FromFile(@screen2PicPath);
                }
                if (screen == "3")
                {
                    screen3MovieName = sdr["MovieName"].ToString();
                    screen3MovieLang = sdr["Language"].ToString();
                    screen3PicPath = sdr["poster"].ToString();
                    txt_movie_s3.Text = screen3MovieName;
                    txt_lang_s3.Text = screen3MovieLang;
                    picBox_screen3.Image = Image.FromFile(@screen3PicPath);
                }

            }
            conn.Close();
        }


        private void btn_chooseImg_s1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "open Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBox_screen1.Image = new Bitmap(dlg.FileName);
                    screen1PicPath= dlg.FileName;
                }
            }
        }

        private void btn_chooseImg_s2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "open Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBox_screen2.Image = new Bitmap(dlg.FileName);
                    screen2PicPath = dlg.FileName;
                }
            }
        }

        private void btn_chooseImg_s3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "open Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBox_screen3.Image = new Bitmap(dlg.FileName);
                    screen3PicPath = dlg.FileName;
                }
            }
        }

        private void btn_update_s1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "UPDATE Moviedetails SET MovieName=@MovieName, Language=@Language,poster=@poster WHERE screenNo=1";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MovieName",txt_movie_s1.Text);
            cmd.Parameters.AddWithValue("@Language", txt_lang_s1.Text);
            cmd.Parameters.AddWithValue("@poster", screen1PicPath);
            cmd.ExecuteNonQuery();

           
            string sql2 = "UPDATE Moviedetails SET MovieName=@MovieName, Language=@Language,poster=@poster WHERE screenNo=2";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@MovieName", txt_movie_s2.Text);
            cmd2.Parameters.AddWithValue("@Language", txt_lang_s2.Text);
            cmd2.Parameters.AddWithValue("@poster", screen2PicPath);
            cmd2.ExecuteNonQuery();

            string sql3 = "UPDATE Moviedetails SET MovieName=@MovieName, Language=@Language,poster=@poster WHERE screenNo=3";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            cmd3.Parameters.AddWithValue("@MovieName", txt_movie_s3.Text);
            cmd3.Parameters.AddWithValue("@Language", txt_lang_s3.Text);
            cmd3.Parameters.AddWithValue("@poster", screen3PicPath);
            cmd3.ExecuteNonQuery();

            MessageBox.Show("Update successsfull");
            conn.Close();
            this.Close();

        }
    }
}
