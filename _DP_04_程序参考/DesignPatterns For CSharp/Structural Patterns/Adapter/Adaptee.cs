using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Adapter
{
    public enum MediaType
    {
        // Music
        mp3, AIFF, MIDI, wave,
        mp4, mov, avi, m4v//....
    }
    internal interface IAdvanceMediaPlyer
    {
        void PlayMedia(string fileName, MediaType type);
    }
    public class AudioPlayer : IAdvanceMediaPlyer
    {
        public virtual void PlayMedia(string fileName, MediaType type)
        {
            switch (type)
            {
                case MediaType.AIFF:
                    Console.WriteLine("PlayAudio AIFF : " + fileName);
                    return;
                case MediaType.MIDI:
                    Console.WriteLine("PlayAudio MIDI : " + fileName);
                    return;
                case MediaType.wave:
                    Console.WriteLine("PlayAudio wave : " + fileName);
                    return;
                default:
                    break;
            }
        }
    }
    public class VideoPlayer : IAdvanceMediaPlyer
    {
        public virtual void PlayMedia(string fileName, MediaType type)
        {
            switch (type)
            {
                case MediaType.mp4:
                    Console.WriteLine("PlayVideo mp4 : " + fileName);
                    return;
                case MediaType.mov:
                    Console.WriteLine("PlayVideo mov : " + fileName);
                    return;
                case MediaType.avi:
                    Console.WriteLine("PlayVideo avi : " + fileName);
                    return;
                case MediaType.m4v:
                    Console.WriteLine("PlayVideo m4v : " + fileName);
                    return;
                default:
                    break;
            }
        }
    }
}
