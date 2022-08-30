namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Visitor
{
    public class VisitorPatternDemo
    {
        public static void Enter()
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
