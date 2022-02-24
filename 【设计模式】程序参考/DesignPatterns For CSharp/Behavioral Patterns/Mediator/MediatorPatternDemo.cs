namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Mediator
{
    public class MediatorPatternDemo
    {
        public static void Enter()
        {
            User Tom = new User("Tom");
            User Lily = new User("Lily");

            Tom.SendMessage(PrivateChatRoom.Instance, "Hi! Lily!");
            Lily.SendMessage(PrivateChatRoom.Instance, "Hello! Tom!");

            Tom.SendMessage(PublicChatRoom.Instance, "Chat in Public Room.");
        }
    }
}