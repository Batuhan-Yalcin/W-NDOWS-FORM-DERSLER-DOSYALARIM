using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            if (checkbox_cay.Checked ) // çaya tıklandıysa = checked ile kontrol ederiz
            {
                tutar += 2;
            }

            if (checkbox_kahve.Checked) // kahveye tıklandıysa = checked ile kontrol ederiz
            {
                tutar += 4;
            }

            if (checkbox_hamburger.Checked) // hamburgere tıklandıysa  = checked ile kontrol ederiz
            {
                tutar += 10;
            }

            if (checkbox_pizza.Checked) // pizzaya tıklandıysa = checked ile kontrol ederiz
            {
                tutar += 25;
            }

            label1.Text = tutar.ToString();

        }
    }
}
