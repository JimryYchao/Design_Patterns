namespace DesignPatterns_For_CSharp.Structural_Patterns.Decorator
{
    public class ShapeDecorator : Decorator
    {
        public ShapeDecorator(IShapeComponent shape) : base(shape) { }
        private void OnDraw()
        {
            Console.WriteLine("Before Draw() >> Do...");
        }
        private void OnDrawComplete()
        {
            Console.WriteLine("When Draw Complete >> Do...");
        }
        private void OnFill()
        {
            Console.WriteLine("Before Fill() >> Do...");
        }
        private void OnFillComplete()
        {
            Console.WriteLine("When Fill Complete >> Do...");
        }
        public override void Draw()
        {
            OnDraw();
            base.Draw();
            OnDrawComplete();
        }
        public override void Fill(string color)
        {
            OnFill();
            base.Fill(color);
            OnFillComplete();
        }
    }
}