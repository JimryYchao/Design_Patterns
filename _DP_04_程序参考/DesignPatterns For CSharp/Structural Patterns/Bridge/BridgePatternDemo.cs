using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Bridge
{
    public class BridgePatternDemo
    {
        public static void Enter()
        {
            Shape RedCircle = new Shape(new Circle());
            RedCircle.Draw("Red");

            Shape Square = new ShapeAdvance(new Square(), () => { Console.WriteLine("Drew Completly"); });
            Square.Draw("Blue");
        }
    }
}
