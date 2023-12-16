using Microsoft.AspNetCore.SignalR;

namespace Labs.SignalR.Api;

public sealed class ChatHub : Hub<IChatClient>
{
    public override async Task OnConnectedAsync()
    {
        await Clients.All.ReceiveMessage($"{Context.ConnectionId} joined the chat");
    }

    public async Task SendMessage(string message)
    {
        await Clients.All.ReceiveMessage($"{Context.ConnectionId}: {message}");
    }
}

// {"protocol":"json","version":1}[]

// {"arguments":["Test message"],"invocationId":"1","target":"SendMessage","type":1}