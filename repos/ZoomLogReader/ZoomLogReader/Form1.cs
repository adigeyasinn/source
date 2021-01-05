using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomLogReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Record> records = new List<Record>();

            using (var reader=new StreamReader(@"D:\2020-10-12.csv"))

            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<RecordMap>();
                records = csv.GetRecords<Record>().ToList();
            }

            dataGridView1.DataSource = records;
        }
    }
}
