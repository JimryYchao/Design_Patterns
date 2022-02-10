/*
 *  设计模式创建型————建造者模式
 * 
 *  意图：{ 将一个复杂对象的构建与其表示相分离，使得同样的构建过程可以创建不同的表示。}
 *  
 *  动机：{ 1. 在软件系统中，有时候而临着“一个复杂对象”的创建工作，其通常由各个部分的子
 *          对象用一定的算法构成；由于需求的变化，这个复杂对象的各个部分经常面临着剧烈的
 *          变化，但是将它们组合在一起的算法却相对稳定。
 *         
 *         2. 如何应对这种变化?如何提供一种“封装机制”来隔离出“复杂对象的各个部分”的变化，
 *           从而保持系统中的“稳定构建算法”不随着需求改变而改变?}
 */

using System;
using System.Collections.Generic;

// 案例采用"快餐店套餐选择案例"
namespace Ychao.Learn.DesignPattern.CreationalPattern
{
    //-------------------------------------------------interface Packing and implements
    public interface Packing
    {
        void Pack();
    }
    public class Wrapper : Packing
    {
        public void Pack()
        {
            //Do wrappering....
        }
    }
    public class Bottle : Packing
    {
        public void Pack()
        {
            //Do Bottling...
        }
    }
    //-------------------------------------------------interface: the Base of all foods
    public interface Item
    {
        string name { get; }
        float price { get; }
        Packing packing();
    }
    //-------------------------------------------------Burger and implements
    public abstract class Burger : Item
    {
        public abstract string name
        {
            get;
        }
        public abstract float price
        {
            get;
        }
        public Packing packing()
        {
            return new Wrapper();
        }
    }
    public class VegetableBurger : Burger
    {
        public override string name => "VegetableBurger";
        public override float price => 8.5f;
    }
    public class ChickenBurger : Burger
    {
        public override float price => 15.0f;
        public override string name => "ChickenBurger";
    }
    //-------------------------------------------------ColdDrink and implements
    public abstract class ColdDrink : Item
    {
        public abstract string name { get; }
        public abstract float price { get; }

        public Packing packing()
        {
            return new Bottle();
        }
    }
    public class CokeCola : ColdDrink
    {
        public override string name => "CokeCola";
        public override float price => 3.5f;
    }
    public class PepsiCola : ColdDrink
    {
        public override string name => "PepsiCola";
        public override float price => 3.0f;
    }
    //-------------------------------------------------Meals Builder
    public class Meal
    {
        private List<Item> items;
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public float GetCost()
        {
            float sum = 0;
            foreach (var item in items)
            {
                sum += item.price;
            }
            return sum;
        }
        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.name);
            }
        }
    }
    public class MealBuilder
    {
        public static Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegetableBurger());
            meal.AddItem(new CokeCola());
            return meal;
        }
        public static Meal prepareChicken()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new PepsiCola());
            return meal;
        }
    }
    //---------------------------------------------------BuilderPatternDemo
    public class BuilderPatternDemo
    {
        static void Main_(string[] args)
        {
            Meal meal1 = MealBuilder.prepareVegMeal();
            meal1.ShowItems();
            float price = meal1.GetCost();
        }
    }
}