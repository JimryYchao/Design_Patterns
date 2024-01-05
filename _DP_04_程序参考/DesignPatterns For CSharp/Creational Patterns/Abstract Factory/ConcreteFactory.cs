using System.Collections.Generic;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    public enum ProductKind
    {
        RedCircle,
        GreenSquare,
        BlueRectangle
    }
    public class FactoryProducer
    {
        static Dictionary<ProductKind, AbstractFactory> factorys = new Dictionary<ProductKind, AbstractFactory>();

        public static AbstractFactory GetFactory(ProductKind kind)
        {
            if (factorys.ContainsKey(kind))
                return factorys[kind];
            else
            {
                factorys.Add(kind, CteateFactory(kind));
                return GetFactory(kind);
            }
        }

        static AbstractFactory CteateFactory(ProductKind kind)
        {
            return kind switch
            {
                ProductKind.RedCircle => new ProductFactory(ShapeKind.Circle, ColorKind.Red),
                ProductKind.GreenSquare => new ProductFactory(ShapeKind.Square, ColorKind.Green),
                ProductKind.BlueRectangle => new ProductFactory(ShapeKind.Rectangle, ColorKind.Blue),
                _ => new ProductFactory(ShapeKind.None, ColorKind.None)
            };
        }
    }
}
