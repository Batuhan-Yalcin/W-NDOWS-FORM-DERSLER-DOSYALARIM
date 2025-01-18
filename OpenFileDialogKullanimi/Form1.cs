using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialogKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            string resimYolu = openFileDialog.FileName; // seçmiş olduğum resmin dosya yolunu verir.

            pictureBox1.Image = Image.FromFile(resimYolu); // resim yolundan gelen resmi yakala ekrana ver.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Başarıyla Eklendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            for(int i = 0; i<groupBox1.Controls.Count; i++) // Kayıt eklendikten sonra verileri kullanıcının ekranından siler.
            {
                if(groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is RichTextBox)
                {
                    groupBox1.Controls[i].Text= string.Empty;
                }
            }

        }
    }
}
