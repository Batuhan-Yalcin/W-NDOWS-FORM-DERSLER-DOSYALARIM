using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDersteİslenenKonular
{
    public partial class Form1 : Form
    {
        int i = 0;
        string[] dizi = new string[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if ( i < 10)
            {
                dizi[i] = txt_veri.Text;
                verilerList.Items.Add(dizi[i]);
                i++;
                txt_veri.Clear();
                txt_veri.Focus();
            }
        }
    }
}
