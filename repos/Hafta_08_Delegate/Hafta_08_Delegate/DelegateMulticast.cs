using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta_08_Delegate
{
    public class DelegateMulticast
    {
        public delegate void DelOp(int x, int y);
        public DelegateMulticast()
        {
            DelOp obj = Operation.Add;
            obj += Operation.Multiple;
            obj += Operation.Divide;
            //obj += Operation.Add;
            //obj += Operation.Add; 
            //obj -= Operation.Divide;

            obj(20, 10);

        }
    }

   
}
