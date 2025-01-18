namespace PictureBoxKullanimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(1, 176);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(265, 31);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Resim Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_giris.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btn_giris.Location = new System.Drawing.Point(314, 406);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(150, 32);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_sifre.ForeColor = System.Drawing.Color.Gold;
            this.txt_sifre.Location = new System.Drawing.Point(326, 356);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(138, 20);
            this.txt_sifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // txt_kAdi
            // 
            this.txt_kAdi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_kAdi.ForeColor = System.Drawing.Color.Gold;
            this.txt_kAdi.Location = new System.Drawing.Point(326, 313);
            this.txt_kAdi.Name = "txt_kAdi";
            this.txt_kAdi.Size = new System.Drawing.Size(138, 20);
            this.txt_kAdi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(531, 486);
            this.Controls.Add(this.txt_kAdi);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kAdi;
    }
}

