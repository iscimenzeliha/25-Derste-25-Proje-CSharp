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

namespace Not_Kayıt_Sistemi
{
    public partial class frmogretmendetay : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=DbNotKayıt;Integrated Security=True");

        public frmogretmendetay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmogretmendetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) VALUES (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", mskno.Text);
            komut.Parameters.AddWithValue("@P2", txtad.Text);
            komut.Parameters.AddWithValue("@P3", txtsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskno.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txts1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txts2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txts3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            double ort, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txts1.Text);
            s2 = Convert.ToDouble(txts2.Text);
            s3 = Convert.ToDouble(txts3.Text);
            ort = (s1 + s2 + s3) / 3;
            lblort.Text = ort.ToString();

            if (ort >= 50)
            {
                durum = "true";
            }
            else
            {
                durum = "false";
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update TBLDERS set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@S4,DURUM=@S5 WHERE OGRNUMARA=@S6", baglanti);
            komut1.Parameters.AddWithValue("@P1", txts1.Text);
            komut1.Parameters.AddWithValue("@P2", txts2.Text);
            komut1.Parameters.AddWithValue("@P3", txts3.Text);
            komut1.Parameters.AddWithValue("@S4", decimal.Parse(lblort.Text));
            komut1.Parameters.AddWithValue("@S5", durum);
            komut1.Parameters.AddWithValue("@S6", mskno.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

        }
    }
}
