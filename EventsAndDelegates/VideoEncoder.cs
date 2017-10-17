using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }

    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise (or publish) the event 

        //1
        /*public delegate void VideoEncodedEventHandler(object sender, EventArgs args);*/
        //public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs args);  <------ Don't need anymore
        //Hold a reference to a function that looks like this


        // EventHandler
        // EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;  //The same as above from the .NET

        //2
        //public event VideoEncodedEventHandler VideoEncoded; <-- Don't need anymore

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            Console.WriteLine("Encoded Video...");

            OnVideoEncoded(video);
        }

        //3 MSDN Convention, should be protected, virtual and void, and should start with the word on and then the name of the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
