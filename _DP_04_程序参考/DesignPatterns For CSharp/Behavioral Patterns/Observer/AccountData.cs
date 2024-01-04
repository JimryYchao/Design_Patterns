using System.Collections.Generic;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    internal class AccountData : ISubject
    {
        public readonly static AccountData Instance = new AccountData();
        private AccountData()
        {
            Accounts = new Dictionary<string, string>();
        }
        Dictionary<string, string> Accounts;
        IChangeManager changer = LoggerManager.Instance;

        public void LoginAccount(string account, string password)
        {
            if (Accounts.ContainsKey(account))
                if (Accounts[account] == password)
                {
                    Attach(LoginSuccessful.Observer);
                    return;
                }
            Attach(LoginFailed.Observer);
        }
        public void RegisterAccount(string account, string password)
        {
            if (!Accounts.ContainsKey(account))
            {
                Accounts.Add(account, password);
                Attach(RegisterSuccessful.Observer);
            }
            else Attach(RegisterFailed.Instance);
        }
        public void Attach(IObserver o)
        {
            changer.Register(this, o);
        }
        public void Detach(IObserver o)
        {
            changer.Unregister(this, o);
        }
        public void Notify()
        {
            changer.Notify();
        }
    }
}
