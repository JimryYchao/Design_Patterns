using System;
using System.Collections.Generic;

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
        public Shape GetShapeByWiseClone(string Key)
        {
            if (!shapeMap.TryGetValue(Key, out Prototype proto))
            {
                Console.WriteLine($"Clone {Key} failed");
                return null;
            }
            return proto.WiseClone();
        }
        public Shape GetShapeByDeepClone(string Key)
        {
            if (!shapeMap.TryGetValue(Key, out Prototype proto))
            {
                Console.WriteLine($"Clone {Key} failed");
                return null;
            }
            return proto.DeepClone();
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
