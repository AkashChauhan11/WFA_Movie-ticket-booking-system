namespace DemoWindowApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.frontRowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.midRowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox91 = new System.Windows.Forms.PictureBox();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTotalSelSeat = new System.Windows.Forms.Label();
            this.lblSelectedSeats = new System.Windows.Forms.Label();
            this.lastRowLayout = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(292, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCREEN 1";
            // 
            // frontRowLayout
            // 
            this.frontRowLayout.Location = new System.Drawing.Point(57, 118);
            this.frontRowLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frontRowLayout.Name = "frontRowLayout";
            this.frontRowLayout.Size = new System.Drawing.Size(712, 130);
            this.frontRowLayout.TabIndex = 2;
            this.frontRowLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // midRowLayout
            // 
            this.midRowLayout.Location = new System.Drawing.Point(57, 268);
            this.midRowLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.midRowLayout.Name = "midRowLayout";
            this.midRowLayout.Size = new System.Drawing.Size(712, 262);
            this.midRowLayout.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 692);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Booking Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Movie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tickets :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seats :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(101, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox91
            // 
            this.pictureBox91.BackColor = System.Drawing.Color.Silver;
            this.pictureBox91.Location = new System.Drawing.Point(35, 476);
            this.pictureBox91.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox91.Name = "pictureBox91";
            this.pictureBox91.Size = new System.Drawing.Size(62, 42);
            this.pictureBox91.TabIndex = 10;
            this.pictureBox91.TabStop = false;
            // 
            // pictureBox92
            // 
            this.pictureBox92.BackColor = System.Drawing.Color.Lime;
            this.pictureBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox92.Location = new System.Drawing.Point(35, 539);
            this.pictureBox92.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(62, 42);
            this.pictureBox92.TabIndex = 11;
            this.pictureBox92.TabStop = false;
            // 
            // pictureBox93
            // 
            this.pictureBox93.BackColor = System.Drawing.Color.Red;
            this.pictureBox93.Location = new System.Drawing.Point(35, 600);
            this.pictureBox93.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(62, 42);
            this.pictureBox93.TabIndex = 12;
            this.pictureBox93.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Selected";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 605);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sold";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(161, 265);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 20);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "label11";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMovie);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblTotalSelSeat);
            this.panel1.Controls.Add(this.lblSelectedSeats);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox93);
            this.panel1.Controls.Add(this.pictureBox92);
            this.panel1.Controls.Add(this.pictureBox91);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(792, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 668);
            this.panel1.TabIndex = 6;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(165, 109);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(60, 20);
            this.lblMovie.TabIndex = 20;
            this.lblMovie.Text = "label11";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(165, 161);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 20);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "label11";
            // 
            // lblTotalSelSeat
            // 
            this.lblTotalSelSeat.AutoSize = true;
            this.lblTotalSelSeat.Location = new System.Drawing.Point(161, 215);
            this.lblTotalSelSeat.Name = "lblTotalSelSeat";
            this.lblTotalSelSeat.Size = new System.Drawing.Size(18, 20);
            this.lblTotalSelSeat.TabIndex = 18;
            this.lblTotalSelSeat.Text = "0";
            // 
            // lblSelectedSeats
            // 
            this.lblSelectedSeats.AutoSize = true;
            this.lblSelectedSeats.Location = new System.Drawing.Point(161, 317);
            this.lblSelectedSeats.Name = "lblSelectedSeats";
            this.lblSelectedSeats.Size = new System.Drawing.Size(60, 20);
            this.lblSelectedSeats.TabIndex = 17;
            this.lblSelectedSeats.Text = "label11";
            // 
            // lastRowLayout
            // 
            this.lastRowLayout.Location = new System.Drawing.Point(57, 566);
            this.lastRowLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastRowLayout.Name = "lastRowLayout";
            this.lastRowLayout.Size = new System.Drawing.Size(712, 114);
            this.lastRowLayout.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lastRowLayout);
            this.Controls.Add(this.midRowLayout);
            this.Controls.Add(this.frontRowLayout);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel frontRowLayout;
        private System.Windows.Forms.FlowLayoutPanel midRowLayout;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox91;
        private System.Windows.Forms.PictureBox pictureBox92;
        private System.Windows.Forms.PictureBox pictureBox93;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel lastRowLayout;
        private System.Windows.Forms.Label lblSelectedSeats;
        private System.Windows.Forms.Label lblTotalSelSeat;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblTime;
    }
}

