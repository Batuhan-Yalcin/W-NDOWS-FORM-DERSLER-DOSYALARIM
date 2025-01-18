using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComboBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_Gunler.Items.Add("Perşembe"); // PZT SALI ÇRŞ YI ELLE PRŞ CUMA CMT PAZAR I KOD İLE GİRDİM ITEM.ADD İLE
            combo_Gunler.Items.Add("Cuma");
            combo_Gunler.Items.Add("Cumartesi");
            combo_Gunler.Items.Add("Pazar");
            MessageBox.Show("Lütfen Randevu Almak istediğiniz 1 gün seçiniz."); // EKRANA MESAJ VERDİM.
        }

        private void btn_gunSec_Click(object sender, EventArgs e)
        {
            // selecteditem selectedindex
            // Önce secilenGun oluşturdum daha sonrasında Combo_Gunler in selected ıtem ile kullanıcının seçtiği öğeyi
            // bana string olarak yakala dedim.
            string secilenGun = combo_Gunler.SelectedItem.ToString(); 
            int secilenIndex = combo_Gunler.SelectedIndex;


            MessageBox.Show("Seçtiğiniz Gün : " + secilenGun + " " + "Seçtiğiniz İndex : " + secilenIndex);
             // daha sonrasında Kullanıcıya seçtiği günün ve seçtiğinin günün hangi index olduğunun mesajını verdim.

        }
    }
}
