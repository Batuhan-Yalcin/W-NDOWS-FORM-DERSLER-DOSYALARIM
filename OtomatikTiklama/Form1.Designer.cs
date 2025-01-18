namespace OtomatikTiklama
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
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.nudBeklemeSuresi = new System.Windows.Forms.NumericUpDown();
            this.lbl_tikla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTiklamaSayisi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeklemeSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiklamaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(99, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Başlat F1";
            this.btnBaslat.UseVisualStyleBackColor = true;
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(225, 12);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 23);
            this.btnDurdur.TabIndex = 0;
            this.btnDurdur.Text = "Durdur F2";
            this.btnDurdur.UseVisualStyleBackColor = true;
            // 
            // nudBeklemeSuresi
            // 
            this.nudBeklemeSuresi.Location = new System.Drawing.Point(180, 61);
            this.nudBeklemeSuresi.Name = "nudBeklemeSuresi";
            this.nudBeklemeSuresi.Size = new System.Drawing.Size(120, 20);
            this.nudBeklemeSuresi.TabIndex = 1;
            this.nudBeklemeSuresi.ValueChanged += new System.EventHandler(this.nudBeklemeSuresi_ValueChanged);
            // 
            // lbl_tikla
            // 
            this.lbl_tikla.AutoSize = true;
            this.lbl_tikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tikla.Location = new System.Drawing.Point(8, 63);
            this.lbl_tikla.Name = "lbl_tikla";
            this.lbl_tikla.Size = new System.Drawing.Size(155, 13);
            this.lbl_tikla.TabIndex = 2;
            this.lbl_tikla.Text = "Tıklama Süresini Ayarlayın";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tıklama Sayısını Ayarlayın";
            // 
            // nudTiklamaSayisi
            // 
            this.nudTiklamaSayisi.Location = new System.Drawing.Point(180, 101);
            this.nudTiklamaSayisi.Name = "nudTiklamaSayisi";
            this.nudTiklamaSayisi.Size = new System.Drawing.Size(120, 20);
            this.nudTiklamaSayisi.TabIndex = 3;
            this.nudTiklamaSayisi.ValueChanged += new System.EventHandler(this.nudTiklamaSayisi_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 141);
            this.Controls.Add(this.nudTiklamaSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tikla);
            this.Controls.Add(this.nudBeklemeSuresi);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBeklemeSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiklamaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.NumericUpDown nudBeklemeSuresi;
        private System.Windows.Forms.Label lbl_tikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTiklamaSayisi;
    }
}

