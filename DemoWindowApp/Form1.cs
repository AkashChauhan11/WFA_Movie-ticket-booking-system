using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;

namespace DemoWindowApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader sdr;

        public Form1(int screenNo,string movieName,string showTime, string date)
        {
            
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Akash\\Source\\Repos\\WFA_Movie-ticket-booking-system\\DemoWindowApp\\Database1.mdf;Integrated Security=True");
            this.movieName = movieName;
            this.time = showTime;
            this.screenNo = screenNo;

            lblTime.Text = date;
            lbl_screen.Text = "SCREEN " + screenNo.ToString();
            setMovieAndTime();
            getBookedSeats();
            firstRow(btn_clicked);
            midRow(btn_clicked);
            lastRow(btn_clicked);
        }

        double price=0;
        double firstRowSeatPrice = 200;
        double secondRowSeatPrice = 280;
        double lastRowSeatPrice = 350;
        List<string> selectedSeats= new List<string>();
        int totalSeatSelected = 0;
        string seats = "";
        int screenNo = 1;
       public string movieName = "";
        string time = "";
        List<string> bookedSeats= new List<string>();

        public void setMovieAndTime()
        {
            lblMovie.Text= movieName;
            lblTime.Text= time;
        }

        public void getBookedSeats()
        {
            string sql = "SELECT * FROM BookedTickets where (MovieName=@MovieName AND Time=@Time AND ScreenNo=@ScreenNo)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MovieName", movieName);
            cmd.Parameters.AddWithValue("@Time", time);
            cmd.Parameters.AddWithValue("@ScreenNo", screenNo);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string seatValues = sdr["Seats"].ToString();
                string[] splitedSeats= seatValues.Split(',');
                foreach (string s in splitedSeats)
                {
                    bookedSeats.Add(s.Trim());
                }
            }
            conn.Close();
        }

        public void firstRow(EventHandler click) {
            for(int i = 1; i <= 18; i++)
            {
                Button btn = new System.Windows.Forms.Button();

                btn.Size = new System.Drawing.Size(45, 35);
                btn.Text = i.ToString();
                if (bookedSeats.Contains(btn.Text))
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Silver;
                }
                
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                
                this.frontRowLayout.Controls.Add(btn);

                btn.Click += btn_clicked;
                

            }
           
        }

        public void resetScreen()
        {
            frontRowLayout.Controls.Clear();
            midRowLayout.Controls.Clear();
            lastRowLayout.Controls.Clear();
            seats = "";
            selectedSeats.Clear();
            getBookedSeats();
            firstRow(btn_clicked);
            midRow(btn_clicked);
            lastRow(btn_clicked);

        }

        public void midRow(EventHandler click)
        {
            for (int i = 19; i <= 54; i++)
            {
                Button btn = new System.Windows.Forms.Button();

                btn.Size = new System.Drawing.Size(45, 35);
                btn.Text = i.ToString();
                if (bookedSeats.Contains(btn.Text))
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Silver;
                }
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
             
                this.midRowLayout.Controls.Add(btn);

                btn.Click += btn_clicked;


            }
        }

        public void lastRow(EventHandler click)
        {
          
            for (int i = 55; i <= 72; i++)
            {
                Button btn = new System.Windows.Forms.Button();

                btn.Size = new System.Drawing.Size(45, 35);
                btn.Text = i.ToString();
                if (bookedSeats.Contains(btn.Text))
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Silver;
                }
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
             
                this.lastRowLayout.Controls.Add(btn);
                btn.Click += btn_clicked;
            }
        }


        public void sendEmail()
        {
            try
            {
                // Create a new MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("akashchauhan11443@gmail.com");
                mail.To.Add("akashchauhan191311@gmail.com");
                mail.Subject = "Congratulation !! Ticket Booked for "+movieName;
                mail.Body = "Dear"+"Akash"+"\nWe are happy to inform you that your ticket for Movie is Successfully Booked! " +
                    "\nMovie:"+movieName+ "\nDate: 20-08-2023\nTime: "+time+"\nseats: "+seats+"\nTotal Amount to Pay: "+price.ToString();

                // Configure SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587; // Use the appropriate port
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("akashchauhan11443@gmail.com", "ewakpsonkrzgowtg");
                smtpClient.EnableSsl = true;

                // Send the email
                smtpClient.Send(mail);

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        public void btn_clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double ticketPrice = 0;
            int startindex = totalSeatSelected - 1 == -1 ? 0 : totalSeatSelected - 1;
            seats = "";


            if (int.Parse(btn.Text) >= 1 && int.Parse(btn.Text) <= 18)
            {
                ticketPrice = firstRowSeatPrice;
            } else if (int.Parse(btn.Text) >= 19 && int.Parse(btn.Text) <= 54)
            {
                ticketPrice = secondRowSeatPrice;
            }
            else
            {
                ticketPrice = lastRowSeatPrice;
            }


            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Silver;
                price -= ticketPrice;
                selectedSeats.Remove(btn.Text);
                totalSeatSelected -= 1;
            }
            else if (btn.BackColor == Color.Red) {

            } else
            {
                btn.BackColor = Color.Green;
                price += ticketPrice;
                selectedSeats.Add(btn.Text);
                totalSeatSelected += 1;
            }

            if (btn.BackColor != Color.Red) {
               
            for (int i =0; i < totalSeatSelected; i++)
            {

                seats += selectedSeats[i] + " ,";

            }
        }
            
            lblPrice.Text="₹ "+price.ToString();
            lblTotalSelSeat.Text=totalSeatSelected.ToString();
            lblSelectedSeats.Text = seats;
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPrice.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO  BookedTickets(MovieName,Time,ScreenNo,UserEmail,Seats) VALUES (@MovieName,@Time,@ScreenNo,@UserEmail,@Seats)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MovieName", movieName);
            cmd.Parameters.AddWithValue("@Time", time);
            cmd.Parameters.AddWithValue("@ScreenNo", screenNo);
            cmd.Parameters.AddWithValue("@UserEmail", "akashchauhan11443@gmail.com");
            cmd.Parameters.AddWithValue("@Seats", seats);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ticket Booked Successfully");
            //sendEmail();
            seats = "";
            totalSeatSelected = 0;
            price = 0;
            lblPrice.Text = "₹ " + price.ToString();
            lblTotalSelSeat.Text = totalSeatSelected.ToString();
            lblSelectedSeats.Text = seats;
            conn.Close();
            this.resetScreen(); 
            
        }
    }
}
