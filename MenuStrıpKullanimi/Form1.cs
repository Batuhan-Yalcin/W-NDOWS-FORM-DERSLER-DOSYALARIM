using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrıpKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokSayfasınaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokForm stock = new stokForm();
            stock.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
