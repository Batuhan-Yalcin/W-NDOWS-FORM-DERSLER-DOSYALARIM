namespace WindowsFormİleDLLKullanimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayıyı Giriniz :";
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(280, 131);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(142, 20);
            this.txt_sayi1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "1. Sayıyı Giriniz :";
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(280, 172);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(142, 20);
            this.txt_sayi2.TabIndex = 1;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(168, 258);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(48, 23);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(234, 258);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(49, 23);
            this.btn_cikar.TabIndex = 2;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(305, 258);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(46, 23);
            this.btn_carp.TabIndex = 2;
            this.btn_carp.Text = "X";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(373, 258);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(49, 23);
            this.btn_bol.TabIndex = 2;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sonuç :";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(277, 221);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(13, 13);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 351);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.txt_sayi1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

