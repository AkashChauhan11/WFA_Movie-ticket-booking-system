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

        private void button2_Click(object sender, EventArgs e)
        {
            AddGroupBox();
        }

        private System.Windows.Forms.GroupBox AddGroupBox()
        {
            GroupBox groupBox=new System.Windows.Forms.GroupBox();
            this.Controls.Add(groupBox);
            //groupBox.Name = "groupBox2";
            groupBox.Size = new System.Drawing.Size(1027, 150);
            groupBox.Top = 0;
            groupBox.Left = 0;
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "New Group Box";

            
            return groupBox;
        }

       
    }
}
