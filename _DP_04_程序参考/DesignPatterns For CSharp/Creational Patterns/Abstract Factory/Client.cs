namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    public class AbstractFactoryPatternDemo
    {
        public static void Enter()
        {
            AbstractFactory Factory = FactoryProducer.GetFactory(ProductKind.RedCircle);
            var redCircle = Factory.GetProduct();
            redCircle.DrawShape();

            Factory = FactoryProducer.GetFactory(ProductKind.GreenSquare);
            Factory.DrawShape();
        }
    }
}
