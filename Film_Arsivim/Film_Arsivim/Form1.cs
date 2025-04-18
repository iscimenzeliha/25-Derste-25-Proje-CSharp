using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=FilmArsivim;Integrated Security=True");
        void filmler()
        {
            SqlDataAdapter da=new SqlDataAdapter("select AD,LINK FROM TBLFILMLER",baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLFILMLER (AD,KATEGORI,LINK) VALUES (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", TXTAD.Text);
            komut.Parameters.AddWithValue("@P2", TXTKATEGORI.Text);
            komut.Parameters.AddWithValue("@P3", TXTLINK.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film listenize eklendi");
            filmler();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            webBrowser1.Navigate(link);

        }

        private void BTNH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU PROJE 21 ŞUBAT 2025 TARİHİNDE SEVGİLİ MURAT YÜCEDAĞ'IN UDEMY'DE BULUNAN  'C# İLE 25 DERSTE 25 UYGULAMALI PROJE' ADLI KURSU SAYESİNDE ZELİHA İŞÇİMEN TARAFINDAN OLUŞTURULMUŞTUR ");
        }

        private void BTNCIKIS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
