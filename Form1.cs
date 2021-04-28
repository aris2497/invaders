﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invaders
{
    public partial class Form1 : Form
    {
        private Random rand;
        private Rectangle rect;
        private Stars stars;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            rect = Screen.GetBounds(this);
            rand = new Random();
            stars = new Stars(rect, rand);
            g = this.CreateGraphics();
            this.BackColor = Color.Black;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            stars.Draw(g);
        }
    }
}
