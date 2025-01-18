﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_Nesnesi_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_göster_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, "Batuhan", "Yalçın");
            dataGridView1.Rows.Add(2, "Yakup", "uzun");
            dataGridView1.Rows.Add(3, "Şevval", "Han");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            String isim = txt_isim.Text;
            String soyisim = txt_soyisim.Text; 

            dataGridView1.Rows.Add(id, isim, soyisim);
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            MessageBox.Show("Kayıt Silindi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         String id =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyisim = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txt_id.Text = id;
            txt_isim.Text = isim;
            txt_soyisim.Text = soyisim; 
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            String isim = txt_isim.Text;
            String soyisim = txt_soyisim.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim,soyisim);
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
