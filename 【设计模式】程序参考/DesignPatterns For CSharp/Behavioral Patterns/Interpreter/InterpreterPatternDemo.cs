namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Interpreter
{
    public class InterpreterPatternDemo
    {
        public static void Enter()
        {
            Console.WriteLine(Calculator.Calculate("1+2+3"));

            Console.WriteLine(Calculator.Calculate("2*(1+2)"));

            Console.WriteLine(Calculator.Calculate("2+(1+2*5)"));

            Console.WriteLine(Calculator.Calculate("2*(1+2*6)"));

            Console.WriteLine(Calculator.Calculate("(68*(115+20)+10)"));
        }
    }
}