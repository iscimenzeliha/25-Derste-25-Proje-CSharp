﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SorguTestt
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=BonusOkul;Integrated Security=True");
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sorgu = richTextBox1.Text;
			try
			{
				SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView1.DataSource = dt;
			}
			catch
			{
				MessageBox.Show("Sorgunuzu kontrol edin.");
			}
			
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string sorgu = richTextBox1.Text;
			try
			{
	        baglanti.Open();
			SqlCommand komut=new SqlCommand(sorgu,baglanti);
			komut.ExecuteNonQuery();
			baglanti.Close();
			SqlDataAdapter da = new SqlDataAdapter("Select * from TBLOGRETMENLER", baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource= dt;
			}
			catch
			{
				MessageBox.Show("Sorgunuzu kontrol edin.");

			}


		}
	}
}
//Data Source=DESKTOP-Q6KQKGH;Initial Catalog=BonusOkul;Integrated Security=True;Trust Server Certificate=True