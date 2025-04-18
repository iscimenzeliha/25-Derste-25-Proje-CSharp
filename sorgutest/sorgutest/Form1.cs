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

namespace sorgutest
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-Q6KQKGH;Initial Catalog=BonusOkul;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
