using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Excel_Test
{
	public partial class Form1 : Form
	{
		OleDbConnection baglanti=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus\Desktop\09134154_2017_2018.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES"";");
		public Form1()
		{
			InitializeComponent();
		}

		void listele()
		{
			baglanti.Open();
			OleDbDataAdapter dr=new OleDbDataAdapter("select * from [Sayfa1$]",baglanti);
			DataTable dt=new DataTable();
			dr.Fill(dt);
			dataGridView1.DataSource = dt;
			baglanti.Close();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			listele();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			OleDbCommand komut = new OleDbCommand("insert into [Sayfa1$] ([ADI-SOYADI],[PROGRAM ADI],ÜNİVERSİTE) VALUES (@P1,@P2,@P3)", baglanti);
			komut.Parameters.AddWithValue("@P1", textBox1.Text);
			komut.Parameters.AddWithValue("@P2", textBox2.Text);
			komut.Parameters.AddWithValue("@P3", textBox3.Text);
			komut.ExecuteNonQuery();
			baglanti.Close() ;
			MessageBox.Show("Kişi eklendi");
			listele();
		}
	}
}
