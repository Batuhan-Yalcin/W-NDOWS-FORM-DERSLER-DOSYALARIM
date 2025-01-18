using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matematikİslemleri; // Bu benim yazdığım kütüphane.

namespace WindowsFormİleDLLKullanimi
{
    public partial class Form1 : Form
    {
        Matematik matematik = new Matematik(); // Matematik classımdan obje oluşturdum.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);    
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int toplam = matematik.topla(sayi1,sayi2);

            lbl_sonuc.Text = toplam.ToString();

        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int cikarmaSonuc = matematik.cikar(sayi1,sayi2);

            lbl_sonuc.Text = cikarmaSonuc.ToString();

        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = int.Parse(txt_sayi2.Text);

            int carpmaSonuc = matematik.carp(sayi1,sayi2);

            lbl_sonuc.Text = carpmaSonuc.ToString();
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            double sayi1 = int.Parse(txt_sayi1.Text);
            double sayi2 = int.Parse(txt_sayi2.Text);

            double bolmeSonuc = matematik.bol(sayi1,sayi2);

            lbl_sonuc.Text = bolmeSonuc.ToString();
        }
    }
}
