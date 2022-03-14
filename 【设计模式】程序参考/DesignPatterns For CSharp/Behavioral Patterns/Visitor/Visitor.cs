/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————访问者模式
 * 
 *  意图：{ 表示一个作用于某对象结构中的各元素的操作。它使你可以在不改变各元素的类的前
 *          提下定义作用于这些元素的新操作。 }
 *         
 *  动机：{ 1. 在软件构建过程中，由于需求的改变，某些类层次结构中常常需要增加新的行为 
 *          (方法)，如果直接在基类中做这样的更改，将会给子类带来很繁重的变更负担，甚至
 *          破坏原有设计。
 *          
 *          2. 如何在不更改类层次结构的前提下，在运行时根据需要透明地为类层次结构上的
 *          各个类动态添加新的操作，从而避免上述问题? }
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Visitor
{
    public interface IComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Visitor.Monitor monitor);
    }
}