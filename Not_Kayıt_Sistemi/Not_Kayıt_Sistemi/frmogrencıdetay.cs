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
    public partial class frmogrencıdetay : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=DbNotKayıt;Integrated Security=True");
            public frmogrencıdetay()
        {
            InitializeComponent();
        }
        public string numara;
             
        private void frmogrencıdetay_Load(object sender, EventArgs e)
        {
            lblogrno.Text=numara;
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select * from TBLDERS WHERE OGRNUMARA=@P1",baglanti);
            komut.Parameters.AddWithValue("P1", numara);
            SqlDataReader dr= komut.ExecuteReader();    
            while (dr.Read())
            {
                lbladsoyad.Text = dr[2].ToString()+" " + dr[3].ToString();
                lbls1.Text = dr[4].ToString();
                lbls2.Text = dr[5].ToString();
                lbls3.Text = dr[6].ToString();
                lblort.Text = dr[7].ToString();
                lbldurun.Text = dr[8].ToString();
            }
            baglanti.Close();

        }
    }
}
