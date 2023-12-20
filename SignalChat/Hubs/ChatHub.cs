using Microsoft.AspNetCore.SignalR;

namespace SignalChat.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        private readonly string _BotUser;

        public ChatHub()
        {
            _BotUser = "ThiGi";
        }
        public async Task JoinRoom()
        {
            //await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);
            await Clients.All.ReceiveMessage("A user has joined");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}
