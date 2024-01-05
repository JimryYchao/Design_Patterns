namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Mediator
{
    public class User
    {
        private string name;
        public string Name
        {
            get => name; set => name = value;
        }
        public User(string name)
        {
            this.name = name;
        }
        public void SendMessage(IMediator room, User desUser, string message)
        {
            room.ShowMessage(this, desUser, message);
        }
    }
}