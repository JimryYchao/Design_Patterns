namespace DesignPatterns_For_CSharp.Structural_Patterns.Bridge
{
    public class BridgePatternDemo
    {
        public static void Enter()
        {
            Shape RedCircle = new Shape(new Circle());
            RedCircle.Draw("Red");

            ShapeCollection Squares = new ShapeCollection(new Square(), new string[] { "Red", "Blue", "Black", "Yellow" });
            Squares.Draw();
        }
    }
}
