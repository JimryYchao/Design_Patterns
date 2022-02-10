/*
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

using System;

namespace Ychao.Learn.DesignPattern.StructuralPattern
{
    //---------------------------------------多维度基类部分
    public interface IMethods //桥接部分  
    {
        void Func();
        void Func(object obj);
    }
    public abstract class ItemBase //主体部分
    {
        IMethods iface;
        public ItemBase(IMethods iface)
        {
            this.iface = iface;
        }
        public virtual void DoFunc()
        {
            iface.Func();
        }
        public virtual void DoFunc(object obj)
        {
            iface.Func(obj);
        }
    }
    //-------------------------------------------桥接对象单维度变化
    public class MethodAPIA : IMethods
    {
        public void Func()
        {
            //Do some something...
        }

        public void Func(object obj)
        {
            //Do another something...
        }
    }
    public class MethodAPIB : IMethods
    {
        public void Func()
        {
            //Do some something...
        }

        public void Func(object obj)
        {
            //Do another something...
        }
    }
    //--------------------------------------------主体(实体)对象
    public class ItemA : ItemBase
    {
        //Fields,Methods....
        public ItemA(IMethods method) : base(method) { }
        public override void DoFunc()
        {
            base.DoFunc();
            //Extend ....
        }
    }
    public class ItemB : ItemBase
    {
        public ItemB(IMethods method) : base(method) { }
        public override void DoFunc(object obj)
        {
            base.DoFunc(obj);
            //Extend ....
        }
    }
    //-------------------------------------------BridgePatternDemo
    public class BridgePatternDemo
    {
        static void Main_(string[] args)
        {
            ItemBase item = new ItemA(new MethodAPIA());
            item.DoFunc();
        }
    }
}