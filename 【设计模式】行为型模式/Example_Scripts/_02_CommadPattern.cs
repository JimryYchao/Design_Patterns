using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPatterns.BehaviouralPatterns
{
    /*
     *  设计模式行为型————命令模式
     * 
     *  意图：{ 将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化; 
     *          对请求排队或记录请求日志，以及支持可撤销的操作。}
     *         
     *  动机：{ 1. 在软件构建过程中，“行为请求者”与“行为实现者”通常呈现一种“紧耦
     *          合”。但在某些合————比如需要对行为进行“记录、撤销/重做(undo/redo)，
     *          事务”等处理，这种无法抵御变化的紧耦合是不合适的。
     *          
     *          2. 在这种情况下，如何将“行为请求者”与“行为实现者”解耦? 将一组行为
     *          抽象为对象，可以实现二者之间的松耦合。}
     */

    class CommadPattern
    {
        //--------------------------------------请求类
        public class Stock
        {
            private string name = "ABC";
            private int quantity;
            //public Item(string name,int quantity)
            //{
            //    this.name = name;
            //    this.quantity = quantity;
            //}
            public void buy()
            {
                Console.WriteLine("Stock [ Name: " + name + ",Quantity: " + quantity + " ] bought");
            }
            public void sell()
            {
                Console.WriteLine("Stock [ Name: " + name + ",Quantity: " + quantity + " ] sold");
            }
        }
        //--------------------------------------命令执行接口与实体类
        public interface Order
        {
            void execute();
        }
        public class BuyStock : Order
        {
            private Stock abcStock;

            public BuyStock(Stock abcStock)
            {
                this.abcStock = abcStock;
            }
            public void execute()
            {
                abcStock.buy();
            }
        }
        public class SellStock : Order
        {
            private Stock abcStock;

            public SellStock(Stock abcStock)
            {
                this.abcStock = abcStock;
            }

            public void execute()
            {
                abcStock.sell();
            }
        }
        //------------------------------------------命令调用类
        public class Broker
        {
            private List<Order> orderList = new List<Order>();
            public void takeOrder(Order order)//取订单
            {
                orderList.Add(order);
            }
            public void placeOrders()//下订单
            {
                foreach (Order order in orderList)
                {
                    order.execute();
                }
                orderList.Clear();
            }
        }
        //--------------------------------CommadPatternDemo
        public class CommadPatternDemo
        {
            //行为请求与行为执行分离
            static void Main(string[] args)
            {
                Stock abcStock = new Stock();

                BuyStock buyStockOrder = new BuyStock(abcStock);
                SellStock sellStockOrder = new SellStock(abcStock);

                Broker broker = new Broker();
                broker.takeOrder(buyStockOrder);
                broker.takeOrder(sellStockOrder);

                broker.placeOrders();
            }
        }
    }
}
