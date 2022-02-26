namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Iterator
{
    public partial class ConcreteAggregate<T> : IAggregate<T>, Iterable<T>
    {
        protected T[] array;
        protected const int defaultCapacity = 4;
        protected int size;
        public ConcreteAggregate() : this(defaultCapacity) { }

        public ConcreteAggregate(int Capacity)
        {
            if (Capacity < defaultCapacity)
                Capacity = defaultCapacity;
            array = new T[Capacity];
            size = 0;
        }
        public int Count => size;
        public int Capacity => array.Length;
        void EnsureCapacity()
        {
            if (size >= array.Length)
            {
                T[] newArray = new T[array.Length * 2];
                Array.Copy(array, 0, newArray, 0, array.Length);
                array = newArray;
            }
        }
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            EnsureCapacity();
            array[size++] = item;
        }
        public void Clear()
        {
            Array.Clear(array, 0, Count);
        }
        public bool Contains(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            for (int i = 0; i < size; i++)
                if (item.Equals(array[i]))
                    return true;
            return false;
        }
        public bool Remove(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            for (int i = 0; i < size; i++)
            {
                if (item.Equals(array[i]))
                {
                    if (i < size - 1)
                        Array.Copy(array, i + 1, array, i, size - i);
                    else
                        array[i] = default;
                    --size;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 表示创建一个该聚合对象的对应迭代器
        /// </summary>
        Iterator<T> Iterable<T>.GetIterator()
        {
            return new AggregateIterator(this);
        }
    }
}