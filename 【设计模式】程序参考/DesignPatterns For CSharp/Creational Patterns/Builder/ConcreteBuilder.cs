namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    public class VegMealBuilder : Builder
    {
        public static readonly VegMealBuilder builder = new VegMealBuilder();
        private VegMealBuilder() { }
        public override Meal buildChickenMeal()
            => throw new NotImplementedException();
        public override Meal buildVegMeal()
        {

            Meal meal = new Meal();
            meal.AddItem(new VegetableBurger());
            meal.AddItem(new CokeCola());
            return meal;
        }
    }
    public class ChickenMealBuilder : Builder
    {
        public static readonly ChickenMealBuilder builder = new ChickenMealBuilder();
        private ChickenMealBuilder() { }
        public override Meal buildVegMeal()
            => throw new NotImplementedException();
        public override Meal buildChickenMeal()
        {

            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new PepsiCola());
            return meal;
        }
    }
}
