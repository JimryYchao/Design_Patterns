namespace DesignPatterns_For_CSharp.Structural_Patterns.Bridge
{
    public class Circle : DrawAPI
    {
        public override void Draw() => Console.WriteLine("Draw a Circle");
    }
    public class Square : DrawAPI
    {
        public override void Draw() => Console.WriteLine("Draw a Square");
    }
    public class Rectangle : DrawAPI
    {
        public override void Draw() => Console.WriteLine("Draw a Rectangle");
    }
    public class BigCircle: Circle
    {
        public override void Draw() => Console.WriteLine("Draw a Big Circle");
    }
}

