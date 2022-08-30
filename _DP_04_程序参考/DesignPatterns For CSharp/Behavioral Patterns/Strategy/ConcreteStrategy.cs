namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Strategy
{
    public class AdditionStrategy : IStrategy
    {
        public readonly static AdditionStrategy strategy = new AdditionStrategy();
        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    public class SubstractStrategy : IStrategy
    {
        public readonly static SubstractStrategy strategy = new SubstractStrategy();
        public int DoOperation(int num1, int num2)
        {
            return (num1 - num2);
        }
    }
    public class MultiplyStrategy : IStrategy
    {
        public readonly static MultiplyStrategy strategy = new MultiplyStrategy();
        public int DoOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
    public class DivisionStrategy : IStrategy
    {
        public readonly static DivisionStrategy strategy = new DivisionStrategy();
        public int DoOperation(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}