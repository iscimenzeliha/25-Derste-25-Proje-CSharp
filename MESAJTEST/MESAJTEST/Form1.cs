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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=Test;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select * from TBLKISILER WHERE NUMARA=@P1 AND SIFRE=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P2",textBox1.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 FRM=new Form2();
                FRM.numara = maskedTextBox1.Text;
                FRM.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
            baglanti.Close();
        }
    }
}
