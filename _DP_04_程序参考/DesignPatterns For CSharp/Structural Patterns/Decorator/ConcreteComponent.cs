using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Decorator
{
    public class Circle : IShapeComponent
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Circle.");
        }
        public void Fill(string color)
        {
            Console.WriteLine($"Fill with {color}.");
        }
    }
    public class Rectangle : IShapeComponent
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Rectangle.");
        }

        public void Fill(string color)
        {
            Console.WriteLine($"Fill with {color}.");
        }
    }
}