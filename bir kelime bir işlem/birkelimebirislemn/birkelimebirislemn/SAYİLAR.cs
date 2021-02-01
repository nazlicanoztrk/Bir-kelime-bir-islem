using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birkelimebirislemn
{
    public partial class SAYİLAR : Form
    {
        public SAYİLAR()
        {
            InitializeComponent();
        }
        Random Rastgele = new Random();
        int sayisayac = 0;

        private void btnsayigetir_Click(object sender, EventArgs e)
        {
            sayisayac++;
            string deger1, deger2, deger3, deger4, deger5;
            int deger6, deger7;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int sayilar;

            if (sayisayac == 1)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger1 = (dizi2[sayilar]);
                btnsayi1.Text = deger1.ToString();
                btnsayi1.Visible = true;
            }
            if (sayisayac == 2)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger2 = (dizi2[sayilar]);
                btnsayi2.Text = deger2.ToString();
                btnsayi2.Visible = true;
            }
            if (sayisayac == 3)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger3 = (dizi2[sayilar]);
                btnsayi3.Text = deger3.ToString();
                btnsayi3.Visible = true;
            }
            if (sayisayac == 4)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger4 = (dizi2[sayilar]);
                btnsayi4.Text = deger4.ToString();
                btnsayi4.Visible = true;
            }
            if (sayisayac == 5)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger5 = (dizi2[sayilar]);
                btnsayi5.Text = deger5.ToString();
                btnsayi5.Visible = true;
            }
            if (sayisayac == 6)
            {
                deger6 = Rastgele.Next(10, 99);

                btnsayi6.Text = deger6.ToString();
                btnsayi6.Visible = true;
            }
            if (sayisayac == 7)
            {
                deger7 = Rastgele.Next(100, 999);
                btnsayi7.Text = deger7.ToString();
                btnsayi7.Visible = true;
                btnesittir.Visible = true;
            }

        }

        List<int> list = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8 });


        private void btnyenioyun1_Click(object sender, EventArgs e)
        {
            sayisayac = 0;
            btnsayi1.Visible = false;
            btnsayi2.Visible = false;
            btnsayi3.Visible = false;
            btnsayi4.Visible = false;
            btnsayi5.Visible = false;
            btnsayi6.Visible = false;
            btnsayi7.Visible = false;
        }
        private void hesapla()
        {
            int sayi1 = Convert.ToInt32(btnsayi1.Text.ToString());
            int sayi2 = Convert.ToInt32(btnsayi2.Text.ToString());
            int sayi3 = Convert.ToInt32(btnsayi3.Text.ToString());
            int sayi4 = Convert.ToInt32(btnsayi4.Text.ToString());
            int sayi5 = Convert.ToInt32(btnsayi5.Text.ToString());
            int sayi6 = Convert.ToInt32(btnsayi6.Text.ToString());
            int sayi7 = Convert.ToInt32(btnsayi7.Text.ToString());
            int sayi8 = Convert.ToInt32(btnsayi9.Text.ToString());


            int[] sayilar1 = { sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8 };

            List<int> list = new List<int>(new[] { sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8 });
            void btnhesapla_Click(object sender, EventArgs e)
            {
                try
                {
                    hesapla();
                }
                catch
                {
                    MessageBox.Show("First, don't leave the boxes empty");
                }
            }


        }
    }
}
