namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Iterator
{
    // 在内部实现一个迭代器
    public partial class ConcreteAggregate<T>
    {
        internal class AggregateIterator : Iterator<T>
        {
            protected ConcreteAggregate<T> aggregate;
            /// <summary>
            /// 定义游标
            /// </summary>
            protected int index = -1;
            protected T item;
            public AggregateIterator(ConcreteAggregate<T> aggregate)
            {
                this.aggregate = aggregate;
            }
            T Iterator<T>.CurrentItem => item;
            void Iterator<T>.First()
            {
                item = aggregate.array[(index = 0)];
            }
            bool Iterator<T>.IsDone()
            {
                if (index > aggregate.Count)
                    return true;
                return false;
            }
            void Iterator<T>.Next()
            {
                item = aggregate.array[index++];
            }
        }
    }
}