using System;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method
{
    public partial class ShapeFactory
    {
        internal class CircleCreator : ICreator
        {
            readonly static CircleCreator s_Instance = new CircleCreator();
            public static ICreator Instance => s_Instance;
            public virtual IShape getShape() => new Circle();
        }
        internal class SquareCreator : ICreator
        {
            readonly static SquareCreator s_Instance = new SquareCreator();
            public static ICreator Instance => s_Instance;
            public virtual IShape getShape() => new Square();
        }
        internal class RectangleCreator : ICreator
        {
            readonly static RectangleCreator s_Instance = new RectangleCreator();
            public static ICreator Instance => s_Instance;
            public virtual IShape getShape() => new Rectangle();
        }
        internal class BigCircleCreator : CircleCreator
        {
            public static new readonly BigCircleCreator Instance = new BigCircleCreator();
            private void SetRadius() => Console.WriteLine("Set Radius to 10");
            public override IShape getShape()
            {
                SetRadius();
                return base.getShape();
            }
        }
    }
}
