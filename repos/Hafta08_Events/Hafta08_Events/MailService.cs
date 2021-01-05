using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta08_Events
{
   public class MailService
    {
        public void OnVideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine($"Mail Service: a video has ben encoded..."+e.Video.Title);
        }
    }
}
