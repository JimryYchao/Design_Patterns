/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————模板方法模式
 * 
 *  意图：{ 定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。Template Method 使
 *          得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。 }
 *         
 *  动机：{ 1. 在软件构建过程中，对于某一项任务，它常常有稳定的整体操作结构，但各个子
 *          步骤却有很多改变的需求，或者由于固有的原因（比如框架与应用之间的关系）而无
 *          法和任务的整体结构同时实现。
 *          
 *          2. 如何在确定稳定操作结构的前提下，来灵活应对各个子步骤的变化或者晚期实现
 *          需求？}
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Template_Method
{
    public abstract class TemplateAbstract
    {
        // 定义模板方法
        public void TemplateMethod()
        {
            PrimitiveOperation_1();
            PrimitiveOperation_2();

            hook();
        }
        protected abstract void PrimitiveOperation_1();
        protected abstract void PrimitiveOperation_2();
        // 钩子操作，缺省行为
        protected virtual void hook() { }
    }
}