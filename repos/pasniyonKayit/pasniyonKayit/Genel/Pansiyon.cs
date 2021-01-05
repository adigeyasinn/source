using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasniyonKayit
{
    public class Pansiyon
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int OdaNo { get; set; }
        public int Telefon { get; set; }
        public int Hesap { get; set; }
        public int PansiyonId { get; set; }

        public Pansiyon()
        {

        }

        public Pansiyon(string adi, string soyadi, int odaNo, int telefon, int hesap,int pansiyonİd )
        {
           
            Adi = adi;
            Soyadi = soyadi;
            OdaNo = odaNo;
            Telefon = telefon;
            Hesap = hesap;
            PansiyonId = pansiyonİd;
        }

        public override string ToString()
        {
            return $"{Adi}";
        }
    }
}
