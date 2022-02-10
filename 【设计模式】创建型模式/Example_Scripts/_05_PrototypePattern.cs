/*
 *  设计模式创建型————原型模式
 * 
 *  意图：{ 使用原型实例指定创建对象的种类，然后通过拷贝这些原型来创建新的对象。}
 *  
 *  动机：{ 1. 在软件系统中，经常面临着"某些结构复杂的对象"的创建工作；由于需求的变化，
 *          这些对象经常面临着剧烈的变化，但是它们却拥有比较稳定一致的接口。
 *         
 *         2. 如何应对这种变化? 如何向“客户程序(使用这些对象的程序)”隔离出这些易变对
 *         象，从而使得“依赖这些易变对象的客户程序”不随着需求改变而改变? }
 */

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPattern.CreationalPattern
{
    //-------------------------------------------------Stable interface(稳定的接口)
    public abstract class Shape
    {
        private string id;
        protected string type;
        public abstract void Draw();
        public string getType() => type;
        public string getId() => id;
        public void setId(string id) => this.id = id;
        public Shape clone()
        {
            Shape clone = null;
            try
            {
                //浅拷贝
                clone = base.MemberwiseClone() as Shape;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return clone;
        }
    }
    //--------------------------------------------------variable object
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }
        public override void Draw()
        {
            Console.WriteLine(value: "Draw a Rectangle");
        }
    }
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }
        public override void Draw()
        {
            Console.WriteLine(value: "Draw a Square");
        }
    }
    //-------------------------------------------------ShapeCache for Clone
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap
        = new Dictionary<string, Shape>();
        public static Shape getShape(string shapeId)
        {
            Shape cachedShape = null;
            if (!shapeMap.TryGetValue(shapeId, out cachedShape))
            {
                Console.WriteLine("Clone shape failed");
                return null;
            }
            return cachedShape.clone() as Shape;
        }
        public static void loadCache()
        {
            Rectangle rec = new Rectangle();
            rec.setId(id: "1");
            shapeMap.Add(rec.getId(), rec);

            Square square = new Square();
            square.setId("2");
            shapeMap.Add(square.getId(), square);
            // other shapes
        }
    }
    //-------------------------------------------------PrototypePatternDemo
    public class PrototypePatternDemo
    {
        static void Main_(string[] args)
        {
            ShapeCache.loadCache();
            Shape clonedShape = ShapeCache.getShape("1");
            Console.WriteLine(clonedShape.getType());
            clonedShape.Draw();
            Shape clonedShape2 = ShapeCache.getShape("1");
            Shape clonedShape3 = ShapeCache.getShape("1");
            Shape clonedShape4 = ShapeCache.getShape("1");
            Shape clonedShape5 = ShapeCache.getShape("1");
        }
    }
}