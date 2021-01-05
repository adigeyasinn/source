using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Hafta08_Events
{
    public class VideoEncoder
    {
        //1-Delegate Tanımla
        //2-Olay Tanımla
        //3-Olay meydana getir
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);

        public event VideoEncodedEventHandler VideoEncoded;//delegate tanımı(Video encoded yukarıdaki source ve e yi parametre olarak alır)

        public void Encode(Video video)
        {
            //Encode...
            Console.WriteLine("Video enconded...");
            Thread.Sleep(3000);

            //new MailService().Send("....")
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //abone varsa
            if (VideoEncoded!=null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video });

            }
        }
    }
}
