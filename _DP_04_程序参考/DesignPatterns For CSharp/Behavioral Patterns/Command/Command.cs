/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
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

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Command
{
    public interface ICommand
    {
        void Execute();
    }
}