namespace MenuStrıpKullanimi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hataAyıklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniProjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokSayfasınaGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.gitToolStripMenuItem,
            this.projeToolStripMenuItem,
            this.derleToolStripMenuItem,
            this.hataAyıklaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniProjeToolStripMenuItem,
            this.stokSayfasınaGitToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.açToolStripMenuItem.Text = "Dosya";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.gitToolStripMenuItem.Text = "Git";
            // 
            // projeToolStripMenuItem
            // 
            this.projeToolStripMenuItem.Name = "projeToolStripMenuItem";
            this.projeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.projeToolStripMenuItem.Text = "Proje";
            // 
            // derleToolStripMenuItem
            // 
            this.derleToolStripMenuItem.Name = "derleToolStripMenuItem";
            this.derleToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.derleToolStripMenuItem.Text = "Derle";
            // 
            // hataAyıklaToolStripMenuItem
            // 
            this.hataAyıklaToolStripMenuItem.Name = "hataAyıklaToolStripMenuItem";
            this.hataAyıklaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.hataAyıklaToolStripMenuItem.Text = "Hata Ayıkla";
            // 
            // yeniProjeToolStripMenuItem
            // 
            this.yeniProjeToolStripMenuItem.Name = "yeniProjeToolStripMenuItem";
            this.yeniProjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniProjeToolStripMenuItem.Text = "Yeni Proje";
            // 
            // stokSayfasınaGitToolStripMenuItem
            // 
            this.stokSayfasınaGitToolStripMenuItem.Name = "stokSayfasınaGitToolStripMenuItem";
            this.stokSayfasınaGitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stokSayfasınaGitToolStripMenuItem.Text = "Stok Sayfasına Git";
            this.stokSayfasınaGitToolStripMenuItem.Click += new System.EventHandler(this.stokSayfasınaGitToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniProjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokSayfasınaGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hataAyıklaToolStripMenuItem;
    }
}

