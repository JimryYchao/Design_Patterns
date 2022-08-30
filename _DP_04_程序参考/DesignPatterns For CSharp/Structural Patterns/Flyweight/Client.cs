namespace DesignPatterns_For_CSharp.Structural_Patterns.Flyweight
{
    public class Client
    {
        public void BuildCircles()
        {
            Circle redCircle = (Circle)FlyweightFactory.Instance.GetCircle("Red");
            CircleAddition greenBigCircle = (CircleAddition)FlyweightFactory.Instance.GetSpecialCircle("Green");
            redCircle.Draw();
            redCircle.Fill();
            redCircle.SetPos(0, 0);
            greenBigCircle.SetRadius(10);
            greenBigCircle.Draw();
            greenBigCircle.Fill();
            greenBigCircle.SetPos(100, 0);
        }
        public void BuildCircle()
        {
            Circle redCircle = (Circle)FlyweightFactory.Instance.GetCircle("Red");
            redCircle.Draw();
            redCircle.Fill();
            redCircle.SetPos(10, 10);
        }
    }
}