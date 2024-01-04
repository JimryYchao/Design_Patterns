using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Visitor
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer");
        }
        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse");
            mouse.Operation();
        }
        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard");
            keyboard.Operation();
        }
        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor");
            monitor.Operation();
        }
    }
}
