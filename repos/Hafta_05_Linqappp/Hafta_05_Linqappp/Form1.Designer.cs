namespace Hafta_05_Linqappp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adıSoyadıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soyadaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adSOYADFormatındaGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adSOYADSehirFormatındaGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denKüçükOlanlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denBüyükOlanlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ile3ArasındaOlanlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehirleriSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehirKodunaGöreSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehirkoduseklindeGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adToolStripMenuItem,
            this.adıSoyadıToolStripMenuItem,
            this.ortalamaToolStripMenuItem,
            this.sehirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaToolStripMenuItem});
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(27, 24);
            this.adToolStripMenuItem.Text = " ";
            // 
            // adaToolStripMenuItem
            // 
            this.adaToolStripMenuItem.Name = "adaToolStripMenuItem";
            this.adaToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.adaToolStripMenuItem.Text = "Ada";
            // 
            // adıSoyadıToolStripMenuItem
            // 
            this.adıSoyadıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaGöreSıralaToolStripMenuItem,
            this.soyadaGöreSıralaToolStripMenuItem,
            this.adSOYADFormatındaGösterToolStripMenuItem,
            this.adSOYADSehirFormatındaGösterToolStripMenuItem});
            this.adıSoyadıToolStripMenuItem.Name = "adıSoyadıToolStripMenuItem";
            this.adıSoyadıToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.adıSoyadıToolStripMenuItem.Text = "Adı Soyadı";
            // 
            // adaGöreSıralaToolStripMenuItem
            // 
            this.adaGöreSıralaToolStripMenuItem.Name = "adaGöreSıralaToolStripMenuItem";
            this.adaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.adaGöreSıralaToolStripMenuItem.Text = "Ada göre sırala";
            this.adaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.adaGöreSıralaToolStripMenuItem_Click);
            // 
            // soyadaGöreSıralaToolStripMenuItem
            // 
            this.soyadaGöreSıralaToolStripMenuItem.Name = "soyadaGöreSıralaToolStripMenuItem";
            this.soyadaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.soyadaGöreSıralaToolStripMenuItem.Text = "Soyada göre sırala";
            this.soyadaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.soyadaGöreSıralaToolStripMenuItem_Click);
            // 
            // adSOYADFormatındaGösterToolStripMenuItem
            // 
            this.adSOYADFormatındaGösterToolStripMenuItem.Name = "adSOYADFormatındaGösterToolStripMenuItem";
            this.adSOYADFormatındaGösterToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.adSOYADFormatındaGösterToolStripMenuItem.Text = "Ad SOYAD formatında göster";
            this.adSOYADFormatındaGösterToolStripMenuItem.Click += new System.EventHandler(this.adSOYADFormatındaGösterToolStripMenuItem_Click);
            // 
            // adSOYADSehirFormatındaGösterToolStripMenuItem
            // 
            this.adSOYADSehirFormatındaGösterToolStripMenuItem.Name = "adSOYADSehirFormatındaGösterToolStripMenuItem";
            this.adSOYADSehirFormatındaGösterToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.adSOYADSehirFormatındaGösterToolStripMenuItem.Text = "Ad SOYAD Sehir formatında göster";
            this.adSOYADSehirFormatındaGösterToolStripMenuItem.Click += new System.EventHandler(this.adSOYADSehirFormatındaGösterToolStripMenuItem_Click);
            // 
            // ortalamaToolStripMenuItem
            // 
            this.ortalamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denKüçükOlanlarıGösterToolStripMenuItem,
            this.denBüyükOlanlarıGösterToolStripMenuItem,
            this.ile3ArasındaOlanlarıGösterToolStripMenuItem});
            this.ortalamaToolStripMenuItem.Name = "ortalamaToolStripMenuItem";
            this.ortalamaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.ortalamaToolStripMenuItem.Text = "Ortalama";
            // 
            // denKüçükOlanlarıGösterToolStripMenuItem
            // 
            this.denKüçükOlanlarıGösterToolStripMenuItem.Name = "denKüçükOlanlarıGösterToolStripMenuItem";
            this.denKüçükOlanlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.denKüçükOlanlarıGösterToolStripMenuItem.Text = "2.5 den küçük olanları göster";
            // 
            // denBüyükOlanlarıGösterToolStripMenuItem
            // 
            this.denBüyükOlanlarıGösterToolStripMenuItem.Name = "denBüyükOlanlarıGösterToolStripMenuItem";
            this.denBüyükOlanlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.denBüyükOlanlarıGösterToolStripMenuItem.Text = "3 den büyük olanları göster";
            // 
            // ile3ArasındaOlanlarıGösterToolStripMenuItem
            // 
            this.ile3ArasındaOlanlarıGösterToolStripMenuItem.Name = "ile3ArasındaOlanlarıGösterToolStripMenuItem";
            this.ile3ArasındaOlanlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.ile3ArasındaOlanlarıGösterToolStripMenuItem.Text = "2.5 ile 3 arasında olanları göster";
            // 
            // sehirToolStripMenuItem
            // 
            this.sehirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sehirleriSıralaToolStripMenuItem,
            this.sehirKodunaGöreSıralaToolStripMenuItem,
            this.sehirkoduseklindeGösterToolStripMenuItem});
            this.sehirToolStripMenuItem.Name = "sehirToolStripMenuItem";
            this.sehirToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.sehirToolStripMenuItem.Text = "Sehir";
            // 
            // sehirleriSıralaToolStripMenuItem
            // 
            this.sehirleriSıralaToolStripMenuItem.Name = "sehirleriSıralaToolStripMenuItem";
            this.sehirleriSıralaToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.sehirleriSıralaToolStripMenuItem.Text = "Sehirleri Sırala";
            this.sehirleriSıralaToolStripMenuItem.Click += new System.EventHandler(this.sehirleriSıralaToolStripMenuItem_Click);
            // 
            // sehirKodunaGöreSıralaToolStripMenuItem
            // 
            this.sehirKodunaGöreSıralaToolStripMenuItem.Name = "sehirKodunaGöreSıralaToolStripMenuItem";
            this.sehirKodunaGöreSıralaToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.sehirKodunaGöreSıralaToolStripMenuItem.Text = "Sehir koduna göre sırala";
            this.sehirKodunaGöreSıralaToolStripMenuItem.Click += new System.EventHandler(this.sehirKodunaGöreSıralaToolStripMenuItem_Click);
            // 
            // sehirkoduseklindeGösterToolStripMenuItem
            // 
            this.sehirkoduseklindeGösterToolStripMenuItem.Name = "sehirkoduseklindeGösterToolStripMenuItem";
            this.sehirkoduseklindeGösterToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.sehirkoduseklindeGösterToolStripMenuItem.Text = "Sehir(kodu)seklinde göster";
            this.sehirkoduseklindeGösterToolStripMenuItem.Click += new System.EventHandler(this.sehirkoduseklindeGösterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adıSoyadıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soyadaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adSOYADFormatındaGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adSOYADSehirFormatındaGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denKüçükOlanlarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denBüyükOlanlarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ile3ArasındaOlanlarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehirleriSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehirKodunaGöreSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehirkoduseklindeGösterToolStripMenuItem;
    }
}

