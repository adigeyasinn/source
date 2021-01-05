using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomLogReader
{
    class RecordMap:ClassMap<Record>
    {
        public RecordMap()
        {
            Map(m => m.ID).Name("Participant");
            Map(m => m.ID).Name("Device");
            Map(m => m.ID).Name("Ip Adress");

        }
    }
}
