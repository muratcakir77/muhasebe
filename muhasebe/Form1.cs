using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe_uygulaması._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] personeller;
        int[] maaslar;

        private void button1_Click(object sender, EventArgs e)
        {

            string aranan = tbPersonelAra.Text;
            bool bulundu = false;

            for (int i = 0; i < personeller.Length; i++)
            {

                if (aranan == personeller[i])
                {
                    bulundu = true;
                    lbGoster.SelectedIndex = i;
                    break;
                }


            }

            if (bulundu)
            {
                MessageBox.Show("Personel Bulundu.");
            }
            else
            {
                MessageBox.Show("Personel Bulunamadı.");
            }

            tbPersonelAra.Clear();

        }

      

        private void btnToplamMaas_Click(object sender, EventArgs e)
        {
            int toplamMaas = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                /*toplamMaas += maaslar[i];*/
                toplamMaas = toplamMaas + maaslar[i];
            }
            lblSonuc.Text = "Listedeki Toplam Maaş : " + toplamMaas.ToString();

        }

        private void btnOlusturListele_Click(object sender, EventArgs e)
        {
            lbGoster.Items.Clear();
            personeller = new string[] { "Murat", "Aydanur", "Sevil", "Yelda", "Ahmet" };
            maaslar = new int[] { 6000, 7000, 4200, 7900, 9500 };

            for (int i = 0; i < personeller.Length; i++)
            {

                lbGoster.Items.Add(personeller[i] + "\t" + maaslar[i]);

            }

        }


        private void btnListeTemizle_Click(object sender, EventArgs e)
        {
            lbGoster.Items.Clear();
        }

        private void btnToplamPersonel_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            for (int i = 0; i < personeller.Length; i++)
            {
                sayac = sayac + 1;
            }
            lblSonuc.Text = "Sonuç : " + sayac.ToString();

            lblSonuc.Text = "Toplam Personel Sayısı : " + personeller.Length;

        }

        private void btnDusukMaas_Click(object sender, EventArgs e)
        {
            int min;
            min = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] < min)
                {
                    min = maaslar[i];
                }
                lblSonuc.Text = "En Düşük Maaş : " + min.ToString();
            }

        }

        private void btnYuksekMaasPers_Click(object sender, EventArgs e)
        {
            /*int max;
string maxpersonel="";
max = maaslar[0];
for(int i = 0; i < maaslar.Length; i++)
{
    if (maaslar[i] > max)
    {
        max = maaslar[i];
        maxpersonel = personeller[i];
    }


}
lblSonuc.Text = "En Yüksek Maaşı Alan Personel : " + maxpersonel;*/


            int max;
            int maxIndex = 0;
            max = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] > max)
                {
                    max = maaslar[i];
                    maxIndex = i;
                }


            }
            lblSonuc.Text = "En Yüksek Maaşı Alan Personel : " + personeller[maxIndex];

        }

        private void btn4BindenAz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] < 4000)
                {
                    lbGoster.Items.Add(personeller[i] + ">>" + maaslar[i]);
                }
            }


        }

        private void bnt4Bin8Bin_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            for (int i = 0; i < maaslar.Length; i++)
            {
                if ((maaslar[i] >= 4000) && (maaslar[i] <= 8000))
                {
                    sayac = sayac + 1;
                }
                lblSonuc.Text = "Maaşı 4000 - 8000 Arasında Olan Personel Sayısı : " + sayac.ToString();
            }

        }

        private void btn400Arttır_Click(object sender, EventArgs e)
        {
            lbGoster.Items.Clear();
            maaslar[2] += 400;

            for (int i = 0; i < personeller.Length; i++)
            {
                lbGoster.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }


        }

        private void btnSonPersonel_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "Listedeki Son Personelin Adı : " + personeller[4];
        }
    }
}