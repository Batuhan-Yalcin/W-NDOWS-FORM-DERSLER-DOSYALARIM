namespace WindowsFormİleMESSAGEBOXkullanimi
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
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sonuc :";
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.Location = new System.Drawing.Point(26, 74);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(75, 23);
            this.btn_cikisyap.TabIndex = 1;
            this.btn_cikisyap.Text = "ÇIKIŞ YAP";
            this.btn_cikisyap.UseVisualStyleBackColor = true;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(101, 29);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(10, 13);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 156);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cikisyap);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

