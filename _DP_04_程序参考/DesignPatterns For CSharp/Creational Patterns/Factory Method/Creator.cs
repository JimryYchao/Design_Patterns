/* Author ：JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式创建型————工厂模式
 * 
 *  意图：{ 定义一个用于创建对象的接口，让子类决定实例化哪一个类。
 *         FactoryMethod 使得一个类的实例化延迟到子类。}
 *         
 *  动机：{ 1. 在软件系统中，经常面临着 “某个对象” 的创建工作；由于需求的变化，
 *         这个对象的具体实现经常面临着剧烈的变化，但是它却拥有比较稳定的接口。
 *         
 *         2. 如何应对这种变化？如何提供一种 “封装机制” 来隔离出 “这个易变对象” 的
 *         变化，从而保持系统中 “其他依赖该对象的对象” 不随着需求改变而改变? }
 */
using System.Collections.Generic;
using System.Reflection;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method
{
    public enum ShapeKind
    {
        None, Circle, Square, Rectangle, BigCircle
    }
    public sealed partial class ShapeFactory
    {
        // 或纯抽象定义接口
        public interface ICreator
        {
            IShape getShape();
            static abstract ICreator Instance { get; }
        }
        // 缺省行为类，用于包装扩展的工厂类
        class Creator : ICreator
        {
            class BaseCreator : ICreator
            {
                readonly static BaseCreator s_creator = new BaseCreator();
                public static ICreator Instance => s_creator;
                IShape ICreator.getShape() => new Circle();
            }
            public static ICreator Instance => BaseCreator.Instance;

            // 设计包装部分
            ICreator s_Creator;
            public Creator(ICreator creator) => this.s_Creator = creator;
            IShape ICreator.getShape() => s_Creator.getShape();
        }
        // 默认 (缺省) 行为, 可以通过扩展更改
        public static ICreator Default = Creator.Instance;
        // 对外接口
        public static IShape GetShape(ShapeKind kind)
        {
            return GetFactory(kind).getShape();
        }
        static Dictionary<ShapeKind, Creator> Factorys = new Dictionary<ShapeKind, Creator>();
        // 标志可以替换成字符串，通过字符串的名称反射扩展的嵌套类型
        static ICreator GetFactory(ShapeKind kind)
        {
            if (kind is ShapeKind.None)
                return Default;
            if (Factorys.ContainsKey(kind))
                return Factorys[kind];
            else
            {
                var type = typeof(ShapeFactory).GetNestedType(kind.ToString() + "Creator", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                if (type is not null)
                {
                    var mem = type.GetMember("Instance", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    if (mem.Length > 0)
                    {
                        object creator = mem[0].MemberType switch
                        {
                            MemberTypes.Property => (mem[0] as PropertyInfo).GetValue(null),
                            MemberTypes.Field => (mem[0] as FieldInfo).GetValue(null),
                            _ => Default
                        };
                        Factorys.Add(kind, new Creator(creator as ICreator));
                        return GetFactory(kind);
                    }
                }
            }
            return Default;
        }
    }
}
