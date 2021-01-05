using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomLogReader
{
    class Record
    {
        [Index(0)]
        public string ID { get; set; }

        [Name("Device")]
        public string Aygit { get; set; }

        [Name("Ip Adress")]
        public string Ağ { get; set; }
    }
}
