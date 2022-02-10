/*
 *  设计模式结构型————享元模式
 * 
 *  意图：{ 运用共享技术有效地支持大量细粒度的对象。}
 *         
 *  动机：{ 1. 采用纯粹对象方案的问题在于大量细粒度的对象会很快充斥在系统中，从而带来很高
 *         的运行时代价——主要指内存需求方面的代价
 *         
 *         2. 如何在避免大量细粒度对象问题的同时，让外部客户程序仍然能够透明地使用面向对象
 *         的方式来进行操作? }
 */

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPattern.StructuralPattern
{
    //------------------------------------------大量细粒化的对象
    public class audioClip
    {
        public string name;
        public string filePath;
        public string author;
        public float duration;
        //............
        public void Play()
        {
            //Play clip...
        }
    }
    //-------------------------------------------享元模块
    public class AudioFactory
    {

        // 将元数据存储在字典中, 待再次使用时调用已有的对象
        Dictionary<string, audioClip> audioClips;

        public AudioFactory()
        {
            audioClips = new Dictionary<string, audioClip>();
        }
        private audioClip loadCilps(string fileName)
        {
            //Find file
            return new audioClip();
        }
        public void AddClip(audioClip clip)
        {
            if (!audioClips.ContainsKey(clip.name))
            {
                audioClips.Add(clip.name, clip);
            }
        }
        public audioClip GetClip(string clipName)
        {
            audioClip audioClip;
            if (!audioClips.TryGetValue(clipName, out audioClip))
            {
                audioClip = loadCilps(clipName);
                audioClips.Add(audioClip.name, audioClip);
            }
            return audioClip;
        }
        public bool RemoveClip(string clipName)
        {
            return audioClips.Remove(clipName);
        }
        public void RemoveAllClips()
        {
            audioClips.Clear();
        }
    }
    //-----------------------------------------------FlyweightPatternDemo
    public class FlyweightPatternDemo
    {
        static void Main_(string[] args)
        {
            AudioFactory audioFactory = new AudioFactory();
            var clip = audioFactory.GetClip("MP4");
            clip.Play();
            //当再次调用将从字典中调取.
        }
    }
}