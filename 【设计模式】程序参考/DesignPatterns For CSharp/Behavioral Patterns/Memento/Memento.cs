/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式行为型————备忘录模式
 * 
 *  意图：{ 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状
 *          态。这样以后就可将该对象恢复到原先保存的状态。 }
 *         
 *  动机：{ 1. 在软件构建过程中，某些对象的状态在转换过程中，可能由于某种需要，要求程
 *          序能够回溯到对象之前处于某个点时的状态。如果使用一些公有接口来让其他对象
 *          得到对象的状态，便会暴露对象的细节实现。
 *          
 *          2. 如何实现对象状态的良好保存与恢复? 但同时又不会因此而破坏对象本身的封
 *          装性。}
 */

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Memento
{
    public class Memento
    {
        Dictionary<string, object> states;
        public int Version { get; private set; }
        public Memento(int version)
        {
            this.Version = version;
            states = new Dictionary<string, object>();
        }
        public object GetState(string identifier)
        {
            if (states.TryGetValue(identifier, out object? value))
                return value;
            return null;
        }
        public void SetState(string identifier, object state)
        {
            states.Add(identifier, state);
        }
    }
}