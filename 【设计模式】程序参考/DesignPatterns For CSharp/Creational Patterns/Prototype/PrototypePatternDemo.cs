namespace DesignPatterns_For_CSharp.Creational_Patterns.Prototype
{
    public class PrototypePatternDemo
    {
        public static void Enter()
        {
            Shape circle = ShapeCache.Instance.getShape("Circle");
            circle?.Draw();
            circle?.Fill("Red");

            Shape Rectangle = ShapeCache.Instance.getShape("Rectangle");
            Rectangle?.Draw();
            Rectangle?.Fill("Blue");
        }
    }
}
