/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式结构型————装饰器模式
 * 
 *  意图：{ 动态地给一个对象增加一些额外的职责。就增加功能而言, Decorator模式比生成子类
 *          更为灵活。}
 *         
 *  动机：{ 1. 过度地使用了继承来扩展对象的功能”，由于继承为类型引入的静态特质，使得这种
 *          扩展方式缺乏灵活性；并且随着子类的增多(扩展功能的增多)，各种子类的组合(扩展
 *          功能的组合)会导致更多子类的膨胀(多继承)
 *         
 *         2. 如何使“对象功能的扩展”能够根据需要来动态地实现？ 同时避免“扩展功能的增多"
 *         带来的子类膨胀问题?从而使得任何“功能扩展变化"所导致的影响将为最低?}
 */

namespace DesignPatterns_For_CSharp.Structural_Patterns.Decorator
{
    public abstract class Decorator : IShapeComponent
    {
        IShapeComponent ShapeComponent;
        public Decorator(IShapeComponent shape) { ShapeComponent = shape; }
        public virtual void Draw()
        {
            ShapeComponent.Draw();
        }

        public virtual void Fill(string color)
        {
            ShapeComponent.Fill(color);
        }
    }
}