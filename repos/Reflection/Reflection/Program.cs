using System;

namespace Reflection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Matris matris = new Matris();
            matris.Print();
            /*
            var m=(Matris)Activator.CreateInstance(typeof(Matris),10);   //Boxing
            m.Print();*/

            var m = Activator.CreateInstance(typeof(Matris), 10);   //Boxing
            m.GetType()
                .GetMethod("Print")
                .Invoke(m, null);

            Console.ReadKey();
        }
    }
}
