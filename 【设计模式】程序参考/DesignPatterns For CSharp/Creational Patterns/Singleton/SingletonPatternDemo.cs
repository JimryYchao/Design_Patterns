namespace DesignPatterns_For_CSharp.Creational_Patterns.Singleton
{
    public class SingletonPatternDemo
    {
        public static void Enter()
        {
            MonoSingleton.Instance.Log();
            GameSingleton.Instance.Log();
        }
    }
}
