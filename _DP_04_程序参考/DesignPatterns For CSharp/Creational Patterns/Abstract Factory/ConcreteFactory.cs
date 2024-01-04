namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    internal class FactoryProducer
    {
        internal static readonly FactoryProducer Instance = new FactoryProducer();
        private FactoryProducer() { }

        internal AbstractFactory getRedCircle() => new RedCircleFactory();
        internal AbstractFactory getGreenSquare() => new GreenSquareFactory();
        internal AbstractFactory getBlueRectangle() => new BlueRectangleFactory();

        class RedCircleFactory : AbstractFactory
        {
            IColor AbstractFactory.getColor() => ColorFactory.Instance.getColorRed();
            IShape AbstractFactory.getShape() => ShapeFactory.Instance.getShapeCircle();
        }
        class GreenSquareFactory : AbstractFactory
        {
            IColor AbstractFactory.getColor() => ColorFactory.Instance.getColorGreen();
            IShape AbstractFactory.getShape() => ShapeFactory.Instance.getShapeSquare();
        }
        class BlueRectangleFactory : AbstractFactory
        {
            IColor AbstractFactory.getColor() => ColorFactory.Instance.getColorBlue();
            IShape AbstractFactory.getShape() => ShapeFactory.Instance.getShapeRectangle();
        }
    }
}
