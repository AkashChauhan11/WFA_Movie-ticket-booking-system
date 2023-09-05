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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string screen1MovieName = "";
        public string screen1Movielanguage = "";
        public string screen2MovieName = "";
        public string screen2Movielanguage = "";
        public string screen3MovieName = "";
        public string screen3Movielanguage = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog dlg = new OpenFileDialog())
            //{
            //    dlg.Title = "open Image";
            //    if(dlg.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox1.Image=new Bitmap(dlg.FileName);
            //    }
            //}
        }
    }
}
