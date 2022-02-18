namespace DesignPatterns_For_CSharp.Structural_Patterns.Flyweight
{
    public class FlyweightPatternDemo
    {
        public static void Enter()
        {
            Client client = new Client();
            client.BuildCircles();
            client.BuildCircle();
        }
    }
}