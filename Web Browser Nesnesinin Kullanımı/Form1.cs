using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser_Nesnesinin_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }

        private void btn_İleri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
