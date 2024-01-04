/* Author : JimryYchao
 * Email : 17889982535@163.com
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

using System.Collections.Generic;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Proxy
{
    public class ImageProxy : Image
    {
        public List<Image> Images;
        public ImageProxy()
        {
            Images = new List<Image>();
        }
        public void display()
        {
            foreach (var image in Images)
                image.display();
        }
        public void loadFromDisk()
        {
            foreach (var item in Images)
                item.loadFromDisk();
        }
        public void AddImage(Image image)
        {
            Images.Add(image);
        }
        public bool Remove(Image image)
        {
            return Images.Remove(image);
        }
    }
}