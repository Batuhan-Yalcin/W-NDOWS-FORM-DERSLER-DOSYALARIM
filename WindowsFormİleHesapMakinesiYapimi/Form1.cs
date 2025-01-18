using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormİleHesapMakinesiYapimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int sonuc = sayi1 * sayi2;

            lbl_sonuc.Text = sonuc.ToString();
            
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int sonuc = sayi1 + sayi2;

            lbl_sonuc.Text = sonuc.ToString();


        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int sonuc = sayi1 -sayi2;

            lbl_sonuc.Text = sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int sonuc = sayi1 / sayi2;

            lbl_sonuc.Text = sonuc.ToString();
        }
    }
}
