namespace DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method
{
    public class FactoryMethodPatternDemo
    {
        public static void Enter()
        {
            IShape circle = ShapeFactory.GetShape(ShapeKind.Circle);
            circle.Draw();
            circle.Fill();

            IShape BigCircle = ShapeFactory.GetShape(ShapeKind.BigCircle);
            BigCircle.Draw();
            BigCircle.Fill();

            IShape Square = ShapeFactory.GetShape(ShapeKind.Square);
            Square.Draw();
            Square.Fill();
        }
    }
}
