namespace FClubBarcelona.Hubs
{
    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNet.SignalR.Hubs;

    [HubName("mychatHub")]
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //Called by hub from client
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}