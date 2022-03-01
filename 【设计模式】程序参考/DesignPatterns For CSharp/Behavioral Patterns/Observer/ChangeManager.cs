namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public interface IChangeManager
    {
        void Register(ISubject subject, IObserver observer);
        void Unregister(ISubject subject, IObserver observer);
        void Notify();
    }
    // Simple: 更新每一个目标的所有观察者
    public class SimpleChangeManager : IChangeManager
    {
        IChangeManager instance;
        ISubject subject;
        List<IObserver> observers;

        public SimpleChangeManager(ISubject subject)
        {
            this.subject = subject;
            observers = new List<IObserver>();
            instance = this;
        }
        public void Notify()
        {
            foreach (IObserver observer in observers)
                observer.Update(subject);
        }
        public void ClearObserver()
        {
            observers.Clear();
        }
        public void Register(IObserver observer)
        {
            instance.Register(subject, observer);
        }
        public void Unregister(IObserver observer)
        {
            instance.Unregister(subject, observer);
        }

        void IChangeManager.Register(ISubject subject, IObserver observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }
        void IChangeManager.Unregister(ISubject subject, IObserver observer)
        {
            observers.Remove(observer);
        }
    }
    // DCG：一个观察者观察多个目标
    public class DCGChangeManager : IChangeManager
    {
        public readonly static DCGChangeManager Instance = new DCGChangeManager();
        Dictionary<ISubject, List<IObserver>> SODic;
        private DCGChangeManager()
        {
            SODic = new Dictionary<ISubject, List<IObserver>>();
        }
        public void Notify()
        {
            foreach (var item in SODic)
                foreach (IObserver observer in item.Value)
                    observer.Update(item.Key);
        }
        public void Register(ISubject subject, IObserver observer)
        {
            if (!SODic.ContainsKey(subject))
            {
                SODic.Add(subject, new List<IObserver>());
                SODic[subject].Add(observer);
            }
            else if (!SODic[subject].Contains(observer))
                SODic[subject].Add(observer);
        }
        public void Unregister(ISubject subject, IObserver observer)
        {
            if (SODic.TryGetValue(subject, out List<IObserver>? list))
            {
                if (list.Contains(observer))
                    list.Remove(observer);
            }
        }
    }
    // 瞬发消息，报告状态
    public class LoggerManager : IChangeManager
    {
        public readonly static LoggerManager Instance = new LoggerManager();
        void IChangeManager.Notify()
        {
            throw new NotImplementedException();
        }
        public void Register(ISubject subject, IObserver observer)
        {
            observer.Update(subject);
        }
        void IChangeManager.Unregister(ISubject subject, IObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
