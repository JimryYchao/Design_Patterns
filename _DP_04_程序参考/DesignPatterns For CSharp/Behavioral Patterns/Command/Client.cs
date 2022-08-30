namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Command
{
    public class Client
    {
        public void BuildCommands()
        {
            // 创建一个具体的命令对象并设定它的接收者
            ICommand c = new ConcreteCommand(new BuyStock(new Stock("book", 10)));
            // 关联 Invoker 并控制执行/撤销操作
            Invoker.Instance.StoreCommand(c);
            Invoker.Instance.StoreCommand(new ConcreteCommand(new BuyStock(new Stock("pencil", 15))));
            Invoker.Instance.StoreCommand(new ConcreteCommand(new SellStock(new Stock("pen", 18))));
        }
    }
}
