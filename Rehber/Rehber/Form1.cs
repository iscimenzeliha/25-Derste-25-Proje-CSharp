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

namespace Rehber
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=Rehber;Integrated Security=True;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM KISILER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            TXTID.Text = "";
            TXTAD.Text = "";
            TXTSOYAD.Text="";
            TXTMAIL.Text = "";
            MSKTEL.Text = "";
            TXTAD.Focus();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BTNTEMIZLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            temizle();
            baglanti.Close();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("INSERT INTO KISILER (AD,SOYAD,TELEFON,MAIL)  VALUES (@P1,@P2,@P3,@P4)",baglanti);
            komut.Parameters.AddWithValue("@P1",TXTAD.Text);
            komut.Parameters.AddWithValue("@P2",TXTSOYAD.Text);
            komut.Parameters.AddWithValue("@P3",MSKTEL.Text);
            komut.Parameters.AddWithValue("@P4",TXTMAIL.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KİŞİ SİSTEME KAYDEDİLDİ");
            listele();
            temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TXTID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TXTSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MSKTEL.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TXTMAIL.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete  from KISILER WHERE ID=" + TXTID.Text, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KİŞİ SİLİNDİ");
            listele();
            temizle();
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update KISILER SET AD=@P1,SOYAD=@P2,TELEFON=@P3,MAIL=@P4 WHERE ID=@P5", baglanti);
            komut1.Parameters.AddWithValue("@P1", TXTAD.Text);
            komut1.Parameters.AddWithValue("@P2", TXTSOYAD.Text);
            komut1.Parameters.AddWithValue("@P3", MSKTEL.Text);
            komut1.Parameters.AddWithValue("@P4", TXTMAIL.Text);
            komut1.Parameters.AddWithValue("@P5", TXTID.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KİŞİ  GÜNCELLENDİ");
            listele();
            temizle();
           
        }
    }
}
