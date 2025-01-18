using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OtomatikTiklama
{
    public partial class Form1 : Form
    {
        private bool otomatikTiklamaCalisiyor = false;
        private int tiklamaSayisi;
        private int beklemeSuresi;
        private List<Point> koordinatlar = new List<Point>
        {
            new Point(100, 100), // Örneğin, (x=100, y=100)
            new Point(200, 200), // Örneğin, (x=200, y=200)
            new Point(300, 150)  // ve daha fazlası...
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void nudBeklemeSuresi_ValueChanged(object sender, EventArgs e)
        {
            nudBeklemeSuresi.Minimum = 10; // Minimum değeri 100 ms olarak ayarla
            nudBeklemeSuresi.Maximum = 5000; // Maksimum değeri 5000 ms olarak ayarla
        }

        private void nudTiklamaSayisi_ValueChanged(object sender, EventArgs e)
        {
            nudTiklamaSayisi.Minimum = 1;
            nudTiklamaSayisi.Maximum = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // KeyPreview özelliğini true yaparak formun tuşları öncelikle algılamasını sağladık.
            this.KeyDown += new KeyEventHandler(OtomatikTiklama_KeyDown); // Forma tıklayınca ve tuş basıldığında OtomatikTiklama_KeyDown metodunu çağır.
        }

        private void OtomatikTiklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // F1 tuşuna basıldığında otomatik tıklamayı başlat
                otomatikTiklamaCalisiyor = true;
                tiklamaSayisi = (int)nudTiklamaSayisi.Value;
                beklemeSuresi = (int)nudBeklemeSuresi.Value;

                MessageBox.Show($"Otomatik tıklama başladı.\nBekleme Süresi: {beklemeSuresi} ms\nTıklama Sayısı: {tiklamaSayisi}");
                Timer timer = new Timer();
                timer.Interval = beklemeSuresi; // Tıklama aralığını bekleme süresine ayarla
                timer.Tick += (s, ev) =>
                {
                    foreach (var koordinat in koordinatlar)
                    {
                        for (int i = 0; i < tiklamaSayisi; i++)
                        {
                            SimulateClick(koordinat.X, koordinat.Y); // Mouse'u belirtilen konumda simüle et
                        }
                    }
                };
                timer.Start();
            }
            else if (e.KeyCode == Keys.F2)
            {
                // F2 tuşuna basıldığında otomatik tıklamayı durdur
                otomatikTiklamaCalisiyor = false;
                MessageBox.Show("Otomatik tıklama durduruldu.");
            }
        }

        // Otomatik tıklama işlemini gerçekleştirmek için bu metodu ekleyin
        private void SimulateClick(int x, int y)
        {
            Cursor.Position = new Point(x, y); // Kursoru belirtilen koordinata götür
            MouseEventArgs mouseEvent = new MouseEventArgs(MouseButtons.Left, 1, x, y, 0);
            this.OnMouseDown(mouseEvent); // Tıklama işlemi başlat

          

          

            this.OnMouseUp(mouseEvent); // Tıklama işlemi bitir
        }
    }
}
