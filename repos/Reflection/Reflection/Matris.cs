using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Matris
    {
        private readonly int[,] _Data;
        public int N { get; set; }

        public Matris()
        {
            _Data = new int[3, 3];
            N = 3;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)

                    _Data[i, j] = 0;

            }
        }
        public Matris(int n = 3)
        {
            _Data = new int[n, n];
            N = n;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)

                    _Data[i, j] = new Random().Next(0, 9);

            }
        }

            public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++) { 

                    Console.Write($"{_Data[i,j],-3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }

    }
    }

