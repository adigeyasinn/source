using System;

namespace denemeeeee_sil_
{
   partial class Program
    {
        public static double Calculate(ref double cost) =>
            cost % 2 == 0 ? cost * 0.90 : cost * 0.80;
        public static void Main(string[] args)
        {
            var d = 90.0;
            d += 10;
            Console.WriteLine(d);

            d = Calculate(ref d);
            Console.WriteLine(d);
        }
    }
}
