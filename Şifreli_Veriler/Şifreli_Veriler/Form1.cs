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

namespace Şifreli_Veriler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=Test;Integrated Security=True");
		void listele()
		{
			SqlDataAdapter da=new SqlDataAdapter("select * from TBLVERILER",baglanti);
			DataTable dt=new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		private void BTNKAYDET_Click(object sender, EventArgs e)
		{
			string ad=TXTAD.Text;
			byte[] addizi=ASCIIEncoding.ASCII.GetBytes(ad);
			string adsifre=Convert.ToBase64String(addizi);

			string soyad=TXTSOYAD.Text;
			byte[] soyaddizi=ASCIIEncoding.ASCII.GetBytes(soyad);
			string soyadsifre=Convert.ToBase64String(soyaddizi);

			string mail=TXTMAİL.Text;
			byte[] maildizi=ASCIIEncoding.ASCII.GetBytes(mail);
			string mailsifre=Convert.ToBase64String(maildizi);
			
			string sifre=TXTSİFRE.Text;
			byte[] sifredizi=ASCIIEncoding.ASCII.GetBytes(sifre);
			string sifresifre=Convert.ToBase64String(sifredizi);

			string hesapno=TXTHESAP.Text;
			byte[] hesapnodizi=ASCIIEncoding.ASCII.GetBytes(hesapno);
			string hesapnosifre=Convert.ToBase64String(hesapnodizi);

			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) VALUES (@P1,@P2,@P3,@P4,@P5)",baglanti);
			komut.Parameters.AddWithValue("@P1",adsifre);
			komut.Parameters.AddWithValue("@P2",soyadsifre);
			komut.Parameters.AddWithValue("@P3",mailsifre);
			komut.Parameters.AddWithValue("@P4",sifresifre);
			komut.Parameters.AddWithValue("@P5",hesapnosifre);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Veriler Eklendi");
		
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ad1 = TXTAD.Text;
			byte[] addizi1 = Convert.FromBase64String(ad1);
			string adsifre1 = ASCIIEncoding.ASCII.GetString(addizi1);

			string soyad1 = TXTSOYAD.Text;
			byte[] soyaddizi1 = Convert.FromBase64String(soyad1);
			string soyadsifre1 = ASCIIEncoding.ASCII.GetString(soyaddizi1);

			string mail1 = TXTMAİL.Text;
			byte[] maildizi1 = Convert.FromBase64String(mail1);
			string mailsifre1 = ASCIIEncoding.ASCII.GetString(maildizi1);

			string sifre1 = TXTSİFRE.Text;
			byte[] sifredizi1 = Convert.FromBase64String(sifre1);
			string sifresifre1 = ASCIIEncoding.ASCII.GetString(sifredizi1);

			string hesapno1 = TXTHESAP.Text;
			byte[] hesapnodizi1 = Convert.FromBase64String(hesapno1);
			string hesapnosifre1 = ASCIIEncoding.ASCII.GetString(hesapnodizi1);


			//baglanti.Open();
			//SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
			//komut.Parameters.AddWithValue("@P1", adsifre1);
			//komut.Parameters.AddWithValue("@P2", soyadsifre1);
			//komut.Parameters.AddWithValue("@P3", mailsifre1);
			//komut.Parameters.AddWithValue("@P4", sifresifre1);
			//komut.Parameters.AddWithValue("@P5", hesapnosifre1);
			//komut.ExecuteNonQuery();
			//baglanti.Close();
			//MessageBox.Show("Veriler Eklendi");
		}
	}
}
