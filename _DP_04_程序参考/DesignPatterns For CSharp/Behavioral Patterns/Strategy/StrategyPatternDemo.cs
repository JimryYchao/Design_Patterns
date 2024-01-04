using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Strategy
{
    public class StrategyPatternDemo
    {
        public static void Enter()
        {
            Context context = Context.GetInstance(AdditionStrategy.strategy);
            Console.WriteLine("5 + 6 = " + context.Operation(5, 6));
            Console.WriteLine("5 - 6 = " + Context.GetInstance(SubstractStrategy.strategy).Operation(5, 6));
            Console.WriteLine("5 * 6 = " + Context.GetInstance(MultiplyStrategy.strategy).Operation(5, 6));
            Console.WriteLine("5 / 6 = " + Context.GetInstance(DivisionStrategy.strategy).Operation(5, 6));
        }
    }
}