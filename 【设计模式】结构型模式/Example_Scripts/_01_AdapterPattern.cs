/*
 *  设计模式结构型————适配器模式
 * 
 *  意图：{ 将一个类的接口转换成客户希望的另一个接口。Adapter模式使得原本由
 *         于接口不兼容而不能一起工作的那些类可以一起工作。}
 *         
 *  动机：{ 1. 软件系统中，由于应用环境的变化，常常需要将“一些现存的对象”放在
 *         新的环境中应用，但是新环境要求的接口是这些现存对象所不满足的。
 *         
 *         2. 如何应对这种"迁移的变化”?如何既能利用现有对象的良好实现，同时又
 *         能满足新的应用环境所要求的接口? }
 */

using System;

namespace Ychao..Learn.DesignPattern.StructuralPattern
{
    //---------------------------------------Adaptee接口结构
    public interface IAdvanceMediaPlayer
    {
        void PlayVLC(string fileName);
        void PlayMP4(string fileName);
    }
    public class VLCPlayer : IAdvanceMediaPlayer
    {
        public void PlayMP4(string fileName)
        {
            //DO NOTHING....
        }
        public void PlayVLC(string fileName)
        {
            //Do Play VLC..........
        }
    }
    public class MP4Player : IAdvanceMediaPlayer
    {
        public void PlayMP4(string fileName)
        {
            //Do Play MP4..........
        }
        public void PlayVLC(string fileName)
        {
            //DO NOTHING...
        }
    }
    //------------------------------------------Adapter接口结构
    public interface IMediaPlayer
    {
        void Play(string fileName, AudioType audioType);
    }
    public enum AudioType
    {
        mp3, mp4, vlc, avi,//....
    }
    public class MediaAdapter : IMediaPlayer
    {
        IAdvanceMediaPlayer mp4Player = new MP4Player();
        IAdvanceMediaPlayer vlcPlayer = new VLCPlayer();

        public void Play(string fileName, AudioType audioType)
        {
            if (audioType == AudioType.vlc)
            {
                mp4Player.PlayVLC(fileName);
            }
            else if (audioType == AudioType.mp4)
            {
                vlcPlayer.PlayMP4(fileName);
            }
            else
            {
                //Expand Players....
                Console.WriteLine("未适配该播放格式的资源");
            }
        }
    }
    //--------------------------------------------为AudioPlayer原有接口扩展Adapter
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter MediaAdapter;
        public AudioPlayer()
        {
            MediaAdapter = new MediaAdapter();
        }
        public void Play(string fileName,AudioType audioType)
        {
            //原有的MP3播放器,拓展了设配器的其他播放功能
            if (audioType == AudioType.mp3)
            {
                //Do Play MP3..........
            }
            else
            {
                MediaAdapter.Play(fileName, audioType);
            }
        }
    }
    //---------------------------------------------AdapterPatternDemo
    public class AdapterPatternDemo
    {
        static void Main(string[] args)
        {
            AudioPlayer player = new AudioPlayer();

            player.Play("Hello.Mp3", AudioType.mp3);
        }
    }
}