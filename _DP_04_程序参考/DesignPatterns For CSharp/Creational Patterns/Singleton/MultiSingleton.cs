using System;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Singleton
{
    public abstract class Singleton<T> where T : new()
    {
        protected static T instance;
        public static T Instance => instance != null ? instance : instance = new T();
        public abstract void Log();
    }
    public class MonoSingleton : Singleton<MonoSingleton>
    {
        public override void Log()
        {
            Console.WriteLine("MonoSingleton is Created");
        }
    }
    public class GameSingleton : Singleton<GameSingleton>
    {
        public override void Log()
        {
            Console.WriteLine("GameSingleton is Created");
        }
    }
}
