namespace DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method
{
    public class FactoryMethodPatternDemo
    {
        public static void Enter()
        {
            IShape circle = new Creator().getShape();
            circle.Draw();
            circle.Fill();

            IShape BigCircle = new BigCircleCreator().getShape();
            BigCircle.Draw();
            BigCircle.Fill();

            IShape Square = new SquareCreator().getShape();
            Square.Draw();
            Square.Fill();
        }
    }
}
