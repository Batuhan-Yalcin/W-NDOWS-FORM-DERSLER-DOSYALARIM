using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaFormİleCalismak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_giris_Click(object sender, EventArgs e)
        {

            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_kAdi.Text;
            sifre = txt_sifre.Text;

            if (kullaniciAdi == "Batuhan" && sifre == "1907")
            {
               // İF BLOĞU DOĞRU İSE FARKLI FORMA YÖNLENDİRECEĞİZ.
               anasayfa anasayfa  = new anasayfa();
                anasayfa.lbl_deger.Text = kullaniciAdi.ToUpper(); // 2. formdaki lbl_deger isimli labela sisteme giriş yapan kullanıcının
                // kullanıcı adını Büyük harflerle Yaz demek. toUpper Büyük harfle yazar.
                anasayfa.Show(); // bu yaptığımız işlemi anasayfa da show ettik yani gösterdik.
                this.Hide(); /// hide saklamak demek 
                //this anlamı şuanda üzerinde bulunmuş olduğum form anlamına gelir
            }
            else
            {
                MessageBox.Show("Hatalı Giriş","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
