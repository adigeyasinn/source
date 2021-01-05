using System;
using System.Collections.Generic;
using System.Text;

namespace SinavUygulama
{
    public class Araba
    {
        public List<Araba> List { get; set; }
        public string Model { get; set; }
        public double Motor { get; set; }
        public int Yil { get; set; }

        public Araba()
        {

        }

        public Araba(List<Araba> list, string model, double motor, int yil)
        {
            List = list;
            Model = model;
            Motor = motor;
            Yil = yil;
        }

        public override string ToString()
        {
            return $"{Model}";
        }
    }
}
