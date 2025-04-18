using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Petrol
{
	public partial class Form1 : Form
	{
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=TestBenzin;Integrated Security=True");

		public Form1()
		{
			InitializeComponent();
		}


		void listele()
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TBLBENZIN WHERE PETROLTUR='Kurşunsuz95'", baglanti);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				LBL95.Text = dr[3].ToString();
				progressBar1.Value = int.Parse(dr[4].ToString());
				lblk95.Text = dr[4].ToString();

			}
			baglanti.Close();
			baglanti.Open();
			SqlCommand komut1 = new SqlCommand("select * from TBLBENZIN WHERE PETROLTUR='Kurşunsuz97'", baglanti);
			SqlDataReader dr1 = komut1.ExecuteReader();
			while (dr1.Read())
			{
				LBL97.Text = dr1[3].ToString();
				progressBar2.Value = int.Parse(dr1[4].ToString());
				lblk97.Text = dr1[4].ToString();


			}
			baglanti.Close();
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("select * from TBLBENZIN WHERE PETROLTUR='EuroDizel'", baglanti);
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				LBLED.Text = dr2[3].ToString();
				progressBar3.Value = int.Parse(dr2[4].ToString());
				lbledd.Text = dr2[4].ToString();


			}
			baglanti.Close();
			baglanti.Open();
			SqlCommand komut3 = new SqlCommand("select * from TBLBENZIN WHERE PETROLTUR='YeniProDizel'", baglanti);
			SqlDataReader dr3 = komut3.ExecuteReader();
			while (dr3.Read())
			{
				LBLPD.Text = dr3[3].ToString();
				progressBar4.Value = int.Parse(dr3[4].ToString());
				lblpdd.Text = dr3[4].ToString();


			}
			baglanti.Close();
			baglanti.Open();
			SqlCommand komut4 = new SqlCommand("select * from TBLBENZIN WHERE PETROLTUR='Gaz'", baglanti);
			SqlDataReader dr4 = komut4.ExecuteReader();
			while (dr4.Read())
			{
				LBLGAZ.Text = dr4[3].ToString();
				progressBar5.Value = int.Parse(dr4[4].ToString());
				lblg.Text = dr4[4].ToString();


			}
			baglanti.Close();
			baglanti.Open();
			SqlCommand komut7 = new SqlCommand("select * from TBLKASA", baglanti);
			SqlDataReader dr5 = komut7.ExecuteReader();
			while (dr5.Read())
			{
				LBLKASA2.Text =dr5[0].ToString();
			}
			baglanti.Close();
		}
		
			
		
		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			double k95, litre, tutar;
			k95=Convert.ToDouble(LBL95.Text);
			litre=Convert.ToDouble(numericUpDown1.Value);
			tutar=k95*litre;
			txt95.Text=tutar.ToString();
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			double k97, litre, tutar;
			k97 = Convert.ToDouble(LBL97.Text);
			litre = Convert.ToDouble(numericUpDown2.Value);
			tutar = k97 * litre;
			txt97.Text = tutar.ToString();
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{

			double ed, litre, tutar;
			ed = Convert.ToDouble(LBLED.Text);
			litre = Convert.ToDouble(numericUpDown3.Value);
			tutar = ed * litre;
			txted.Text = tutar.ToString();
		}

		private void numericUpDown4_ValueChanged(object sender, EventArgs e)
		{
			double pd, litre, tutar;
			pd = Convert.ToDouble(LBLPD.Text);
			litre = Convert.ToDouble(numericUpDown4.Value);
			tutar = pd * litre;
			txtpd.Text = tutar.ToString();
		}

		private void numericUpDown5_ValueChanged(object sender, EventArgs e)
		{
			double g, litre, tutar;
			g = Convert.ToDouble(LBLGAZ.Text);
			litre = Convert.ToDouble(numericUpDown5.Value);
			tutar = g * litre;
			txtgaz.Text = tutar.ToString();
		}

		private void btndepodoldur_Click(object sender, EventArgs e)
		{
			if(numericUpDown1.Value != 0)
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
				komut.Parameters.AddWithValue("@P1", TXTPLAKA.Text);
				komut.Parameters.AddWithValue("@P2", "KURŞUNSUZ 95");
				komut.Parameters.AddWithValue("@P3", numericUpDown1.Value);
				komut.Parameters.AddWithValue("@P4", decimal.Parse(txt95.Text));
				komut.ExecuteNonQuery();
				baglanti.Close();

				baglanti.Open();
				SqlCommand komut2 = new SqlCommand("UPDATE TBLKASA SET MIKTAR=MIKTAR+@P7", baglanti);
				komut2.Parameters.AddWithValue("@P7",decimal.Parse(txt95.Text));
			
				komut2.ExecuteNonQuery();
				baglanti.Close();

				baglanti.Open();
				SqlCommand komut3 = new SqlCommand("UPDATE TBLBENZIN SET STOK=STOK-@P1 WHERE PETROLTUR='KURŞUNSUZ95'",baglanti);
				komut3.Parameters.AddWithValue("@P1", numericUpDown1.Value);
				komut3.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Satış Yapıldı.");
				listele();
			}
		}
	}
}
