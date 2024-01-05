using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Flyweight
{
    public class Circle : IShape
    {
        private string _color;
        private float x, y;
        public string color { get => _color; }
        public Circle(string color)
        {
            this._color = color;
        }
        public void Draw()
        {
            Console.WriteLine($"Draw a Circle");
        }
        public void Fill()
        {
            Console.WriteLine("Fill with " + color);
        }

        public void SetPos(float x, float y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"Set Pos to （{x},{y}）");
        }
    }
    public class CircleFactory
    {
        public static CircleFactory Instance => new CircleFactory();
        public IShape GetCircle(string color)
        {
            return new Circle(color);
        }
        public IShape GetSpacialCircle(Circle circle)
        {
            return new CircleAddition(circle);
        }
    }
}