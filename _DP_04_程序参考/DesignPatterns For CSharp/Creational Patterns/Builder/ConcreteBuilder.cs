namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    public class VegMealBuilder : Builder
    {
        public static readonly VegMealBuilder builder = new VegMealBuilder();
        Item Builder.BuildColdDrink() => new CokeCola();
        Item Builder.BuildBurger() => new VegetableBurger();
    }
    public class ChickenMealBuilder : Builder
    {
        public static readonly ChickenMealBuilder builder = new ChickenMealBuilder();
        Item Builder.BuildColdDrink() => new PepsiCola();
        Item Builder.BuildBurger() => new ChickenBurger();
    }
}
