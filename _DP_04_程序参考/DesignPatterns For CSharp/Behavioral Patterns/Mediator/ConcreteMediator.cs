namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Mediator
{
    public class PrivateChatRoom : IMediator
    {
        public readonly static PrivateChatRoom Instance = new PrivateChatRoom();
        public virtual void ShowMessage(User oriUser, User desUser, string message)
        {
            Console.WriteLine($"[{nameof(PrivateChatRoom)}][{oriUser.Name}] sent to [{desUser.Name}]: {message}");
        }
    }
    public class PublicChatRoom : IMediator
    {
        public readonly static PublicChatRoom Instance = new PublicChatRoom();
        public virtual void ShowMessage(User user, User desUser, string message)
        {
            Console.WriteLine($"[{nameof(PublicChatRoom)}][{user.Name}]: {message}");
        }
        public void ShowMessage(User user, string message)
        {
            ShowMessage(user, null, message);
        }
    }
}