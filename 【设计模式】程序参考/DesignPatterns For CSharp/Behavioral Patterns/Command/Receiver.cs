namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Command
{
    public struct Stock
    {
        public string Name;
        public int Quantity;
        public Stock(string name, int quantity)
        {
            Name = name; Quantity = quantity;
        }
    }
    public interface IReceiver
    {
        void Action();
    }
    public class BuyStock : IReceiver
    {
        Stock stock;
        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }
        public void BuyStocks()
        {
            Console.WriteLine($"Buy {stock.Quantity} Stocks which name is {stock.Name}");
        }
        public void Action()
        {
            BuyStocks();
        }
    }
    public class SellStock : IReceiver
    {
        Stock stock;
        public SellStock(Stock stock)
        {
            this.stock = stock;
        }
        public void SellStocks()
        {
            Console.WriteLine($"Sell {stock.Quantity} Stocks which name is {stock.Name}");
        }
        public void Action()
        {
            SellStocks();
        }
    }
}
