using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Iterator
{
    public class IteratorPatternDemo
    {
        public static void Enter()
        {
            ConcreteAggregate<int> arr = new ConcreteAggregate<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            // 校验扩容
            arr.Add(5);
            arr.Add(6);

            IteratorEngine.Execute(arr, (a) =>
            {
                Console.WriteLine("Print : number >> " + a);
            });
        }
    }
}
