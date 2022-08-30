namespace DesignPatterns_For_CSharp.Creational_Patterns.Prototype
{
    [Serializable]
    public class Shape : ICloneable
    {
        private string id = string.Empty;
        private string type = string.Empty;
        public string ID => id;
        public string Type => type;
        public Shape(string id, string type)
        {
            this.id = id;
            this.type = type;
        }
        public virtual void Draw() { }
        public virtual void Fill(string color) { }
        public object Clone() => MemberwiseClone();
    }
    public class Circle : Shape
    {
        public Circle(string id, string type) : base(id, type) { }
        public override void Draw() => Console.WriteLine("Draw a Circle");
        public override void Fill(string color) => Console.WriteLine("Fill with " + color);
    }
    public class Square : Shape
    {
        public Square(string id, string type) : base(id, type) { }
        public override void Draw() => Console.WriteLine("Draw a Square");
        public override void Fill(string color) => Console.WriteLine("Fill with " + color);
    }
    public class Rectangle : Shape
    {
        public Rectangle(string id, string type) : base(id, type) { }
        public override void Draw() => Console.WriteLine("Draw a Rectangle");
        public override void Fill(string color) => Console.WriteLine("Fill with " + color);
    }
}
