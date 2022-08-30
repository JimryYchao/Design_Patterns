using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method
{
    public class SquareCreator : ICreator
    {
        public IShape getShape() => new Square();
    }
    public class RectangleCreator : ICreator
    {
        public IShape getShape() => new Rectangle();
    }
    public class BigCircleCreator : Creator
    {
        private void SetRadius() => Console.WriteLine("Set Radius to 10");
        public override IShape getShape()
        {
            SetRadius();
            return base.getShape();
        }
    }
}
