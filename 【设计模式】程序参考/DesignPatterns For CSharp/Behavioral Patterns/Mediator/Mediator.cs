/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————中介者模式
 * 
 *  意图：{ 用一个中介对象来封装—系列的对象交互。中介者使各对象不需要显式地相互引用，
 *          从而使其耦合松散，而且可以独立地改变它们之间的交互。 }
 *         
 *  动机：{ 1. 在软件构建过程中，经常会出现多个对象互相关联交互的情况，对象之间常常
 *          会维持一种复杂的引用关系，如果遇到一些需求的更改，这种直接的引用关系将
 *          面临不断的变化。
 *          
 *          2. 在这种情况下，我们可使用一个 “中介对象” 来管理对象间的关联关系，避免
 *          相互交互的对象之间的紧耦合引用关系，从而更好地抵御变化。}
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Mediator
{
    public interface IMediator
    {
        void ShowMessage(User oriUser, User desUser, string message);
    }
}