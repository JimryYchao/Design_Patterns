using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Template_Method
{
    public class ConcreteClassA : TemplateAbstract
    {
        protected override void PrimitiveOperation_1()
        {
            Console.WriteLine($"A：Operation_1");
        }
        protected override void PrimitiveOperation_2()
        {
            Console.WriteLine("A：Operation_2");
        }
    }
    public class ConcreteClassB : TemplateAbstract
    {
        protected override void PrimitiveOperation_1()
        {
            Console.WriteLine("B：Operation_1");
        }
        protected override void PrimitiveOperation_2()
        {
            Console.WriteLine("B：Operation_2");
        }
        protected override void hook()
        {
            Console.WriteLine("B：Override Hook");
        }
    }
}
