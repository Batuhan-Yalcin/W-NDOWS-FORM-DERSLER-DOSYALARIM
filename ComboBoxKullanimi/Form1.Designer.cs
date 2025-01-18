namespace ComboBoxKullanimi
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
            this.combo_Gunler = new System.Windows.Forms.ComboBox();
            this.btn_gunSec = new System.Windows.Forms.Button();
            this.lbl_Gun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_Gunler
            // 
            this.combo_Gunler.FormattingEnabled = true;
            this.combo_Gunler.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba"});
            this.combo_Gunler.Location = new System.Drawing.Point(319, 165);
            this.combo_Gunler.Name = "combo_Gunler";
            this.combo_Gunler.Size = new System.Drawing.Size(185, 21);
            this.combo_Gunler.TabIndex = 0;
            this.combo_Gunler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_gunSec
            // 
            this.btn_gunSec.Location = new System.Drawing.Point(319, 208);
            this.btn_gunSec.Name = "btn_gunSec";
            this.btn_gunSec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_gunSec.Size = new System.Drawing.Size(185, 23);
            this.btn_gunSec.TabIndex = 1;
            this.btn_gunSec.Text = "Gün Seç";
            this.btn_gunSec.UseMnemonic = false;
            this.btn_gunSec.UseVisualStyleBackColor = true;
            this.btn_gunSec.Click += new System.EventHandler(this.btn_gunSec_Click);
            // 
            // lbl_Gun
            // 
            this.lbl_Gun.AutoSize = true;
            this.lbl_Gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gun.Location = new System.Drawing.Point(160, 166);
            this.lbl_Gun.Name = "lbl_Gun";
            this.lbl_Gun.Size = new System.Drawing.Size(95, 20);
            this.lbl_Gun.TabIndex = 2;
            this.lbl_Gun.Text = "Gün Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 399);
            this.Controls.Add(this.lbl_Gun);
            this.Controls.Add(this.btn_gunSec);
            this.Controls.Add(this.combo_Gunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Gunler;
        private System.Windows.Forms.Button btn_gunSec;
        private System.Windows.Forms.Label lbl_Gun;
    }
}

