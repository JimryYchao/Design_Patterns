namespace DesignPatterns_For_CSharp.Creational_Patterns.Builder
{
    public class Director
    {
        Builder builder;
        public Director(Builder builder) => this.builder = builder;
        public Meal? Construct()
        {
            try
            {
                if (builder is VegMealBuilder VmB)
                    return VmB.buildVegMeal();
                else if (builder is ChickenMealBuilder CmB)
                    return CmB.buildChickenMeal();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
