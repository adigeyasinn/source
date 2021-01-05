using System;

namespace Hafta08_Events
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            var video = new Video() {Title="Ethos" };
            var videoEncoder = new VideoEncoder();
            videoEncoder.Encode(video);
            var mailService = new MailService();
            var debugService = new DebugService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += debugService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
