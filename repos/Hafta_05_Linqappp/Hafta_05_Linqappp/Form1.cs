using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_05_Linqappp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                new Ogrenci().Liste;
        }

        private void adaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                new Ogrenci().Liste
                .OrderBy(o => o.Adi)
                .ToList();
        }

        private void soyadaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                new Ogrenci().Liste
                .OrderBy(o => o.Soyadi)
                .ToList();

        }

        private void adSOYADFormatındaGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                new Ogrenci().Liste
                .OrderBy(o => o.Adi)
                .Select(o => new
                {
                    AdSoyad = string.Concat(o.Adi, "  ", o.Soyadi.ToUpper())
                })
                .ToList();
        }

        private void adSOYADSehirFormatındaGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
               new Ogrenci()
                            .Liste
                            .Join(new Sehir().Liste, o => o.SehirId, s => s.SehirId,
                            (o, s) => new
                            {
                                AdSoyad = string.Concat(o.Adi, "  ", o.Soyadi.ToUpper()),
                                Ortalama=o.Ortalama,
                                Sehir = s.SehirAdi
                            })
                            .Where(o=>o.Ortalama<=2)
                            .OrderBy(s=>s.Sehir)
                            .ThenBy(s=>s.AdSoyad)
                            .ToList();
        }

        private void sehirkoduseklindeGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
              new Sehir().Liste
              .OrderBy(s => s.SehirId)
              .ToList();

        }

        private void sehirleriSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                new Sehir().Liste
                .OrderBy(s => s.SehirAdi)
                .Select(s => new
                {
                    Sehir = (s.SehirAdi)
                })
                .ToList();
        }

        private void sehirKodunaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
