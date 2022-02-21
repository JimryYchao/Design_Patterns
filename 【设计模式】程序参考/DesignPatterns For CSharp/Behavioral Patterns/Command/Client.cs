namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Command
{
    public class Client
    {
        public void BuildCommands()
        {
            Invoker.Instance.StoreCommand(new ConcreteCommand(new BuyStock(new Stock("book", 10))));
            Invoker.Instance.StoreCommand(new ConcreteCommand(new BuyStock(new Stock("pencil", 15))));
            Invoker.Instance.StoreCommand(new ConcreteCommand(new SellStock(new Stock("pen", 18))));
        }
    }
}
