using System;

namespace ReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] DiziA = new int[] { 2, 4, 5, 3, 4, 6, 7, 89, 7, 6 };
            Console.WriteLine(İndisBul(DiziA));


            Console.ReadKey();

        }
               
        public static int İndisBul(int[] Dizi)
        {

            int sayi = 7;
            int indis = 0;

            for (int i = 0; i < Dizi.Length; i++)
            {
                
                if (Dizi[i] == sayi)
                {
                    
                    break;

                }
                indis++;

               

            }

            return indis;

        }
    }
}
