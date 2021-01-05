using System;

namespace Hafta_08_Delegate
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //new DelegateMulticast();

            Numbers obj = new Numbers();
            obj.GenerateNumbers(DoThis);

            Console.ReadKey();
        }

        public  static void DoThis(int i)
        {
            Console.WriteLine($"{i,-5}{i*i,-5}");
        }
    }

    
}
