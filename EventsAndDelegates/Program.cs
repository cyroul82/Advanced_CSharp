using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{

    /*
     What are events and Why do we need them
        - A mechanism for communication between objects
        - Used in building Loosely Coupled Applications
        - Helps extending applications

         */

    /*
     * Delegates:
     *   - Agreement / Contrat between Publisher and Subscriber
     *   - Determines the signature of the event handler method in Subscriber
     * 
     */

    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService(); //Subscriber
            var messageService = new MessageService(); //Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}
