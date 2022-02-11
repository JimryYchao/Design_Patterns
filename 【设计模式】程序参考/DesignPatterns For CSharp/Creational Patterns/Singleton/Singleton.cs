/* Author ：JimryYchao
 * Email : 17889982535@163.com
 * 
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

namespace DesignPatterns_For_CSharp.Creational_Patterns.Singleton
{
    // 常规非线程安全单例
    public class Singleton
    {
        private static Singleton instance;
        public static Singleton getInstance() => instance != null ? instance : instance = new Singleton();
    }
    // 线程安全单例
    public class SyncSingleton
    {
        private static SyncSingleton instance;
        private static object sync = new object();
        public static SyncSingleton Instance
        {
            get
            {
                if (instance == null)
                    lock (sync)
                        if (instance == null)
                            instance = new SyncSingleton();
                return instance;
            }
        }
    }
    // 延时单例
    public class LazySingleton
    {
        private static Lazy<LazySingleton> instance;
        public static LazySingleton Instance => instance != null ? instance.Value : (instance = new Lazy<LazySingleton>()).Value;
    }
    // 内联单例
    public class InlineSingleton
    {
        public readonly static InlineSingleton Instance = new InlineSingleton();
    }
}
