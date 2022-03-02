/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————策略模式
 * 
 *  意图：{ 定义一系列的算法把它们一个个封装起来，并且使它们可相互替换。策略模式使得
 *          算法可独立于使用它的客户而变化。 }
 *         
 *  动机：{ 1. 在软件构建过程中，某些对象使用的算法可能多种多样，经常改变，如果将这些
 *          算法都编码到对象中，将会使对象变得异常复杂：而且有时候支持不使用的算法也
 *          是一个性能负担。
 *          
 *          2. 如何在运行时根据需要透明地更改对象的算法? 将算法与对象本身解耦，从而
 *          避免上述问题?}
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Strategy
{
    public interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
}