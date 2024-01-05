namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    internal class ColorFactory
    {
        public static IColor GetColor(ColorKind color)
        {
            return color switch
            {
                ColorKind.Red => new Red(),
                ColorKind.Green => new Green(),
                ColorKind.Blue => new Blue(),
                _ => UnknownColor.Default,
            };
        }
    }
    internal class ShapeFactory
    {
        public static IShape GetShape(ShapeKind shape)
        {
            return shape switch
            {
                ShapeKind.Circle => new Circle(),
                ShapeKind.Rectangle => new Rectangle(),
                ShapeKind.Square => new Square(),
                _ => UnknownShape.Default,
            };
        }
    }







}
