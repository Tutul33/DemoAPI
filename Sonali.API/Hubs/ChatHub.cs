using Microsoft.AspNetCore.SignalR;
using Sonali.API.Utilities.FileManagement;
using System.ServiceModel.Channels;

namespace Sonali.API.Hubs
{
    public class ChatHub : Hub
    {
        private static readonly Dictionary<string, string> userConnections = new();
        private readonly IFileManager _fileManager;

        public ChatHub(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }
        public static string? GetConnectionId(string username)
        {
            userConnections.TryGetValue(username, out var connId);
            return connId;
        }

        public override Task OnConnectedAsync()
        {
            var username = Context.GetHttpContext()?.Request.Query["username"].ToString();
            if (!string.IsNullOrEmpty(username))
            {
                userConnections[username] = Context.ConnectionId;
            }

            // notify all clients about active users
            Clients.All.SendAsync("ActiveUsers", userConnections.Keys.ToList());

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var user = userConnections.FirstOrDefault(x => x.Value == Context.ConnectionId).Key;
            if (user != null)
            {
                userConnections.Remove(user);
                Clients.All.SendAsync("ActiveUsers", userConnections.Keys.ToList());
            }

            return base.OnDisconnectedAsync(exception);
        }

    }
}
