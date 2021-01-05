using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta_08_Delegate
{
    class Operation
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine($"{a}+{b}={a+b}");
        }

        public static void Multiple(int a,int b)
        {
            Console.WriteLine($"{a}*{b}={a * b}");
        }

        public static void Divide(int a,int b)
        {
            Console.WriteLine($"{a}/{b}={a / b}");
        }
    }
}
