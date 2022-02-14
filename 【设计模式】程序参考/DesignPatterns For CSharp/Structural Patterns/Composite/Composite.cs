/* Author ：JimryYchao
 * Email ：17889982535@163.com
 * 
 *  设计模式结构型————组合模式
 * 
 *  意图：{ 将对象组合成树形结构以表示“部分—整体” 的层次结构。Composite使得用户对单
 *          个对象和组合对象的使用具有一致性。}
 *         
 *  动机：{ 1. 客户代码过多地依赖于对象容器复杂的内部实现结构，对象容器内部实现结构(而
 *         非抽象接口)的变化将引起客户代码的频繁变化，带来了代码的维护性、扩展性等弊端。
 *         
 *         2. 如何将“客户代码与复杂的对象容器结构”解耦？让对象容器自己来实现自身的复杂
 *         结构，从而使得客户代码就像处理简单对象一样来处理复杂的对象容器? }
 */

namespace DesignPatterns_For_CSharp.Structural_Patterns.Composite
{
    public class Composite : IComponent
    {
        protected List<IComponent> subComposites = new List<IComponent>();
        private bool _isleaf;
        public Composite(bool isLeaf)
        {
            this._isleaf = isLeaf;
        }
        public bool isLeaf { get => _isleaf; set => _isleaf = value; }
        public virtual int Add(IComponent component)
        {
            if (isLeaf)
                return -1;
            if (component == null)
                return -1;
            if (!subComposites.Contains(component))
            {
                subComposites.Add(component);
                return subComposites.Count;
            }
            else return -1;
        }
        public virtual void Add(params IComponent[] components)
        {
            foreach (var component in components)
                Add(component);
        }
        public virtual IComponent GetChild(int index)
        {
            if (isLeaf)
                throw new InvalidOperationException("This is a Leaf node");
            if (index < 0 || index > subComposites.Count)
                throw new ArgumentOutOfRangeException("index");
            return subComposites[index];
        }
        protected virtual void DoWork() { }
        public virtual void Operation()
        {
            if (!isLeaf)
                foreach (var em in subComposites)
                    em.Operation();
            DoWork();
        }
        public virtual bool Remove(IComponent component)
        {
            if (isLeaf)
                return false;
            return subComposites.Remove(component);
        }
    }
}