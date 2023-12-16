namespace Labs.SignalR.Api;

public interface IChatClient
{
    Task ReceiveMessage(string message);
}
