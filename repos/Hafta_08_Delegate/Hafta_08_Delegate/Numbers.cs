using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta_08_Delegate
{
    class Numbers
    {
        public delegate void CallBack(int i);
        public void GenerateNumbers(CallBack obj)
        {
            for (int i = 0; i < 10; i++)
            {
                obj(i);
            }
        }
    }
}
