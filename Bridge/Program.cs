using System;
using Bridge.Platforms;
using Bridge.Transmissions;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLive(new Youtube());
            StartLive(new TwitchTv());
            StartLive(new Facebook());

            StartAdvancedLive(new Facebook());
            StartAdvancedLive(new DLive());
        }

        static void StartLive(IPlatform platform)
        {
            Live live = new Live(platform);
            live.Broadcast();
            live.Result();
        }

        static void StartAdvancedLive(IPlatform platform)
        {
            AdvancedLive live = new AdvancedLive(platform);
            live.Broadcast();
            live.Comments();
            live.Subtitles();
            live.Record();
            live.Result();
        }

    }
}
