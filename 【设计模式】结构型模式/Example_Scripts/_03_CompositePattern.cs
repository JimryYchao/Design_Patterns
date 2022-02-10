/*
 *  设计模式结构型————组合模式
 * 
 *  意图：{ 将对象组合成树形结构以表示“部分—整体” 的层次结构。Composite使得用户对单
 *          个对象和组合对象的使用具有一致性。}
 *         
 *  动机：{ 1. 客户代码过多地依赖于对象容器复杂的内部实现结构，对象容器内部实现结构(而
 *         非抽象接口)的变化将引起客户代码的频繁变化，带来了代码的维护性、扩展性等弊端。
 *         
 *         2. 如何将“客户代码与复杂的对象容器结构”解耦？让对象容器自己来实现自身的复杂
 *         结构，从而使得客户代码就像处理简单对象一样来处理复杂的对象容器? }
 */

using System;
using System.Collections.Generic;

namespace Ychao.Learn.DesignPattern.StructuralPattern
{
    //--------------------------------------------Component部分
    public class ItemComponent
    {
        public string Name;
        public virtual void Operation()
        {
            //Do self operation.....
            foreach (var item in items)
            {
                item.Operation();
            }
        }

        public List<ItemComponent> items;
        public ItemComponent()
        {
            items = new List<ItemComponent>();
        }
        //----------------------组合树结构
        public void Add(ItemComponent item)
        {
            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }
        public bool Remove(ItemComponent item)
        {
            return items.Remove(item);
        }
        public void RemoveAll()
        {
            items.Clear();
        }
        public ItemComponent GetChild(int index)
        {
            if (index >= items.Count || index < 0)
            {
                Console.WriteLine("Out of index");
                return null;
            }
            return items[index];
        }
        //-----------------------------组合数结构
    }
    //------------------------------------------------Leaves and Composite
    public class Leaf : ItemComponent
    {
        public override void Operation()
        {
            base.Operation();
            //Do child operation......
        }
    }
    public class Composite : ItemComponent
    {
        public override void Operation()
        {
            base.Operation();
            //Do child operation......
        }
    }
    //-------------------------------------------------CompositePatternDemo
    public class CompositePatternDemo
    {
        static void Main_(string[] args)
        {
            ItemComponent item1 = new ItemComponent();
            ItemComponent leaf1 = new Leaf();
            ItemComponent composite = new Composite();

            item1.Add(leaf1);
            item1.Add(composite);

            item1.Operation();
        }
    }
}