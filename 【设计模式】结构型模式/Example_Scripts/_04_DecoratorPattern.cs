/*
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

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPattern.StructuralPattern
{
    //--------------------------------------------原有对象接口与实体类
    public abstract class ItemBase
    {
        public abstract void Operation();
    }
    public class Item1 : ItemBase
    {
        public override void Operation()
        {
            //Do operation...
        }
    }
    public class Item2 : Item1
    {
        public void Func()
        {
            //Do Func....
        }
    }
    //--------------------------------------------Item1 Decorator
    public abstract class ItemDecorator : ItemBase
    {
        ItemBase Item;
        public ItemDecorator(ItemBase item)
        {
            this.Item = item;
        }
        public override void Operation()
        {
            Item.Operation();
        }
    }
    public class ItemDecorA: ItemDecorator
    {
        public ItemDecorA(ItemBase item) : base(item) { }

        public override void Operation()
        {
            base.Operation();
            MethodDecorator();
        }

        private void MethodDecorator()
        {
            //Do ......
        }
    }
    //--------------------------------------------DecoratorPatternDemo
    public class DecoratorPatternDemo
    {
        static void Main_(string[] args)
        {
            ItemBase item1 = new ItemDecorA(new Item1());
            item1.Operation();
        }
    }
}