namespace WindowsFormİleNOTuygulamasi
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
            this.txt_birinciNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ikinciNot = new System.Windows.Forms.TextBox();
            this.btn_ortalamaHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. NOTUNUZU GİRİNİZ : ";
            // 
            // txt_birinciNot
            // 
            this.txt_birinciNot.Location = new System.Drawing.Point(196, 17);
            this.txt_birinciNot.Name = "txt_birinciNot";
            this.txt_birinciNot.Size = new System.Drawing.Size(117, 20);
            this.txt_birinciNot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. NOTUNUZU GİRİNİZ : ";
            // 
            // txt_ikinciNot
            // 
            this.txt_ikinciNot.Location = new System.Drawing.Point(196, 61);
            this.txt_ikinciNot.Multiline = true;
            this.txt_ikinciNot.Name = "txt_ikinciNot";
            this.txt_ikinciNot.Size = new System.Drawing.Size(117, 20);
            this.txt_ikinciNot.TabIndex = 1;
            // 
            // btn_ortalamaHesapla
            // 
            this.btn_ortalamaHesapla.Location = new System.Drawing.Point(15, 119);
            this.btn_ortalamaHesapla.Name = "btn_ortalamaHesapla";
            this.btn_ortalamaHesapla.Size = new System.Drawing.Size(162, 23);
            this.btn_ortalamaHesapla.TabIndex = 2;
            this.btn_ortalamaHesapla.Text = "ORTALAMAYI BUL";
            this.btn_ortalamaHesapla.UseVisualStyleBackColor = true;
            this.btn_ortalamaHesapla.Click += new System.EventHandler(this.btn_ortalamaHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(205, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ortalama : ";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(280, 127);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(15, 15);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 209);
            this.Controls.Add(this.btn_ortalamaHesapla);
            this.Controls.Add(this.txt_ikinciNot);
            this.Controls.Add(this.txt_birinciNot);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birinciNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ikinciNot;
        private System.Windows.Forms.Button btn_ortalamaHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

