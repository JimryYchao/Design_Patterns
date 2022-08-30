namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    public class AbstractFactoryPatternDemo
    {
        public static void Enter()
        {
            AbstractFactory redCircleFactory = FactoryProducer.Instance.getRedCircle();
            redCircleFactory.getShape().draw();
            redCircleFactory.getColor().fill();
        }
    }
}
