namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Mediator
{
    public class MediatorPatternDemo
    {
        public static void Enter()
        {
            User Tom = new User("Tom");
            User Lily = new User("Lily");

            Tom.SendMessage(PrivateChatRoom.Instance, Lily, "Hi! Lily!");
            Lily.SendMessage(PrivateChatRoom.Instance, Tom, "Hello! Tom!");

            Tom.SendMessage(PublicChatRoom.Instance, null, "Chat in Public Room.");
        }
    }
}