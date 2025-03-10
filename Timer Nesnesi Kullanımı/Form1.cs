﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Nesnesi_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 20;

        private void btn_Basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // zamanlamayı aktif eder.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1 saniye 1 çalışacak kısım burasıdır.

            if (sayi >=0)
            {
                lbl_deger.Text = sayi.ToString();
                sayi--;
            }
            else
            {
                timer1.Enabled=false;   
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString();
            lbl_dakika.Text = DateTime.Now.Minute.ToString();
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }
    }
}
