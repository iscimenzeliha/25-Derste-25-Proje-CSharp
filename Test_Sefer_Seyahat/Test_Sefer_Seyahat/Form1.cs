using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Sefer_Seyahat
{
	public partial class Form1 : Form
	{
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=TestYolcuBilet;Integrated Security=True");
		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btn9_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "9";

		}

		void listele()
		{
			SqlDataAdapter dr = new SqlDataAdapter("select * from TBLSEFERBİLGİ", baglanti);
			DataTable dt = new DataTable();
			dr.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		private void button1_Click(object sender, EventArgs e)
		{

			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLSEFERBİLGİ (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
			komut.Parameters.AddWithValue("@P1", TXTKALKIS.Text);
			komut.Parameters.AddWithValue("@P2", TXTVARIS.Text);
			komut.Parameters.AddWithValue("@P3", MSKTARIH.Text);
			komut.Parameters.AddWithValue("@P4", MSKSAAT.Text);
			komut.Parameters.AddWithValue("@P5", MSKKAPTAN.Text);
			komut.Parameters.AddWithValue("@P6", TXTFIYAT.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Sefer Kaydedildi.");
			listele();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}

		private void BTNKAYDET_Click(object sender, EventArgs e)
		{
			
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLYOLCULAR (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)",baglanti);
			komut.Parameters.AddWithValue("@P1", TXTAD.Text);
			komut.Parameters.AddWithValue("@P2", TXTSOYAD.Text);
			komut.Parameters.AddWithValue("@P3", MSKTEL.Text);
			komut.Parameters.AddWithValue("@P4", MSKTC.Text);
			komut.Parameters.AddWithValue("@P5", CMBCINSIYET.Text);
			komut.Parameters.AddWithValue("@P6", TXTMAIL.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Yolcu Kaydedildi.");

		}

		private void btnkaptan_Click(object sender, EventArgs e)
		{

			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) VALUES (@P1,@P2,@P3)", baglanti);
			komut.Parameters.AddWithValue("@P1", txtkno.Text);
			komut.Parameters.AddWithValue("@P2", txtadsoyad.Text);
			komut.Parameters.AddWithValue("@P3", mskktel.Text);			
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kaptan Kaydedildi.");

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			txtsefernoo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "2";

		}

		private void btn3_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "3";

		}

		private void btn4_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "4";

		}

		private void btn5_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "5";

		}

		private void btn6_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "6";

		}

		private void btn7_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "7";

		}

		private void btn8_Click(object sender, EventArgs e)
		{
			TXTKOLTUKNO.Text = "8";

		}

		private void btnrezervasyon_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) VALUES (@P1,@P2,@P3)", baglanti);
			komut.Parameters.AddWithValue("@P1", txtsefernoo.Text);
			komut.Parameters.AddWithValue("@P2", msktcc.Text);
			komut.Parameters.AddWithValue("@P3", TXTKOLTUKNO.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Rezervasyon Yapıldı.");
		}
	}
}
