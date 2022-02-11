namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    public class BuilderPatternDemo
    {
        public static void Enter()
        {
            Meal? mMeal = new Director(VegMealBuilder.builder).Construct();
            mMeal?.ShowItems();
            Console.WriteLine(mMeal?.GetCost());
        }
    }
}
