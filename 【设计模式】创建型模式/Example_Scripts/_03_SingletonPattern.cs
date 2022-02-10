/*
 *  设计模式创建型————单例模式
 * 
 *  意图：{ 保证一个类仅有一个实例，并提供一个该实例的局访问点。}
 *  
 *  动机：{ 1. 在软件系统中，经常有这样一些特殊的类，必须保证它们在系统中
 *         只存在一个实例，才能确保它们的逻辑正确性、以及良好的效率。
 *         
 *         2. 如何绕过常规的构造器，提供一种机制来保证一个类只有一个实例?
 *         
 *         3.这应该是类设计者的责任，而不是使用者的责任。}
 */

using System;

namespace Ychao.Learn.DesignPattern.CreationalPattern
{
    //------------------------------------方法单例,非线程安全
    public class Singleton1
    {
        private static Singleton1 instance;
        private Singleton1() { }
        public static Singleton1 getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
    }
    //------------------------------------属性单例,非线程安全
    public class Singleton2
    {
        private static Singleton2 instance;
        private Singleton2() { }
        public static Singleton2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton2();
                }
                return instance;
            }
        }
    }
    //------------------------------------内联单例, 不加锁的线程安全
    public class Singleton3
    {
        public static readonly Singleton3 Instance = new Singleton3();
        private Singleton3() { }
    }
    //------------------------------------可传参单例模式
    public class Singleton4
    {
        private static Singleton4 instance;
        int x, y;
        public static Singleton4 getInstance(int x, int y)
        {
            if (instance == null)
            {
                instance = new Singleton4(x, y);
            }
            else
            {
                instance.x = x;
                instance.y = y;
            }
            return instance;
        }
        private Singleton4(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    //------------------------------------加锁的多线程安全
    public class Singleton5
    {
        private static volatile Singleton5 instance = null;
        private static object lockHelper = new object();
        public static Singleton5 Instance
        {
            get
            {
                if (Instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton5();
                        }
                    }
                }
                return instance;
            }
        }
        private Singleton5() { }
    }
    //------------------------------------延时实例化单例 Lazy
    public class Singleton6
    {
        private static readonly Lazy<Singleton6> lazy = 
            new Lazy<Singleton6>(() => new Singleton6());
        public static Singleton6 Instance => lazy.Value;
        private Singleton6() { }
    } 
    //------------------------------------SingletonPatternDemo
    public class SingletonPatternDemo
    {
        static void Main_(string[] args)
        {
            Singleton1.getInstance().ToString();
            Singleton2.Instance.ToString();
            Singleton3.Instance.ToString();
            Singleton4.getInstance(0, 0).ToString();
            Singleton5.Instance.ToString();
            Singleton6.Instance.ToString();
        }
    }
}