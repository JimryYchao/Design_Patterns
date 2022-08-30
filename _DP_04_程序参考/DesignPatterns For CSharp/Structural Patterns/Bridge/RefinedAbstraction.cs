namespace DesignPatterns_For_CSharp.Structural_Patterns.Bridge
{
    public class ShapeAdvance : Shape
    {
        Action OnDrawCompletedEvent;
        public ShapeAdvance(DrawAPI drawAPI, Action OnDrawCompletedEvent) : base(drawAPI)
        {
            this.OnDrawCompletedEvent = OnDrawCompletedEvent;
        }
        public override void Draw(string color)
        {
            base.Draw(color);
            OnDrawCompletedEvent.Invoke();
        }
    }
}