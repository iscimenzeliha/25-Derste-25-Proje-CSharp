﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_nesne_hareketleri
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

        private void Form1_Load(object sender, EventArgs e)
        {
           timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 37) 
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >=821)
            {
                timer2.Stop();
                timer3.Start();
                
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >=460)
            {
                timer3.Stop();
                timer4.Start();

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 78)
            {
                timer4.Stop();
                timer1.Start();

            }
        }
    }
}
