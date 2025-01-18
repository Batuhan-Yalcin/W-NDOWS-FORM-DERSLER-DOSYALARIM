using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormlaraGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bizim formumuz çalıştırıldığı zaman 
            // Bu metot çalışır..

            lbl_deger.Text = "Batuhan";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
