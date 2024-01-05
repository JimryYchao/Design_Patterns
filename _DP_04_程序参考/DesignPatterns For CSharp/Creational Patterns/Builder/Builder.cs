/* Author ：JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式创建型————建造者模式
 * 
 *  意图：{ 将一个复杂对象的构建与其表示相分离，使得同样的构建过程可以创建不同的表示。}
 *  
 *  动机：{ 1. 在软件系统中，有时候而临着 “一个复杂对象” 的创建工作，其通常由各个部分的子
 *          对象用一定的算法构成；由于需求的变化，这个复杂对象的各个部分经常面临着剧烈的
 *          变化，但是将它们组合在一起的算法却相对稳定。
 *         
 *         2. 如何应对这种变化?如何提供一种 “封装机制” 来隔离出 “复杂对象的各个部分” 的变化，
 *           从而保持系统中的 “稳定构建算法” 不随着需求改变而改变?}
 */

namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    // 为复杂对象的各个组件提供 builder 接口 
    public interface Builder
    {
        Item BuildColdDrink();
        Item BuildBurger();
    }
}
