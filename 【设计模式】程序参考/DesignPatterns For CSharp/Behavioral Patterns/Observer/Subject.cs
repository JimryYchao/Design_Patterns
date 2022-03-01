namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public interface ISubject
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
    }
}
