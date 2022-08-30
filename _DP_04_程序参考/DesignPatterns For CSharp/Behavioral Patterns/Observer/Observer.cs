/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————备忘录模式
 * 
 *  意图：{ 定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于
 *          它的对象都得到通知并被自动更新。 }
 *         
 *  动机：{ 1. 在软件构建过程中，我们需要为某些对象建立一种 “通知依赖关系” — 一个对
 *          象 (目标对象) 的状态发生改变，所有的依赖对象 (观察者对象) 都将得到通知。
 *          如果这样的依赖关系过于紧密，将使软件不能很好地抵御变化。
 *          
 *          2. 使用面向对象技术，可以将这种依赖关系弱化，并形成一种稳定的依赖关系。
 *          从而实现软件体系结构的松耦合。}
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}