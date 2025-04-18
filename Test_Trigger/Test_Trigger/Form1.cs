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
namespace Test_Trigger
{
	public partial class Form1 : Form
	{
		SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=Test;Integrated Security=True");
		public Form1()
		{
			InitializeComponent();
		}
		void listele()
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from TBLKITAPLAR", baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		void sayac()
		{
			baglanti.Open();
			SqlCommand KOMUT1 = new SqlCommand("SELECT * FROM TBLSAYAC", baglanti);
			SqlDataReader dr= KOMUT1.ExecuteReader();
			while (dr.Read())
			{
				LBLKITAP.Text = dr[0].ToString();
			}
			baglanti.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
			sayac();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void BTNEKLE_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLKITAPLAR (AD,YAZAR,SAYFA,YAYINEVI,TUR) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
			komut.Parameters.AddWithValue("@P1", TXTAD.Text);
			komut.Parameters.AddWithValue("@P2", TXTYAZAR.Text);
			komut.Parameters.AddWithValue("@P3", TXTSAYFA.Text);
			komut.Parameters.AddWithValue("@P4", TXTYAYIN.Text);
			komut.Parameters.AddWithValue("@P5", TXTTUR.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kitap eklendi");
			listele();
			sayac();

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;

			TXTID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			TXTAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			TXTYAZAR.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			TXTSAYFA.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			TXTYAYIN.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			TXTTUR.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
		}

		private void BTNSİL_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from TBLKITAPLAR WHERE ID=@P1", baglanti);
			komut.Parameters.AddWithValue("@P1",TXTID.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kitap silindi");
			listele();
			sayac();
		}
	}
}
