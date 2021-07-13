namespace Mediator
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}