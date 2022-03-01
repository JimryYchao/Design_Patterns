namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public class Subject : ISubject
    {
        public readonly static Subject Instance = new Subject();
        private string name = string.Empty;
        private string password = string.Empty;
        public void RegisterAccount(string name, string password)
        {
            this.name = name;
            this.password = password;
            Attach(RegisterObserver.Instance);
        }
        public void LoginAccount(string name, string password)
        {
            this.name = name;
            this.password = password;
            Attach(LoginObserver.Instance);
        }
        public string GetState(int state)
        {
            switch (state)
            {
                case 0:
                    return name;
                case 1:
                    return password;
                default:
                    return string.Empty;
            }
        }
        SimpleChangeManager changeMgr;
        public Subject()
        {
            changeMgr = new SimpleChangeManager(this);
        }
        public void Attach(IObserver o)
        {
            changeMgr.Register(o);
        }
        public void Detach(IObserver o)
        {
            changeMgr.Unregister(o);
        }
        public void Notify()
        {
            changeMgr.Notify();
            changeMgr.ClearObserver();
        }
    }
}
