/*
 *  设计模式结构型————代理模式
 * 
 *  意图：{ 为其他对象提供一种代理以控制对这个对象的访问。}
 *         
 *  动机：{ 1. 在面向对象系统中，有些对象由于某种原因( 比如对象创建的开销很大，或者某些操作需要安全控
 *          制，或者需要进程外的访问等)，直接访问会给使用者、或者系统结构带来很多麻烦。
 *         
 *         2. 如何在不失去透明操作对象的同时来管理/控制这些对象特有的复杂性?增加一层间接层是软件开发
 *         中常见的解决方式。 }
 */

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPattern.StructuralPattern
{
    //------------------------------------------使用代理的方式将原有对象的初始化延时
    public interface Image
    {
        void Display();
    }
    public class RealImage:Image
    {
        private string fileName;
        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadImage(fileName);
        }
        public void Display()
        {
            //...How to Display.
        }
        private void loadImage(string fileName)
        {
            //....Load images
        }
    }
    public class ProxyImaga:Image
    {
        RealImage image;
        private string fileName;
        public ProxyImaga(string fileName)
        {
            this.fileName = fileName;
        }
        public void Display()
        {
            if (image == null)
            {
                image = new RealImage(fileName);
            }
            image.Display();
        }
    }
    //----------------------------------------------ProxyPatternDemo
    public class ProxyPatternDemo
    {
        static void Main_(string[] args)
        {
            ProxyImaga image = new ProxyImaga("proxy.jpg");
            image.Display();
        }
    }
}