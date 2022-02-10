/*
 *  设计模式创建型————工厂模式
 * 
 *  意图：{ 定义一个用于创建对象的接口，让子类决定实例化哪一个类。
 *         FactoryMethod 使得一个类的实例化延迟到子类。}
 *         
 *  动机：{ 1. 在软件系统中，经常面临着“某个对象”的创建工作；由于需求的变化，
 *         这个对象的具体实现经常面临着剧烈的变化，但是它却拥有比较稳定的接口。
 *         
 *         2. 如何应对这种变化？如何提供一种“封装机制"来隔离出“这个易变对象”的
 *         变化，从而保持系统中“其他依赖该对象的对象"不随着需求改变而改变? }
 */

using System;

namespace Ychao.Learn.DesignPattern.CreationalPattern
{
    //---------------------------------------Base interface and implements
    public interface IProduct
    {
        void Func();
    }
    public class ProductA : IProduct
    {
        public void Func()
        {
            //Do produce A..
        }
    }
    public class ProductB : IProduct
    {
        public void Func()
        {
            //Do produce B..
        }
    }
    public class ProductC : IProduct
    {
        public void Func()
        {
            //Do produce C..
        }
    }
    //---------------------------------------Base Factory and implements
    public abstract class ProductFactory
    {
       public static IProduct Produce(ProductFactory factory)
        {
            return factory.GetProduce();
        }
        public abstract IProduct GetProduce();
    }
    public class ProductAFactory : ProductFactory
    {
        public override IProduct GetProduce()
        {
            return new ProductA();
        }
    }
    public class ProductBFactory : ProductFactory
    {
        public override IProduct GetProduce()
        {
            return new ProductB();
        }
    }
    public class ProductCFactory : ProductFactory
    {
        public override IProduct GetProduce()
        {
            return new ProductC();
        }
    }
    //---------------------------------------FactoryPattern Demo
    public class FactoryPatternDemo
    {
        static void Main_(string[] args)
        {
            //里氏替换原则
            IProduct pA = ProductFactory.Produce(new ProductAFactory());
            pA.Func();
            IProduct pB = ProductFactory.Produce(new ProductBFactory());
            pB.Func();
            IProduct pC = ProductFactory.Produce(new ProductCFactory());
            pC.Func();
        }
    }
}
