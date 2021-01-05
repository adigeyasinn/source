
namespace pasniyonKayit
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
            this.datagw = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesabaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türleriSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOYADadŞeklindeSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formataGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adSoyadFormatındaSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaNoFormatındaSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagw
            // 
            this.datagw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagw.Location = new System.Drawing.Point(34, 155);
            this.datagw.Name = "datagw";
            this.datagw.RowHeadersWidth = 51;
            this.datagw.RowTemplate.Height = 24;
            this.datagw.Size = new System.Drawing.Size(880, 343);
            this.datagw.TabIndex = 0;
            this.datagw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagw_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sıralaToolStripMenuItem,
            this.formataGöreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaEkleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItem1.Text = "Ayarlar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dosyaEkleToolStripMenuItem
            // 
            this.dosyaEkleToolStripMenuItem.Name = "dosyaEkleToolStripMenuItem";
            this.dosyaEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.dosyaEkleToolStripMenuItem.Text = "Dosya Ekle";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // sıralaToolStripMenuItem
            // 
            this.sıralaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaGöreSıralaToolStripMenuItem,
            this.hesabaGöreSıralaToolStripMenuItem,
            this.türleriSıralaToolStripMenuItem,
            this.sOYADadŞeklindeSıralaToolStripMenuItem});
            this.sıralaToolStripMenuItem.Name = "sıralaToolStripMenuItem";
            this.sıralaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.sıralaToolStripMenuItem.Text = "Sırala";
            // 
            // adaGöreSıralaToolStripMenuItem
            // 
            this.adaGöreSıralaToolStripMenuItem.Name = "adaGöreSıralaToolStripMenuItem";
            this.adaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.adaGöreSıralaToolStripMenuItem.Text = "Ada Göre Sırala";
            this.adaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.adaGöreSıralaToolStripMenuItem_Click);
            // 
            // hesabaGöreSıralaToolStripMenuItem
            // 
            this.hesabaGöreSıralaToolStripMenuItem.Name = "hesabaGöreSıralaToolStripMenuItem";
            this.hesabaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.hesabaGöreSıralaToolStripMenuItem.Text = "Hesaba Göre Sırala";
            this.hesabaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.hesabaGöreSıralaToolStripMenuItem_Click);
            // 
            // türleriSıralaToolStripMenuItem
            // 
            this.türleriSıralaToolStripMenuItem.Name = "türleriSıralaToolStripMenuItem";
            this.türleriSıralaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.türleriSıralaToolStripMenuItem.Text = "Türleri Sırala";
            this.türleriSıralaToolStripMenuItem.Click += new System.EventHandler(this.türleriSıralaToolStripMenuItem_Click);
            // 
            // sOYADadŞeklindeSıralaToolStripMenuItem
            // 
            this.sOYADadŞeklindeSıralaToolStripMenuItem.Name = "sOYADadŞeklindeSıralaToolStripMenuItem";
            this.sOYADadŞeklindeSıralaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.sOYADadŞeklindeSıralaToolStripMenuItem.Text = "SOYADad Şeklinde Sırala";
            this.sOYADadŞeklindeSıralaToolStripMenuItem.Click += new System.EventHandler(this.sOYADadŞeklindeSıralaToolStripMenuItem_Click);
            // 
            // formataGöreToolStripMenuItem
            // 
            this.formataGöreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adSoyadFormatındaSıralaToolStripMenuItem,
            this.odaNoFormatındaSıralaToolStripMenuItem});
            this.formataGöreToolStripMenuItem.Name = "formataGöreToolStripMenuItem";
            this.formataGöreToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.formataGöreToolStripMenuItem.Text = "Formata Göre";
            // 
            // adSoyadFormatındaSıralaToolStripMenuItem
            // 
            this.adSoyadFormatındaSıralaToolStripMenuItem.Name = "adSoyadFormatındaSıralaToolStripMenuItem";
            this.adSoyadFormatındaSıralaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.adSoyadFormatındaSıralaToolStripMenuItem.Text = "AdSoyad Formatında Sırala";
            this.adSoyadFormatındaSıralaToolStripMenuItem.Click += new System.EventHandler(this.adSoyadFormatındaSıralaToolStripMenuItem_Click);
            // 
            // odaNoFormatındaSıralaToolStripMenuItem
            // 
            this.odaNoFormatındaSıralaToolStripMenuItem.Name = "odaNoFormatındaSıralaToolStripMenuItem";
            this.odaNoFormatındaSıralaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.odaNoFormatındaSıralaToolStripMenuItem.Text = "OdaNo Formatında Sırala";
            this.odaNoFormatındaSıralaToolStripMenuItem.Click += new System.EventHandler(this.odaNoFormatındaSıralaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dosyaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesabaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türleriSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOYADadŞeklindeSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formataGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adSoyadFormatındaSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaNoFormatındaSıralaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

