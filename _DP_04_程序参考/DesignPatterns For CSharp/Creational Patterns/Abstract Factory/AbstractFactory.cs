/* Author ：JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式创建型————抽象工厂模式
 * 
 *  意图：{ 提供一个接口，让该接口负责创建一系列 “相关或者相互依赖的对象”，无
 *         需指定它们具体的类。}
 *         
 *  动机：{ 1. 在软件系统中，经常面临着 “一系列相互依赖的对象” 的创建工作；同时，
 *         由于需求的变化，往往存在更多系列对象的创建工作。
 *         
 *         2. 如何应对这种变化？如何绕过常规的对象创建方法(new)，提供一种“封
 *         装机制 “来避免客户程序和这种“多系列具体对象创建工作” 的紧耦合? }
 */

namespace DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory
{
    public abstract class AbstractFactory
    {
        internal abstract AbstractProduct GetProduct();
        public void DrawShape()
        {
            GetProduct().DrawShape();
        }
        public class AbstractProduct(IShape shape, IColor color)
        {
            public void DrawShape()
            {
                shape.draw();
                color.fill();
            }
        }
    }
    internal class ProductFactory(ShapeKind shape, ColorKind color) : AbstractFactory
    {
        internal override AbstractProduct GetProduct()
            => new AbstractProduct(
                ShapeFactory.GetShape(shape),
                ColorFactory.GetColor(color));
    }
}