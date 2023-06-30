using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int LengthOfVideo { get; set; }


        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoURL, int lengthOfVideo, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.VideoURL = videoURL;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.LengthOfVideo = lengthOfVideo;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying=true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }


        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currDuration} sec");
                currDuration = 0;
                timer.Dispose();
            }

        }
        private void TimerCallback(Object o)
        {
            if (currDuration < LengthOfVideo)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}s.");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.LengthOfVideo}sec. - {this.VideoURL}- {this.SendByUsername}");
        }
    }
}
