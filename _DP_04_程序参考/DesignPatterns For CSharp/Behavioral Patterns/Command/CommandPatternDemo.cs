namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Command
{
    public class CommandPatternDemo
    {
        public static void Enter()
        {
            Client client = new Client();
            client.BuildCommands();

            Invoker.Instance.Invoke();
        }
    }
}
