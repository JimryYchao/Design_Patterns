using System;
using System.Collections.Generic;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    // 模拟复杂的内部
    // IPacking
    public interface IPacking
    {
        void Pack();
    }
    internal class Bottle : IPacking
    {
        public void Pack() => Console.WriteLine("Do Bottle");
    }
    internal class Wrapper : IPacking
    {
        public void Pack() => Console.WriteLine("Do Wrapper");
    }
    // Item
    public interface Item
    {
        string name { get; }
        float price { get; }
        IPacking packing();
    }
    internal abstract class Burger : Item
    {
        public abstract string name { get; }
        public abstract float price { get; }
        IPacking Item.packing() => new Wrapper();
    }
    internal abstract class ColdDrink : Item
    {
        public abstract string name { get; }
        public abstract float price { get; }
        IPacking Item.packing() => new Bottle();
    }
    // Burger
    internal class VegetableBurger : Burger
    {
        public override string name => "VegetableBurger";
        public override float price => 8.5f;
    }
    internal class ChickenBurger : Burger
    {
        public override float price => 15.0f;
        public override string name => "ChickenBurger";
    }
    // ColdDrink
    internal class CokeCola : ColdDrink
    {
        public override string name => "CokeCola";
        public override float price => 3.5f;
    }
    internal class PepsiCola : ColdDrink
    {
        public override string name => "PepsiCola";
        public override float price => 3.0f;
    }
    // Meal Porduct
    public class Meal
    {
        private List<Item> items = new List<Item>();
        public void AddItem(Item item) => items.Add(item);


        public void ShowItems()
        {
            foreach (var item in items)
                Console.WriteLine(item.name);
        }
        public void MakeItems()
        {
            foreach (var item in items)
            {
                Console.Write(item.name + " >>> ");
                item.packing().Pack();
            }
        }
        public float GetCost()
        {
            float sum = 0;
            foreach (var item in items)
                sum += item.price;
            return sum;
        }
    }
}