namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Visitor
{
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor computer)
        {
            computer.Visit(this);
        }
        public void Operation()
        {
            Console.WriteLine("Using Keyboard");
        }
    }
    public class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computer)
        {
            computer.Visit(this);
        }
        public void Operation()
        {
            Console.WriteLine("Using Monitor");
        }
    }
    public class Mouse : IComputerPart
    {
        public void Accept(IComputerPartVisitor computer)
        {
            computer.Visit(this);
        }
        public void Operation()
        {
            Console.WriteLine("Using Mouse");
        }
    }
}
