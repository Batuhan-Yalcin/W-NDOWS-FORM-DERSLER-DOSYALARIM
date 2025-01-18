namespace WindowsFormlaraGiris
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
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_deger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_isim.CausesValidation = false;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_isim.Location = new System.Drawing.Point(475, 152);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(97, 15);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "Adınızı Giriniz : ";
            this.lbl_isim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_deger
            // 
            this.lbl_deger.AutoSize = true;
            this.lbl_deger.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_deger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_deger.CausesValidation = false;
            this.lbl_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_deger.Location = new System.Drawing.Point(597, 152);
            this.lbl_deger.Name = "lbl_deger";
            this.lbl_deger.Size = new System.Drawing.Size(13, 15);
            this.lbl_deger.TabIndex = 0;
            this.lbl_deger.Text = ":";
            this.lbl_deger.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 499);
            this.Controls.Add(this.lbl_deger);
            this.Controls.Add(this.lbl_isim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_deger;
    }
}

