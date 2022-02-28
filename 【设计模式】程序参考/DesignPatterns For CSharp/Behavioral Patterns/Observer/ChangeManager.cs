using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public abstract class ChangeManager
    {
        public abstract void Register(ISubject subject, IObserver observer);
        public abstract void Unregister(ISubject subject, IObserver observer);
        public abstract void Notify();
    }
    // Simple: 更新每一个目标的所有观察者
    public class SimpleChangeManager : ChangeManager
    {
        protected Dictionary<ISubject, List<IObserver>> SOPairs;
        public SimpleChangeManager()
        {
            SOPairs = new Dictionary<ISubject, List<IObserver>>();
        }
        public override void Register(ISubject subject, IObserver observer)
        {
            if (SOPairs.ContainsKey(subject))
            {
                if (!SOPairs[subject].Contains(observer))
                    SOPairs[subject].Add(observer);
            }
            else
                SOPairs.Add(subject, new List<IObserver>() { observer });
        }
        public override void Unregister(ISubject subject, IObserver observer)
        {
            if (SOPairs.ContainsKey(subject))
                SOPairs[subject].Remove(observer);
        }
        public override void Notify()
        {
            foreach (var pair in SOPairs)
            {
                ISubject s = pair.Key;
                for (int j = 0; j < pair.Value.Count; j++)
                    pair.Value[j].Update(s);
            }
        }
    }
    // DCG：一个观察者观察多个目标
    public class DCGChangeManager : ChangeManager
    {
        public override void Notify()
        {
            throw new NotImplementedException();
        }

        public override void Register(ISubject subject, IObserver observer)
        {
            throw new NotImplementedException();
        }

        public override void Unregister(ISubject subject, IObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
