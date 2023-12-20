namespace SignalChat.Hubs
{
    public interface IChatClient
    {
        public Task JoinRoom();
        public Task ReceiveMessage(string message);
    }
}
