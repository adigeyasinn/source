using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_05_Linqappp
{
    public class Ogrenci
    {
        public List<Ogrenci> Liste { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public int SehirId { get; set; }
        public double Ortalama { get; set; }

        public Ogrenci()
        {
            Liste = new List<Ogrenci>
            {
                new Ogrenci("Yasin","Güneş",55,1.5),
                new Ogrenci("Ali","Seçkin",32,3.2),
                //new Ogrenci("Veli","Yılmaz",53,4.0),
                new Ogrenci("Ayça","Fatma",55,3.44),
            };
        }

        public Ogrenci(string adi, string soyadi, int sehirİd, double ortalama = 2)
        {
            Adi = adi;
            Soyadi = soyadi;
            SehirId = sehirİd;
            Ortalama = ortalama;
        }

        public override string ToString() =>
            $"{Adi,-15}{Soyadi,-15}{SehirId,-5}{Ortalama,-5}";

    }
}
