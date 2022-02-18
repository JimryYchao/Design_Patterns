/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式结构型————享元模式
 * 
 *  意图：{ 运用共享技术有效地支持大量细粒度的对象。}
 *         
 *  动机：{ 1. 采用纯粹对象方案的问题在于大量细粒度的对象会很快充斥在系统中，从而带来很高
 *         的运行时代价——主要指内存需求方面的代价
 *         
 *         2. 如何在避免大量细粒度对象问题的同时，让外部客户程序仍然能够透明地使用面向对象
 *         的方式来进行操作? }
 */

namespace DesignPatterns_For_CSharp.Structural_Patterns.Flyweight
{
    public interface IShape
    {
        string color { get; }
        void Draw();
        void Fill();
        void SetPos(float x, float y);
    }
}