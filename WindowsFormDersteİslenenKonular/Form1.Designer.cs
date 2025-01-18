namespace WindowsFormDersteİslenenKonular
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
            this.verilerList = new System.Windows.Forms.ListBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_veri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verilerList
            // 
            this.verilerList.BackColor = System.Drawing.Color.Yellow;
            this.verilerList.FormattingEnabled = true;
            this.verilerList.Location = new System.Drawing.Point(2, 155);
            this.verilerList.Name = "verilerList";
            this.verilerList.Size = new System.Drawing.Size(173, 225);
            this.verilerList.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ekle.Location = new System.Drawing.Point(85, 98);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(95, 26);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Veri Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_veri
            // 
            this.txt_veri.BackColor = System.Drawing.Color.Goldenrod;
            this.txt_veri.Location = new System.Drawing.Point(80, 32);
            this.txt_veri.Name = "txt_veri";
            this.txt_veri.Size = new System.Drawing.Size(100, 20);
            this.txt_veri.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veri Giriniz : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_veri);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.verilerList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox verilerList;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_veri;
        private System.Windows.Forms.Label label1;
    }
}

