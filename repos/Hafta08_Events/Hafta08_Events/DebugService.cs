using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Hafta08_Events
{
    public class DebugService
    {
        public void OnVideoEncoded(object source,VideoEventArgs e)
        {
            Debug.WriteLine($"DebugService:A video has ben encoded..."+
                e.Video.Title);
            Console.WriteLine($"DebugService:A video has ben encoded..."+e.Video.Title);

        }
    }
}
