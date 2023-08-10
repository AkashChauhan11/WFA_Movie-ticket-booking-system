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

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.BackColor == Color.Green)
            {
                pictureBox1.BackColor = Color.Silver;

            }
            else
            {
            pictureBox1.BackColor = Color.Green;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.Green)
            {
                pictureBox2.BackColor = Color.Silver;
               
            }
            else
            {
                pictureBox2.BackColor = Color.Green;

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
