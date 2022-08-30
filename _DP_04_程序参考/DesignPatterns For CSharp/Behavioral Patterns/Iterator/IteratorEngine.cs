namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Iterator
{
    /// <summary>
    /// 定义迭代器遍历
    /// </summary>
    public static class IteratorEngine
    {
        public static void Execute<T>(Iterable<T> iterator, Action<T> function)
        {
            Iterator<T> _iterator = iterator.GetIterator();
            for (_iterator.First(); !_iterator.IsDone(); _iterator.Next())
            {
                function(_iterator.CurrentItem);
            }
        }
    }
}
