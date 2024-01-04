using System;
using System.Collections.Generic;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Flyweight
{
    public class FlyweightFactory
    {
        Dictionary<string, IShape> ShapeDic;
        Dictionary<string, IShape> SpeShapeDic;

        public static readonly FlyweightFactory Instance = new FlyweightFactory();
        private FlyweightFactory()
        {
            ShapeDic = new Dictionary<string, IShape>();
            SpeShapeDic = new Dictionary<string, IShape>();
        }
        public IShape GetCircle(string color)
        {
            if (!ShapeDic.ContainsKey(color))
            {
                IShape circle = CircleFactory.Instance.GetCircle(color);
                ShapeDic.Add(color, circle);
                Console.WriteLine("Create a New Circle Filled with " + color);
            }
            return ShapeDic[color];
        }
        public IShape GetSpecialCircle(string color)
        {
            if (!SpeShapeDic.ContainsKey(color))
            {
                IShape circle = CircleFactory.Instance.GetSpacialCircle(new Circle(color));
                Console.WriteLine("Create a New Special Circle Filled with " + color);
                SpeShapeDic.Add(color, circle);
            }
            return SpeShapeDic[color];
        }
    }
}