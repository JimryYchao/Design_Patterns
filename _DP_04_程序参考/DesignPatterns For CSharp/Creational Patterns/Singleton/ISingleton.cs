namespace DesignPatterns_For_CSharp.Creational_Patterns.Singleton
{
    public interface ISingleton<T> where T : ISingleton<T>
    {
        static abstract T Instance { get; }
    }
    class SingleClassA : ISingleton<SingleClassA>
    {
        private static readonly SingleClassA s_ins = new SingleClassA();
        public static SingleClassA Instance => s_ins;
    }
    class SingleClassB : ISingleton<SingleClassB>
    {
        private static readonly SingleClassB s_ins = new SingleClassB();
        public static SingleClassB Instance => s_ins;
    }
}
