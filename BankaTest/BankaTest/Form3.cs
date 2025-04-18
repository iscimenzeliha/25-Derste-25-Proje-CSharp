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


namespace BankaTest
{

	public partial class Form3 : Form
	{
		SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=DbBankaTest;Integrated Security=True");
		public Form3()
		{
			InitializeComponent();
		}

		private void BTNKAYDET_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand KOMUT = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SİFRE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
			KOMUT.Parameters.AddWithValue("@P1",TXTAD.Text);
			KOMUT.Parameters.AddWithValue("@P2",TXTSOYAD.Text);
			KOMUT.Parameters.AddWithValue("@P3",MSKTC.Text);
			KOMUT.Parameters.AddWithValue("@P4",MSKTEL.Text);
			KOMUT.Parameters.AddWithValue("@P5",MSKHESAP.Text);
			KOMUT.Parameters.AddWithValue("@P6",TXTSİFRE.Text);
			KOMUT.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Müşteri Bilgileri Kaydedildi.");
		}

		private void BTNHESAPNO_Click(object sender, EventArgs e)
		{
			Random rastgele=new Random();
			int sayi = rastgele.Next(100000, 1000000);
			MSKHESAP.Text = sayi.ToString();

		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}
	}
}
