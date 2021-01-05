using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasniyonKayit.Genel
{
    public class Tur
    {
        public int PansiyonId { get; set; }
        public string PansiyonTuru { get; set; }
        public Tur()
        {

        }

        public Tur(int pansiyonId, string pansiyonTuru)
        {
            PansiyonId = pansiyonId;
            PansiyonTuru = pansiyonTuru;
        }
        public override string ToString()
        {
            return $"{PansiyonTuru}";
        }
    }
}
