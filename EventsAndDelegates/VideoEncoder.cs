using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1 - Define a Delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        //public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);  // 1
        //public event VideoEncoderEventHandler VideoEncoded; // 2

        public event EventHandler<VideoEventArgs> VideoEncoded; // 1 & 2


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // Event publishing methods should be virtual & protected
        protected virtual void OnVideoEncoded(Video video) // 3
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }

    }
}
