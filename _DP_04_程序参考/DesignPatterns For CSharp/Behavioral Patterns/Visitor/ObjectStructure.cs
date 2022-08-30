namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Visitor
{
    public class Computer : IComputerPart
    {
        IComputerPart[] parts;
        public Computer()
        {
            parts = new IComputerPart[] { new Keyboard(), new Mouse(), new Monitor() };
        }
        public void Accept(IComputerPartVisitor computer)
        {
            for (int i = 0; i < parts.Length; i++)
                parts[i].Accept(computer);
            computer.Visit(this);
        }
    }
}