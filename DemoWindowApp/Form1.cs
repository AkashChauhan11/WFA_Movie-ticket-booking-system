using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstRow(btn_clicked);
            midRow(btn_clicked);
            lastRow(btn_clicked);
            setMovieAndTime();
            

        }

        double price=0;
        double firstRowSeatPrice = 200;
        double secondRowSeatPrice = 280;
        double lastRowSeatPrice = 350;
        List<string> selectedSeats= new List<string>();
        int totalSeatSelected = 0;
        string movieName = "Black Panther";
        string time = "3 pm - 6 pm";

        public void setMovieAndTime()
        {
            lblMovie.Text= movieName;
            lblTime.Text= time;
        }



        public void firstRow(EventHandler click) {
            for(int i = 1; i <= 18; i++)
            {
                Button btn = new System.Windows.Forms.Button();

                btn.Size = new System.Drawing.Size(45, 35);
               
                btn.BackColor= Color.Silver;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn.Text = i.ToString();
                this.frontRowLayout.Controls.Add(btn);

                btn.Click += btn_clicked;
                

            }
           
        }


        public void midRow(EventHandler click)
        {
            for (int i = 19; i <= 54; i++)
            {
                Button btn = new System.Windows.Forms.Button();

                btn.Size = new System.Drawing.Size(45, 35);

                btn.BackColor = Color.Silver;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn.Text = i.ToString();
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

                btn.BackColor = Color.Silver;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn.Text = i.ToString();
                this.lastRowLayout.Controls.Add(btn);
                btn.Click += btn_clicked;
            }
        }


        public void btn_clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double ticketPrice = 0;
            string seats = "";

            if (  int.Parse( btn.Text) >=1 && int.Parse(btn.Text) <= 18)
            {
                ticketPrice = firstRowSeatPrice;
            }else if(int.Parse(btn.Text) >= 19 && int.Parse(btn.Text) <= 54)
            {
                ticketPrice = secondRowSeatPrice;
            }
            else
            {
                ticketPrice = lastRowSeatPrice;
            }


            if(btn.BackColor == Color.Green && btn.BackColor != Color.Red)
            {
                btn.BackColor = Color.Silver;
                    price -= ticketPrice;
                selectedSeats.Remove(btn.Text);
                totalSeatSelected -= 1;
            }
            else
            {
                btn.BackColor = Color.Green;
                    price += ticketPrice;
                selectedSeats.Add(btn.Text);
                totalSeatSelected += 1;
            }

            for(int i = 0; i <totalSeatSelected; i++)
            {
                
                seats += selectedSeats[i]+" ,";
                
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
    }
}
