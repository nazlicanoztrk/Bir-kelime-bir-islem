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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random Rastgele = new Random();
        int harfsayac = 0;
        
        private void btnharfgetir_Click(object sender, EventArgs e)
        {
            harfsayac++;
            string karakter1, karakter2, karakter3, karakter4, karakter5, karakter6, karakter7, karakter8;
            int harfler;
            string[] dizi = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            if(harfsayac == 1)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter1 = (dizi[harfler]);
                btnharf1.Text = karakter1.ToString();
                btnharf1.Visible = true;
            }
            if (harfsayac == 2)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter2 = (dizi[harfler]);
                btnharf2.Text = karakter2.ToString();
                btnharf2.Visible = true;
            }
            if (harfsayac == 3)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter3 = (dizi[harfler]);
                btnharf3.Text = karakter3.ToString();
                btnharf3.Visible = true;
            }
            if (harfsayac == 4)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter4 = (dizi[harfler]);
                btnharf4.Text = karakter4.ToString();
                btnharf4.Visible = true;
            }
            if (harfsayac == 5)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter5 = (dizi[harfler]);
                btnharf5.Text = karakter5.ToString();
                btnharf5.Visible = true;
            }
            if (harfsayac == 6)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter6 = (dizi[harfler]);
                btnharf6.Text = karakter6.ToString();
                btnharf6.Visible = true;
            }
            if (harfsayac == 7)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter7 = (dizi[harfler]);
                btnharf7.Text = karakter7.ToString();
                btnharf7.Visible = true;
            }
            if (harfsayac == 8)
            {
                harfler = Rastgele.Next(0, dizi.Length);
                karakter8 = (dizi[harfler]);
                btnharf8.Text = karakter8.ToString();
                btnharf8.Visible = true;
                btnharf9.Text = "?";
                btnharf9.Visible = true;
            }


        }

        private void btnyenioyun_Click(object sender, EventArgs e)
        {

            harfsayac = 0;

            btnharf1.Visible = false;
            btnharf2.Visible = false;
            btnharf3.Visible = false;
            btnharf4.Visible = false;
            btnharf5.Visible = false;
            btnharf6.Visible = false;
            btnharf7.Visible = false;
            btnharf8.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            klavye klvye = new klavye();
            klvye.Show();
            this.Hide();
        }
    }

 
        
}
