using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Flyweight
{
    public class CircleAddition : IShape
    {
        private float radius;
        IShape shape;
        public CircleAddition(Circle circle)
        {
            shape = circle;
        }
        public string color => shape.color;
        public void Draw() => shape.Draw();
        public void Fill() => shape.Fill();
        public void SetPos(float x, float y) => shape.SetPos(x, y);
        public void SetRadius(float radius)
        {
            this.radius = radius;
            Console.WriteLine($"Set Radius to {radius}");
        }
    }
}