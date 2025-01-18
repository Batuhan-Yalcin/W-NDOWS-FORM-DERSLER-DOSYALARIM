namespace WindowsFormİleLİSTBOXkullanimi
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ekle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(805, 457);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba"});
            this.listBox2.Location = new System.Drawing.Point(-3, 118);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(207, 251);
            this.listBox2.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ekle.Location = new System.Drawing.Point(261, 118);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(143, 31);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_sil.Location = new System.Drawing.Point(261, 184);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(143, 31);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_count
            // 
            this.btn_count.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_count.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_count.Location = new System.Drawing.Point(261, 260);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(143, 31);
            this.btn_count.TabIndex = 2;
            this.btn_count.Text = "COUNT BUL";
            this.btn_count.UseVisualStyleBackColor = false;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(261, 328);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(143, 31);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eklemek İstediğiniz Değeri Giriniz : ";
            // 
            // txt_ekle
            // 
            this.txt_ekle.Location = new System.Drawing.Point(261, 50);
            this.txt_ekle.Name = "txt_ekle";
            this.txt_ekle.Size = new System.Drawing.Size(143, 20);
            this.txt_ekle.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 381);
            this.Controls.Add(this.txt_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ekle;
    }
}

