namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Strategy
{
    public class Context
    {
        private IStrategy strategy;
        private static Context instance;
        public static Context GetInstance(IStrategy strategy)
        {
            if (instance == null)
                instance = new Context();
            instance.strategy = strategy;
            return instance;
        }
        public int Operation(int num1, int num2)
        {
            return strategy.DoOperation(num1, num2);
        }
    }
}