namespace DesignPatterns_For_CSharp.Structural_Patterns.Bridge
{
    public class ShapeCollection : Shape
    {
        private string[] colors;
        public ShapeCollection(DrawAPI drawAPI, string[] colors) : base(drawAPI)
        {
            this.colors = colors;
        }
        public override void Draw(string color = "")
        {
            // 绘制多个 Shape
            for (int i = 0; i < colors.Length; i++)
                base.Draw(colors[i]);
        }
    }
}
