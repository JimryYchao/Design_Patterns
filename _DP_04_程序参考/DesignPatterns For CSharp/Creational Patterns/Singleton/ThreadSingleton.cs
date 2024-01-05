using System;
using System.Threading;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Singleton
{
    internal class ThreadSingleton(int threadId)
    {
        public int ThreadSingletonID => threadId;
        [ThreadStatic]
        private static ThreadSingleton s_instance;
        public static ThreadSingleton Instance => s_instance ??= new ThreadSingleton(Thread.CurrentThread.ManagedThreadId); 
    }
}
