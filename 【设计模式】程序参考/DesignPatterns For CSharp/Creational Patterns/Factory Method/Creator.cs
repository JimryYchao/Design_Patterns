/* Author ：JimryYchao
 * Email : 17889982535@163.com
 * 
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
namespace DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method
{
    public class Creator : ICreator
    {
        // 默认(缺省)行为
        public virtual IShape getShape() => new Circle();
    }
    // 或纯抽象定义接口
    public interface ICreator
    {
        IShape getShape();
    }
}
