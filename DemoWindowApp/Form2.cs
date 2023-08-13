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
        private int nextGroupBoxTop=30;
        public Form2()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGroupBox();
        }

        private void AddGroupBox()
        {
            GroupBox newGroupBox = new GroupBox();
            this.Controls.Add(newGroupBox);

            newGroupBox.Size = new System.Drawing.Size(1027, 150);
            newGroupBox.Top = nextGroupBoxTop; // Set the top position manually
            newGroupBox.Left = 0;
            newGroupBox.TabStop = false;
            newGroupBox.Text = "New Group Box";

            // Create and configure pictureBox1
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = global::DemoWindowApp.Properties.Resources.movieimg; // Replace with your image resource name
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(283, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabStop = false;

            // Create and configure labels and buttons
            Label newLabel1 = new Label();
            newLabel1.Text = "Black panther";
            newLabel1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            newLabel1.Location = new System.Drawing.Point(302, 18);

            Label newLabel2 = new Label();
            newLabel2.Text = "13/08/2023 - 01:30pm to 4:00pm";
            newLabel2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            newLabel2.Location = new System.Drawing.Point(305, 80);

            Label newLabel3 = new Label();
            newLabel3.Text = "Available seat : 28";
            newLabel3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            newLabel3.Location = new System.Drawing.Point(305, 115);

            Button newButton = new Button();
            newButton.Text = "Book now";
            newButton.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            newButton.Location = new System.Drawing.Point(867, 48);

            // Update the top position for the next GroupBox
            nextGroupBoxTop += newGroupBox.Height + 10;

            // Add controls to the new GroupBox
            newGroupBox.Controls.Add(pictureBox1);
            newGroupBox.Controls.Add(newLabel1);
            newGroupBox.Controls.Add(newLabel2);
            newGroupBox.Controls.Add(newLabel3);
            newGroupBox.Controls.Add(newButton);
        }




    }
}
