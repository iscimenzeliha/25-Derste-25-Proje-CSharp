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

namespace BankaTest
{
	public partial class Form2 : Form
	{
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=DbBankaTest;Integrated Security=True");

		public Form2()
		{
			InitializeComponent();
		}
		public string hesap;
		private void Form2_Load(object sender, EventArgs e)
		{
			lblhesap.Text = hesap;
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TBLKISILER WHERE HESAPNO=@P1",baglanti);
			komut.Parameters.AddWithValue("@P1", hesap);
			SqlDataReader dr=komut.ExecuteReader();
			while (dr.Read())
			{
				lbladsoyad.Text = dr[1] + " " + dr[2];
				lbltc.Text = dr[3].ToString();
				lbltel.Text = dr[4].ToString();
			}
			baglanti.Close();
		}

		private void BTNGONDER_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("update TBLHESAP SET BAKIYE=BAKIYE+@P1 WHERE HESAPNO=@P2", baglanti);
			komut.Parameters.AddWithValue("@P1",decimal.Parse(TXTTUTAR.Text));
			komut.Parameters.AddWithValue("@P2",MSKHESAP.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();


			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("update TBLHESAP SET BAKIYE=BAKIYE-@k1 WHERE HESAPNO=@k2", baglanti);
			komut2.Parameters.AddWithValue("@k1", decimal.Parse(TXTTUTAR.Text));
			komut2.Parameters.AddWithValue("@k2",hesap);
			komut2.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("İşlem Gerçekleşti.");

		}
	}
	
}
