namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public class LoginObserver : IObserver
    {
        public readonly static LoginObserver Observer = new LoginObserver();
        void IObserver.Update(ISubject subject)
        {
            if (subject is Subject loginAccount)
                AccountData.Instance.LoginAccount(loginAccount.GetState(0), loginAccount.GetState(1));
        }
    }
    public class RegisterObserver : IObserver
    {
        public readonly static RegisterObserver Observer = new RegisterObserver();
        void IObserver.Update(ISubject subject)
        {
            if (subject is Subject register)
                AccountData.Instance.RegisterAccount(register.GetState(0), register.GetState(1));
        }
    }
    public class LoginSuccessful : IObserver
    {
        public readonly static LoginSuccessful Observer = new LoginSuccessful();
        void IObserver.Update(ISubject subject)
        {
            Console.WriteLine("Login Successful");
        }
    }
    public class LoginFailed : IObserver
    {
        public readonly static LoginFailed Observer = new LoginFailed();
        void IObserver.Update(ISubject subject)
        {
            Console.WriteLine("Login Failed");
        }
    }
    public class RegisterSuccessful : IObserver
    {
        public readonly static RegisterSuccessful Observer = new RegisterSuccessful();
        void IObserver.Update(ISubject subject)
        {
            Console.WriteLine("Register-Account Successful");
        }
    }
    public class RegisterFailed : IObserver
    {
        public readonly static RegisterFailed Instance = new RegisterFailed();
        void IObserver.Update(ISubject subject)
        {
            Console.WriteLine("Register-Account Failed");
        }
    }
}