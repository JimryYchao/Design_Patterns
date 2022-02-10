/*
 *  设计模式结构型————外观模式
 * 
 *  意图：{ 为子系统中的一组接口提供一个一致的界面，Facade模式定义了一个高层接口，这个接
 *         口使得这子系统更加容易使用。}
 *         
 *  动机：{ 1. 组件的客户和组件中各种复杂的子系统有了过多的耦合，随着外部客户程序和各子
 *         系统的演化，这种过多的耦合面临很多变化的挑战。
 *         
 *         2. 如何简化外部客户程序和系统间的交互接口？如何将外部客户程序的演化和内部子系
 *         统的变化之间的依赖相互解耦? }
 */

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPattern.StructuralPattern
{
    //--------------------------------------------内部复杂耦合
    public interface Item
    {
        void Func();
    }
    public class Item1 : Item
    {
        public void Func()
        {
            //Do Item1 Func...
        }
    }
    public class Item2 : Item
    {
        public void Func()
        {
            //Do Item2 Func...
        }
    }
    public class Item3 : Item
    {
        public void Func()
        {
            //Do Item3 Func...
        }
    }
    //-------------------------------------------ItemFacade
    public class ItemFacade
    {
        private Item item1;
        private Item item2;
        private Item item3;

        public ItemFacade()
        {
            item1 = new Item1();
            item2 = new Item2();
            item3 = new Item3();

        }
        public void Item1_Func()
        {
            item1.Func();
        }
        public void Item2_Func()
        {
            item2.Func();
        }
        public void Item3_Func()
        {
            item3.Func();
        }
    }
    //--------------------------------------------FacadePatternDemo
    public class FacadePatternDemo
    {
        static void Main_(string[] args)
        {
            ItemFacade facade = new ItemFacade();
            facade.Item1_Func();
            facade.Item2_Func();
            facade.Item3_Func();
        }
    }
}