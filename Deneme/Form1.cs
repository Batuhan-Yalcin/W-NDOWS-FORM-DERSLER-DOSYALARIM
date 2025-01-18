using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            litsbox_eklenen.Items.Add(txt_ekle.Text);
            MessageBox.Show("Veri Başarıyla Eklendi");
        }

        private void txt_ekle_TextChanged(object sender, EventArgs e)
            {

          
            }

        private void litsbox_eklenen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
      }
    }

