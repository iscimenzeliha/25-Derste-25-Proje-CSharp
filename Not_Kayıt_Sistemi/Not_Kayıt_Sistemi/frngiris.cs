using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayıt_Sistemi
{
    public partial class frngiris : Form
    {
        public frngiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmogrencıdetay fr=new frmogrencıdetay();
            fr.numara=maskedTextBox1.Text;
            fr.Show();
            this.Hide();
        }

        private void frngiris_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text == "1111")
            {
                frmogretmendetay frr = new frmogretmendetay();
                frr.Show();
                this.Hide();
            }
        }

      
    }
}
