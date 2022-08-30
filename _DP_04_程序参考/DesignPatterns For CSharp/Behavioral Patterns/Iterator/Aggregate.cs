namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Iterator
{
    // 自定义聚合列表
    public interface IAggregate<T> : Iterable<T>
    {
        int Count { get; }
        void Add(T item);
        bool Remove(T item);
        bool Contains(T item);
        void Clear();
    }
}