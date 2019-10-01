using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{

    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "My video" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailservice = new MailService(); // Subscriber
            var messageService = new MessageService(); // Subscriber

            videoEncoder.VideoEncoded += mailservice.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
            
        }
    }
}
