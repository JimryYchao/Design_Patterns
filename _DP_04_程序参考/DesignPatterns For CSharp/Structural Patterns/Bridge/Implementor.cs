/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式结构型————桥接模式
 * 
 *  意图：{ 将抽象部分与实现部分分离，使它们都可以独立地变化。}
 *         
 *  动机：{ 1. 具有了两个变化的维度：一个变化的维度为“实体类的变化”，一个变化的维度
 *         为“抽象部分的变化”。
 *         
 *         2. 如何应对这种“多维度的变化”?如何利用面向对象技术来使得不同维度系统之间可
 *         以轻松地沿着“实现”和“抽象”两个方向变化，而不引入额外的复杂度? }
 */

namespace DesignPatterns_For_CSharp.Structural_Patterns.Bridge
{
    public abstract class DrawAPI
    {
        public abstract void Draw();
        public virtual void Fill(string color) => Console.WriteLine("Fill with " + color);
    }
}