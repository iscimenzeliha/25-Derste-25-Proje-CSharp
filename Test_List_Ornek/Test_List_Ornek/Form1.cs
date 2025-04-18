using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_List_Ornek
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<string> kisiler = new List<string>();
			kisiler.Add("Mazhar");
			kisiler.Add("Ruhsar");
			kisiler.Add("Menkıbe");
			kisiler.Add("Müfit");
			kisiler.Add("Reyhan");
			kisiler.Add("Firdevs");
			kisiler.Remove("Müfit");
			foreach (string s in kisiler)
			{
				listBox1.Items.Add(s);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<int> sayilar=new List<int>();
			sayilar.Add(45);
			sayilar.Add(74);
			sayilar.Add(25);
			sayilar.Add(33);
			sayilar.Add(22);
			sayilar.Add(15);
			sayilar.Add(39);
			foreach(int i in sayilar)
			{
				if(i%5==0)
				{
                 listBox2.Items.Add(i);
				}
				
			}
			if (sayilar.Contains(74))
			{
				MessageBox.Show("Bu sayı var");

			}
			else
			{
				MessageBox.Show("Bu sayı yok");

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			List<Kisiler> kisi = new List<Kisiler>();
			kisi.Add(new Kisiler()
			{
				ADI = "ALİ",
				SOYADI = "AYDIN",
				MESLEK = "ÖĞRETMEN"

			});
			foreach (Kisiler K in kisi)
			{
				listBox3.Items.Add(K.ADI+" "+K.SOYADI+" "+K.MESLEK);
			}
		}
	}
}
 