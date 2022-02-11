using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            public override IColor getColor() => ColorFactory.Instance.getColorRed();
            public override IShape getShape() => ShapeFactory.Instance.getShapeCircle();
        }
        class GreenSquareFactory : AbstractFactory
        {
            public override IColor getColor() => ColorFactory.Instance.getColorGreen();
            public override IShape getShape() => ShapeFactory.Instance.getShapeSquare();
        }
        class BlueRectangleFactory : AbstractFactory
        {
            public override IColor getColor()=> ColorFactory.Instance.getColorBlue();
            public override IShape getShape()=> ShapeFactory.Instance.getShapeRectangle();
        }
    }
}
