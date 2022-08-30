namespace DesignPatterns_For_CSharp.Creational_Patterns.Prototype
{
    public class PrototypePatternDemo
    {
        public static void Enter()
        {
            Shape circle = ShapeCache.Instance.GetShapeByDeepClone("Circle");
            circle?.Draw();
            circle?.Fill("Red");

            Shape Rectangle = ShapeCache.Instance.GetShapeByWiseClone("Rectangle");
            Rectangle?.Draw();
            Rectangle?.Fill("Blue");
        }
    }
}
