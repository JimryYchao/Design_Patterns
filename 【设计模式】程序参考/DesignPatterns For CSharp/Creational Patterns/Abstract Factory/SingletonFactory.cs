namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    internal class ColorFactory
    {
        internal static readonly ColorFactory Instance = new ColorFactory();
        private ColorFactory() { }
        internal IColor getColorRed() => new Red();
        internal IColor getColorGreen() => new Green();
        internal IColor getColorBlue() => new Blue();

        class Red : IColor
        {
            void IColor.fill() => Console.WriteLine("Fill Red");
        }
        class Green : IColor
        {
            void IColor.fill() => Console.WriteLine("Fill Green");
        }
        class Blue : IColor
        {
            void IColor.fill() => Console.WriteLine("Fill Blue");
        }
    }
    internal class ShapeFactory
    {
        internal static readonly ShapeFactory Instance = new ShapeFactory();
        private ShapeFactory() { }
        internal IShape getShapeCircle() => new Circle();
        internal IShape getShapeSquare() => new Square();
        internal IShape getShapeRectangle() => new Rectangle();

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
    }
}
