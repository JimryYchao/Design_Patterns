namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    public class BuilderPatternDemo
    {
        public static void Enter()
        {
            Director vegMealBuilder = new Director(VegMealBuilder.builder);
            Meal mMeal = vegMealBuilder.Construct();
            Console.WriteLine("---- LIST ----");
            mMeal.ShowItems();
            Console.WriteLine("---- PACKING ----");
            mMeal.MakeItems();
            Console.WriteLine("---- COST ----");
            Console.WriteLine(mMeal.GetCost());
        }
    }
}
