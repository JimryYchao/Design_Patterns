using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Prototype
{
    public class ShapeCache
    {
        public readonly static ShapeCache Instance = new ShapeCache();
        private ShapeCache() { loadCache(); }

        private Dictionary<string, Prototype> shapeMap = new Dictionary<string, Prototype>();
        public void RegisterPrototype(string key, Prototype shape)
        {
            if (!shapeMap.ContainsKey(key))
                shapeMap.Add(key, shape);
        }
        public bool RemovePrototype(string key)
        {
            return shapeMap.Remove(key);
        }
        public  Shape getShape(string Key)
        {
            if (!shapeMap.TryGetValue(Key, out Prototype proto))
            {
                Console.WriteLine($"Clone {Key} failed");
                return null;
            }
            // 自行选择浅拷贝或深拷贝
            return proto?.WiseClone();
        }
        // 一般从配置表读取
        private void loadCache()
        {
            RegisterPrototype("Rectangle", new RectanglePrototype());
            RegisterPrototype("Circle", new DefaultPrototype());
            RegisterPrototype("Square", new SquarePrototype());
        }
    }
}
