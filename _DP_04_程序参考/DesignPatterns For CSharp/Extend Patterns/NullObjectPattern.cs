using System;

namespace DesignPatterns_For_CSharp.Extend_Patterns
{
    public class NullObjectPattern
    {
        public static void Enter()
        {
            RequestProxy.Request("A").Handle();
            RequestProxy.Request("E").Handle();
        }

        internal class RequestProxy
        {
            static string[] mesArr = { "A", "B", "C" };
            internal static Message Request(string message)
            {
                for (int i = 0; i < mesArr.Length; i++)
                    if (mesArr[i].Equals(message))
                        return new MessageHandler(message);
                return new NullObjectClass(message);
            }
        }

        internal abstract class Message
        {
            protected string message;
            public Message(string message) =>
                this.message = message;
            public abstract void Handle();
        }

        internal class MessageHandler : Message
        {
            public MessageHandler(string message) : base(message) { }
            public override void Handle() =>
                Console.WriteLine("Handle Message >>> " + message);
        }
        internal class NullObjectClass : Message
        {
            public NullObjectClass(string message) : base(message) { }
            public override void Handle() { }
        }
    }
}
