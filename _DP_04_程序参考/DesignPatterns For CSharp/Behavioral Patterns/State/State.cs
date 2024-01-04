/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————状态模式
 * 
 *  意图：{ 允许一个对象在其内部状态改变时改变它的行为。对象看起来似乎修改了它的类。 }
 *         
 *  动机：{ 1. 在软件构建过程中，某些对象的状态如果改变，其行为也会随之而发生变化，比
 *          如文档处于只读状态，其支持的行为和读写状态支持的行为就可能完全不同。
 *          
 *          2. 如何在运行时根据对象的状态来透明地更改对象的行为? 而不会为对象操作和
 *          状态转化之间引入紧耦合? }
 */

using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.State
{
    /// <summary>
    /// TCP 状态的缺省行为
    /// </summary>
    internal abstract class TCPState
    {
        public virtual void Connect(TCPConnection connection) { }
        public virtual void Receive(TCPConnection connection, out byte[]? buffer) => buffer = null;
        public virtual void Close(TCPConnection connection) { }
        public virtual void SendMessage(TCPConnection connection, byte[] buffer) { }
        protected virtual void ChangeState(TCPConnection connection, TCPState state)
        {
            Console.WriteLine($"Switch state to >> {state}");
            connection.ChangeState(state);
        }
    }
}
