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

	public partial class Form1 : Form
	{
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=DbBankaTest;Integrated Security=True");

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void LNKKAYIT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form3 frm=new Form3();
			frm.Show();
		}

		private void BTNGİRİS_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TBLKISILER WHERE HESAPNO=@P1 AND SİFRE=@P2", baglanti);
			komut.Parameters.AddWithValue("@P1",MSKHESAP.Text);
			komut.Parameters.AddWithValue("@P2",TXTSİFRE.Text);
			SqlDataReader dr=komut.ExecuteReader();
			if(dr.Read()) { 
			Form2 fr=new Form2();
				fr.hesap=MSKHESAP.Text;
				fr.Show();
			}
			else
				{
				MessageBox.Show("Hatali Bilgi");

			}
			baglanti.Close();
		}
	}
}
