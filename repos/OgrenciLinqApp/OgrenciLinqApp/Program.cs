using System;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciLinqApp
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
                new Ogrenci("Veli","Yılmaz",53,4.0),
                new Ogrenci("Ayça","Fatama",55,3.44),
                new Ogrenci("Hüseyin","Acar",28,2.04),
                new Ogrenci("Necip","Uysal",80,2.8),
            };
        }

        public Ogrenci(string adi,string soyadi,int sehirİd,double ortalama=2)
        {
            Adi = adi;
            Soyadi = soyadi;
            SehirId = sehirİd;
            Ortalama = ortalama;
        }

        public override string ToString() =>
            $"{Adi,-15}{Soyadi,-15}{SehirId,-5}{Ortalama,-5}";

    }
    public class Program
    {
        static void Main(string[] args)
        {
            JoinOrnegi();

            Console.ReadKey();
        }

        private static void JoinOrnegi()
        {
            new Ogrenci()
                            .Liste
                            .Join(new Sehir().Liste, o => o.SehirId, s => s.SehirId,
                            (o, s) => new
                            {
                                Adi = o.Adi,
                                Soyadi = o.Soyadi,
                                SehirAdi = s.SehirAdi,
                                PlakNo = s.SehirId
                            })
                            .OrderBy(o => o.SehirAdi)
                            .ThenBy(o => o.Adi)
                            .ToList()
                            .ForEach(o => Console.WriteLine(o.Adi+o.Soyadi+o.SehirAdi+o.PlakNo));
        }

        private static void SorguTürleri()
        {
            //Sorgu 
            var query = from s in new Sehir().Liste
                        select s;
            query.ToList().ForEach(s => Console.WriteLine(s));

            Console.WriteLine();

            foreach (var item in query)
            {
                Console.WriteLine(query);
            }

            new Sehir()
                .Liste.OrderBy(s => s.SehirAdi)
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }

        private static void FiltrelemeOrnegi2()
        {
            new Ogrenci()
                .Liste
                .Where(o => o.Ortalama < 2)
                .OrderBy(o => o.Adi)
                .ThenByDescending(o => o.Soyadi)
                .ToList()
                .ForEach(o => Console.WriteLine(o));
        }

        private static void SıralamaOrnegi()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Liste.OrderBy(o => o.Adi).ToList().ForEach(o => Console.WriteLine(o));
        }
    }
}
