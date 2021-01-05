using pasniyonKayit.Genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasniyonKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPansiyon();
        }

        private void LoadPansiyon()
        {
            
            datagw.DataSource = new PansiyonDal().GetAll().ToList();
            
        }

        private void datagw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void adaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datagw.DataSource = new PansiyonDal().GetAll()
                .OrderBy(o => o.Adi).ThenBy(s => s.Hesap).ToList();
        }

        private void hesabaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datagw.DataSource = new PansiyonDal().GetAll()
                .OrderBy(o => o.Hesap)
                .ToList();

        }

        private void türleriSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datagw.DataSource = new TurDal().GetAll()
                .OrderBy(o => o.PansiyonTuru)
                .ToList();
        }

        private void sOYADadŞeklindeSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datagw.DataSource = new PansiyonDal().GetAll()
                .Join(new PansiyonDal().GetAll(), a => a.PansiyonId,b=>b.PansiyonId, (a,b) => new //Burada bunu yapmamızın amacı ne
                {
                    SOYAD =(a.Soyadi.ToUpper()),
                    Ad = a.Adi
                })
                .ToList();
        }

        private void adSoyadFormatındaSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datagw.DataSource = new PansiyonDal().GetAll()
                .OrderBy(o=>o.Adi)
                .Select(s => new
                {
                    AdSoyad = string.Concat(s.Adi + " " + s.Soyadi)
                })
                .ToList();
        }

        private void odaNoFormatındaSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datagw.DataSource = new PansiyonDal().GetAll()
                .OrderBy(o => o.OdaNo)
                .Select(o => new { OdaNO = o.OdaNo, Adı=o.Adi })
                .Where(o => o.OdaNO <= 100)
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PansiyonDal pansiyon = new PansiyonDal();
            pansiyon.Add(new Pansiyon { Adi = "Elif", Soyadi = "Güneş", Hesap = 15635, Id = 1, OdaNo = 55, PansiyonId = 1, Telefon = 26353 });
            LoadPansiyon();
        }
    }
}
