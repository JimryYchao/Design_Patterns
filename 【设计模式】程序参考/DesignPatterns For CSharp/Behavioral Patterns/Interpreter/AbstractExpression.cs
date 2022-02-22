/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————解释器模式
 * 
 *  意图：{ 给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器
 *          使用该表示来解释语言中的句子 }
 *         
 *  动机：{ 1. 在软件构建过程中，如果某一特定领域的问题比较复杂，类似的模式不断
 *          重复出现，如果使用普通的编程方式来实现将面临非常频繁的变化。
 *          
 *          2. 在这种情况下，将特定领域的问题表达为某种语法规则下的句子，然后构
 *          建一个解释器来解释这样的句子，从而达到解决问题的目的。}
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Interpreter
{
    // 用于解释四则运算，例如 123+321，123*123 等，数字为终结符，运算符为非终结符
    public interface AritheticExpression
    {
        double Interpret();
    }
}