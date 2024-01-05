using System;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    // Colors
    public interface IColor { void fill(); }
    internal enum ColorKind
    {
        None = 0 << 4,
        Red = 1 << 4,
        Green = 2 << 4,
        Blue = 3 << 4,
    }
    internal class Red : IColor
    {
        void IColor.fill() => Console.WriteLine("Fill Red");
    }
    internal class Green : IColor
    {
        void IColor.fill() => Console.WriteLine("Fill Green");
    }
    internal class Blue : IColor
    {
        void IColor.fill() => Console.WriteLine("Fill Blue");
    }
    internal class UnknownColor : IColor
    {
        internal static readonly UnknownColor Default = new UnknownColor();
        void IColor.fill() { }
    }
    // Shapes
    public interface IShape { void draw(); }
    internal enum ShapeKind
    {
        None = 0,
        Circle = 1,
        Square = 2,
        Rectangle = 3
    }
    class Circle : IShape
    {
        void IShape.draw() => Console.WriteLine("Draw a Circle");
    }
    class Square : IShape
    {
        void IShape.draw() => Console.WriteLine("Draw a Square");
    }
    class Rectangle : IShape
    {
        void IShape.draw() => Console.WriteLine("Draw a Rectangle");
    }
    internal class UnknownShape : IShape
    {
        internal static readonly UnknownShape Default = new UnknownShape();
        void IShape.draw() { }
    }
}