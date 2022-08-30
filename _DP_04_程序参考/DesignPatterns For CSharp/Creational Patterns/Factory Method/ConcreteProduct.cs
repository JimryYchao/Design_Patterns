using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method
{
    internal class Circle : IShape
    {
        public void Draw() => Console.WriteLine("Draw a Circle");
        public void Fill() => Console.WriteLine("Fill red");
    }
    internal class Square : IShape
    {
        public void Draw() => Console.WriteLine("Draw a Square");
        public void Fill() => Console.WriteLine("Fill Green");
    }
    internal class Rectangle : IShape
    {
        public void Draw() => Console.WriteLine("Draw a Rectangle");
        public void Fill() => Console.WriteLine("Fill Blue");
    }
}
