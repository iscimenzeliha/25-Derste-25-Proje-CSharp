using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kelime_oyunu
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus\Desktop\dbSozluk.accdb");
        Random rast=new Random();
        int sure = 90;
        int kelime = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtıng.Text = dr[1].ToString();
                lblcevap.Text = dr[2].ToString();
                lblcevap.Text=lblcevap.Text.ToLower();
                

            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           getir();
            txtturkce.Focus();
            timer1.Start();
        }

        private void txtturkce_TextChanged(object sender, EventArgs e)
        {
            if(txtturkce.Text ==lblcevap.Text)
            {
                kelime++;
                label6.Text= kelime.ToString();
                getir();
                txtturkce.Clear();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label4.Text= sure.ToString();
            if (sure == 0)
            {
                txtturkce.Enabled = false;
                txtıng.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
