using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxNesnesiKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının Girdiği verileri alıp veri tabanına ekleyeceğiz eklendikten sonra mesaj verdiğimizi düşünelim.
            MessageBox.Show("Kayıt Eklendi.");
            /* tabiki bu amele işi yarın 100 tane textbox olsa hepsini tek tek elle mi gireceğiz tabiki hayır :)
             
            textBox1.Text = string.Empty; // Kullanıcı Verilerini ekledikten sonra ekrandaki bilgileri silinir ve yeni kayıt ekleyebilir.
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty; 
            textBox4.Text = string.Empty;
            */

            // Asıl Yöntem 

            // yani burda i gelir label dan başlar 0. indexten label textbox mı ? hayır ozaman 1 olur 1 textbox mu evet if e girer siler 
            // böyle böyle devam eder ta ki grupboxımın içinde textbox nesnesinde veri kalmayana kadar. 

            for (int i = 0; i < groupBox1.Controls.Count; i++) // 0 dan başla grupbox nesnemin countu (sayısı) kadar dön her seferinde arttır.
            {
                if(groupBox1.Controls[i] is TextBox) // grupboxımın controls methodu içinde ki i değeri textbox sa 
                {   
                    groupBox1.Controls[i].Text = string.Empty; //textbox un içinde yazılı olan veriyi sil.
                }
            } 
            
        }
    }
}
