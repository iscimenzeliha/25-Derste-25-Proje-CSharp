﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplık_Test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		KitapVT vtsinif=new KitapVT();
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = vtsinif.Liste();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Kitap ktpsinif=new Kitap();
			ktpsinif.ADI=textBox1.Text;
			ktpsinif.YAZARI=textBox2.Text;
			vtsinif.KitapEkle(ktpsinif);
			MessageBox.Show("Kitap Eklendi");
		}
	}
}
