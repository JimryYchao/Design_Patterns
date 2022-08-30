/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————迭代器模式
 * 
 *  意图：{ 提供一个方法顺序访问一个聚合对象中各个元素，而又不需暴露该对象的内部表示 }
 *         
 *  动机：{ 1. 在软件构建过程中，集合对象内部结构常常变化各异。但对于这些集合对象，我
 *          们希望在不暴露其内部结构的同时，可以让外部客户代码透明地访问其中包含的元素；
 *          同时这种 “透明遍历” 也为 “同一种算法在多种集合对象上进行操作” 提供了可能。
 *          
 *          2. 使用面向对象技术将这种遍历机制抽象为 “迭代器对象” 为应对变化中的 “集
 *          合对象” 提供了一种优雅的方式。}
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Iterator
{
    public interface Iterator<T>
    {
        void First();
        void Next();
        bool IsDone();
        T CurrentItem { get; }
    }
    public interface Iterable<T>
    {
        Iterator<T> GetIterator();
    }
}