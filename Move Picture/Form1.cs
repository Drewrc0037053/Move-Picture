﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 15 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 15, pictureBox1.Location.Y);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 15, pictureBox1.Location.Y);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0 )  
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 15);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 15 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 15);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 5);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 5);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
