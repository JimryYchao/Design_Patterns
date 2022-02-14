namespace DesignPatterns_For_CSharp.Structural_Patterns.Decorator
{
    public interface IShapeComponent
    {
        void Draw();
        void Fill(string color);
    }
}