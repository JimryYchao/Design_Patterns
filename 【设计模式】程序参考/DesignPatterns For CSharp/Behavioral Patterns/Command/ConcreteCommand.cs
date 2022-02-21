namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Command
{
    public class ConcreteCommand : ICommand
    {
        IReceiver receiver;
        public ConcreteCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }
        public void Execute()
        {
            receiver.Action();
        }
    }
}
