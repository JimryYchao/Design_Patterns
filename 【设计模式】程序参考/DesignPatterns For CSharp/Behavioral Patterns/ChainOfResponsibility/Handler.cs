/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————责任链模式
 * 
 *  意图：{ 使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合
 *          关系。将这些对象连成一条链，并沿着这条链传递请求，直到有一个对象处
 *          理它为止。}
 *         
 *  动机：{ 1. 在软件构建过程中，一个请求可能被多个对象处理，但是每个请求在运
 *          行时只能有一个接受者，如果显式指定，将必不可少地带来请求发送者与
 *          接受者的紧耦合。
 *         
 *         2. 如何使请求的发送者不需要指定具体的接受者? 让请求的接受者自己在运
 *         行时决定来处理请求，从而使两者解耦。 }
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.ChainOfResponsibility
{
    public abstract class LoggerHandler
    {
        public abstract int Level { get; protected set; }

        public LoggerHandler(int level)
        {
            Level = level;
        }
        public abstract void Log(string message);
    }
}