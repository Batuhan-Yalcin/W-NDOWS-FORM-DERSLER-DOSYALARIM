﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgresBar_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0; // 0 dan 
            progressBar1.Maximum = 100; // 100 e kadar artsın progresbas
            progressBar1.Step = 1; // 1er 1er artsın

            progressBar1.Value += 1;


            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
            }

        }
    }
}
