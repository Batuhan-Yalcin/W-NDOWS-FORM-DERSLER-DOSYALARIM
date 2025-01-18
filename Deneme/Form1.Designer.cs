namespace Deneme
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
            this.lbl_veri = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_ekle = new System.Windows.Forms.TextBox();
            this.litsbox_eklenen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_veri
            // 
            this.lbl_veri.AutoSize = true;
            this.lbl_veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_veri.Location = new System.Drawing.Point(32, 103);
            this.lbl_veri.Name = "lbl_veri";
            this.lbl_veri.Size = new System.Drawing.Size(72, 13);
            this.lbl_veri.TabIndex = 0;
            this.lbl_veri.Text = " veri girin : ";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Gold;
            this.btn_ekle.Location = new System.Drawing.Point(84, 134);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_ekle
            // 
            this.txt_ekle.Location = new System.Drawing.Point(110, 96);
            this.txt_ekle.Name = "txt_ekle";
            this.txt_ekle.Size = new System.Drawing.Size(100, 20);
            this.txt_ekle.TabIndex = 2;
            this.txt_ekle.TextChanged += new System.EventHandler(this.txt_ekle_TextChanged);
            // 
            // litsbox_eklenen
            // 
            this.litsbox_eklenen.FormattingEnabled = true;
            this.litsbox_eklenen.Location = new System.Drawing.Point(3, 212);
            this.litsbox_eklenen.Name = "litsbox_eklenen";
            this.litsbox_eklenen.Size = new System.Drawing.Size(120, 134);
            this.litsbox_eklenen.TabIndex = 3;
            this.litsbox_eklenen.SelectedIndexChanged += new System.EventHandler(this.litsbox_eklenen_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 348);
            this.Controls.Add(this.litsbox_eklenen);
            this.Controls.Add(this.txt_ekle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbl_veri);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_veri;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_ekle;
        private System.Windows.Forms.ListBox litsbox_eklenen;
    }
}

