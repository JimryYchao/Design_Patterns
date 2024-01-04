using System;
using System.Collections.Generic;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Memento
{
    public class Caretaker
    {
        static Dictionary<int, Memento> MementoDic = new Dictionary<int, Memento>();
        public static void SaveMemento(int version, Memento m)
        {
            MementoDic.Add(version, m);
        }
        public static Memento GetMemento(int version)
        {
            if (MementoDic.TryGetValue(version, out Memento m))
                return m;
            throw new ArgumentNullException("Version");


        }
    }
}