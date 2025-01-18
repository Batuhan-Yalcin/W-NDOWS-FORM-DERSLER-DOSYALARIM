namespace Timer_Nesnesi_Kullanımı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_deger = new System.Windows.Forms.Label();
            this.btn_Basla = new System.Windows.Forms.Button();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şuan ki değer :";
            // 
            // lbl_deger
            // 
            this.lbl_deger.AutoSize = true;
            this.lbl_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deger.Location = new System.Drawing.Point(200, 33);
            this.lbl_deger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_deger.Name = "lbl_deger";
            this.lbl_deger.Size = new System.Drawing.Size(27, 20);
            this.lbl_deger.TabIndex = 1;
            this.lbl_deger.Text = "20";
            // 
            // btn_Basla
            // 
            this.btn_Basla.Location = new System.Drawing.Point(54, 105);
            this.btn_Basla.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Basla.Name = "btn_Basla";
            this.btn_Basla.Size = new System.Drawing.Size(217, 55);
            this.btn_Basla.TabIndex = 2;
            this.btn_Basla.Text = "Sayacı Başlat";
            this.btn_Basla.UseVisualStyleBackColor = true;
            this.btn_Basla.Click += new System.EventHandler(this.btn_Basla_Click);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(313, 33);
            this.lbl_saat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(60, 22);
            this.lbl_saat.TabIndex = 3;
            this.lbl_saat.Text = "saat :";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(397, 33);
            this.lbl_dakika.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(80, 22);
            this.lbl_dakika.TabIndex = 3;
            this.lbl_dakika.Text = "dakika :";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(490, 33);
            this.lbl_saniye.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(68, 22);
            this.lbl_saniye.TabIndex = 3;
            this.lbl_saniye.Text = "saniye";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 189);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_Basla);
            this.Controls.Add(this.lbl_deger);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_deger;
        private System.Windows.Forms.Button btn_Basla;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer2;
    }
}

