using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.GroupChatter;
using WebApplication1.Model;

namespace WebApplication1
{
    public class ChatHub : Hub
    {
        IChatRoomService _chatRoomService;

        public ChatHub(IChatRoomService chatRoomService)
        {
            _chatRoomService = chatRoomService;
        }

        public override async Task OnConnectedAsync()
        {
            var roomId = await _chatRoomService.CreateRoom(Context.ConnectionId);
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());

            await Clients.Caller.SendAsync("SendId", roomId.ToString());
            await Clients.Caller.SendAsync("ReceiveMessage", "System", "Welcome to my chat web", DateTimeOffset.UtcNow);
            

            await base.OnConnectedAsync();
        }


        public async Task SendMessage(string chatterName, string content, string connectionId)
        {
            var roomId = await _chatRoomService.GetRoom(connectionId);
            var OldroomId = await _chatRoomService.GetRoomByContextConnection(Context.ConnectionId);

            var message = new Message()
            {
                chatterName = chatterName,
                content = content,
                sendAt = DateTime.UtcNow
            };
            await _chatRoomService.AddMessage(roomId, message);
            //await Groups.AddToGroupAsync(OldroomId.ToString(), OldroomId.ToString());
            if (roomId == OldroomId)
            {
                await Clients.Group(roomId.ToString()).SendAsync("ReceiveMessage", message.chatterName, message.content, message.sendAt);
            }
            else
            {
               // await Groups.AddToGroupAsync(roomId.ToString(), roomId.ToString());
                await Clients.Group(OldroomId.ToString()).SendAsync("ReceiveMessage", message.chatterName, message.content, message.sendAt);
                await Clients.Group(roomId.ToString()).SendAsync("ReceiveMessage", message.chatterName, message.content, message.sendAt);
            }
            
            await Groups.AddToGroupAsync(roomId.ToString(), roomId.ToString());
            
        }

        public async Task LeaveRoom(Guid roomId)
        {

            var chathistory = await _chatRoomService.GetMessages(roomId);
            var roomId1 = await _chatRoomService.GetRoom(roomId.ToString());
            var roomId2 = await _chatRoomService.GetRoomByContextConnection(Context.ConnectionId);
            await Groups.AddToGroupAsync(roomId1.ToString(), roomId1.ToString());

            await Clients.Group(roomId1.ToString()).SendAsync("ChangeId", roomId2);
            await Clients.Caller.SendAsync("ReceiveMessages", chathistory);
        }
    }
}
