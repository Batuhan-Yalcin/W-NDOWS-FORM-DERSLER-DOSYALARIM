using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormİleLİSTBOXkullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("Perşembe");
            listBox2.Items.Add("Cuma");
            listBox2.Items.Add("Cumartesi");
            listBox2.Items.Add("Pazar");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string gun = txt_ekle.Text; // txt_ekle.Text: Kullanıcı, txt_ekle adlı bir metin kutusuna bir metin yazar.
            listBox2.Items.Add(gun); //  Bu metin (yani gun), listBox2 adlı bir liste kutusuna yeni bir öğe olarak eklenir.
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string silinecekGun = listBox2.SelectedItem.ToString(); //  selected ıtem seçilen öğeyi bana ver demek
            listBox2.Items.Remove(silinecekGun); // remove ile seçtiğimiz günü sil dedim.

            MessageBox.Show("Seçtiğiniz Öğe Silindi.");
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listbox count değeri : " + listBox2.Items.Count.ToString()); // Butona tıklanınca count değerini göster.
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            MessageBox.Show("Temizlendi.");
        }
    }
}
