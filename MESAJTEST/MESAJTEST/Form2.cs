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

namespace MESAJTEST
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=Test;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }
        public string numara;


        void gelenkutusu()
        {
            SqlDataAdapter da= new SqlDataAdapter("select * from TBLMESAJLAR WHERE ALICI="+numara,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        } 
        void gidenkutusu()
        {
            SqlDataAdapter da1= new SqlDataAdapter("select * from TBLMESAJLAR WHERE GONDEREN="+numara,baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LBLNUMARA.Text = numara;
            gelenkutusu();
            gidenkutusu();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ad,soyad  from TBLKISILER WHERE NUMARA="+numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LBLADSOYAD.Text = dr[0]+" " + dr[1];
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) VALUES (@P1,@P2,@P3,@P4)",baglanti);
            komut.Parameters.AddWithValue("@P1",numara);
            komut.Parameters.AddWithValue("@P2",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P3",textBox1.Text);
            komut.Parameters.AddWithValue("@P4",richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız gönderildi!");
            gidenkutusu();
        }
    }
}
