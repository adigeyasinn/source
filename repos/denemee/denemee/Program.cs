using System;
using System.Collections.Generic;
using System.Linq;

namespace denemee
{

    public class Ogrenci
    {
        public List<Ogrenci> Listesi { get; set; }
        public string Adi { get; set; }

        public string Soyadi { get; set; }
        public double Ortalama { get; set; }
        public int SehirId { get; set; }

        public Ogrenci()
        {
            Listesi = new List<Ogrenci>
                {

                new Ogrenci("Yasin","Güneş",55,1.5),
                new Ogrenci("Ali","Seçkin",32,3.2),
                new Ogrenci("Veli","Yılmaz",53,4.0),
                new Ogrenci("Ayça","Fatama",55,3.44),
                new Ogrenci("Hüseyin","Acar",28,2.04),
                new Ogrenci("Necip","Uysal",80,2.8),

                };
        }

        public Ogrenci(string adi, string soyadi, int sehirId, double ortalama)
        {
            Adi = adi;
            Soyadi = soyadi;
            SehirId = sehirId;
            Ortalama = ortalama;
        }
        public override string ToString()
        {
            return $"{Adi,-10}" +
                $"{Soyadi,-10}" +
                $"{SehirId - 10}" +
                $"{Ortalama,-10}";
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();

            var query = from o in ogrenci.Listesi where o.Ortalama > 3.0 orderby o.Adi select new
                        {
                            Adi = o.Adi,
                            //Soyadi = o.Soyadi

                        };
                       
                        
                        

            query.ToList().ForEach(o => Console.WriteLine($"{o.Adi,-10}" +
                $"{o.Soyadi,-10}"));




            Console.ReadKey();
        }

    }
}
