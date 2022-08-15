namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    public class Director
    {
        Builder builder;
        public Director(Builder builder) => this.builder = builder;
        public Meal Construct()
        {
            Meal meal = new Meal();
            meal.AddItem(builder.BuildColdDrink());
            meal.AddItem(builder.BuildBurger());

            return meal;
        }
    }
}
