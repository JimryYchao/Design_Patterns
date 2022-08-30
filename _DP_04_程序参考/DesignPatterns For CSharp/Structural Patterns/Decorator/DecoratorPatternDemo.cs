namespace DesignPatterns_For_CSharp.Structural_Patterns.Decorator
{
    public class DecoratorPatternDemo
    {
        public static void Enter()
        {
            IShapeComponent RedCircle = new ShapeDecorator(new Circle());
            RedCircle.Draw();
            RedCircle.Fill("Red");

            IShapeComponent BlueRectangle = new ShapeDecorator(new Rectangle());
            BlueRectangle.Draw();
            BlueRectangle.Fill("Blue");
        }
    }
}