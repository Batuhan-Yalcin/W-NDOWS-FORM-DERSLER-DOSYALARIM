using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void btn_ekle_Click(object sender, EventArgs e)
            {
                pictureBox1.Image = Image.FromFile("C://39okcu.png");
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";

           kullaniciadi = txt_kAdi.Text;
            sifre = txt_sifre.Text;

            if (kullaniciadi.ToLower() == "batuhan" & sifre == "1907")// To lover metodu = BATUHAN Yazsamda girer batuhan yazsamda büyük küçük harf
                                                                       // hassasiyetini ortadan kaldırır.
            {
                MessageBox.Show("Başarılı Bir Şekilde Giriş Yaptınız.", "Yetki = Admin");
            }

            else
            {
                MessageBox.Show("Yanlış Kullanıcı adı veya şifre.", "Bilgilendirme");
            }
                

        }
    }
}
