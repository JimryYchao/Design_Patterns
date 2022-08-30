/* Author ：JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式创建型————原型模式
 * 
 *  意图：{ 使用原型实例指定创建对象的种类，然后通过拷贝这些原型来创建新的对象。}
 *  
 *  动机：{ 1. 在软件系统中，经常面临着"某些结构复杂的对象"的创建工作；由于需求的变化，
 *          这些对象经常面临着剧烈的变化，但是它们却拥有比较稳定一致的接口。
 *         
 *         2. 如何应对这种变化? 如何向“客户程序(使用这些对象的程序)”隔离出这些易变对
 *         象，从而使得“依赖这些易变对象的客户程序”不随着需求改变而改变? }
 */

namespace DesignPatterns_For_CSharp.Creational_Patterns.Prototype
{
    public interface IClone<T>
    {
        T WiseClone();
        T DeepClone();
    }
    public abstract class Prototype : IClone<Shape>
    {
        public abstract Shape DeepClone();
        public abstract Shape WiseClone();
    }
}
