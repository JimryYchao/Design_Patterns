using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Adapter
{
    public interface IPlayer
    {
        void Play(string fileName, MediaType type);
    }
    public class Player : IPlayer
    {
        public virtual void Play(string fileName, MediaType type)
        {
            if (type == MediaType.mp3)
                Console.WriteLine("PlayAudio mp3 : " + fileName);
        }
    }
}
