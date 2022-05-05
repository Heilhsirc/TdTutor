using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace TdTutor.Models
{
    public class Chat: Hub
    {
        public async Task SendMessage(string room, string user, string message)
        {
            await Clients.Group(room).SendAsync("MensajeRecibido", user, message);
        }

        public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("MostrarQuien", $"Alguien se conecto " +
                $"{Context.ConnectionId}");

        }
    }
}
