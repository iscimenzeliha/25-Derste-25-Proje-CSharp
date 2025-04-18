using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var dosya = new XmlDocument();
            dosya.Load(bugun);

            string dolaralis = dosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LBLDALIŞ.Text= dolaralis.ToString();

            string dolarsatis = dosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LBLDSATİS.Text = dolarsatis.ToString();

            string euroalis = dosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LBLEALIS.Text = euroalis.ToString();

            string eurosatis = dosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LBLESATİS.Text = eurosatis.ToString();
        }

        private void BTNDALIS_Click(object sender, EventArgs e)
        {
            TXTKUR.Text = LBLDALIŞ.Text;
        }

        private void BTNDSATIS_Click(object sender, EventArgs e)
        {
            TXTKUR.Text = LBLDSATİS.Text;

        }

        private void BTNEALIS_Click(object sender, EventArgs e)
        {
            TXTKUR.Text = LBLEALIS.Text;

        }

        private void BTNESATIS_Click(object sender, EventArgs e)
        {
            TXTKUR.Text = LBLESATİS.Text;

        }

        private void BTNSATISYAP_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur=Convert.ToDouble(TXTKUR.Text);
            miktar=Convert.ToDouble(TXTMİKTAR.Text);
            tutar = kur * miktar;
            TXTTUTAR.Text=tutar.ToString();
        }

        private void TXTKUR_TextChanged(object sender, EventArgs e)
        {
            TXTKUR.Text = TXTKUR.Text.Replace(".", ",");
        }

        private void İSLEM2_Click(object sender, EventArgs e)
        {
          double kur = Convert.ToDouble(TXTKUR.Text);
         int miktar = Convert.ToInt32(TXTMİKTAR.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            TXTTUTAR.Text = tutar.ToString();
            int kalan;
            kalan = miktar % tutar;
            TXTKALAN.Text = kalan.ToString();   

        }
    }
}
