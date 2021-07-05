using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.GroupChatter
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly Dictionary<Guid, ChatRoom> _roomInfo = new Dictionary<Guid, ChatRoom>();
        private readonly Dictionary<Guid, List<Message>> messageHitory = new Dictionary<Guid, List<Message>>();


        public Task AddMessage(Guid roomid, Message message)
        {
            if (!messageHitory.ContainsKey(roomid))
            {
                messageHitory[roomid] = new List<Message>();
            }

            messageHitory[roomid].Add(message);
            return Task.CompletedTask;
        }

        public Task<Guid> CreateRoom(string connectionid)
        {
            var id = Guid.NewGuid();
            _roomInfo[id] = new ChatRoom
            {
                OwnerConnectionId = connectionid
            };

            return Task.FromResult(id);
        }

        public Task<IEnumerable<Message>> GetMessages(Guid roomId)
        {
            messageHitory.TryGetValue(roomId, out var messages);

            messages = messages ?? new List<Message>();
            var sortedMessage = messages.OrderBy(x => x.sendAt).AsEnumerable();

            return Task.FromResult(sortedMessage);
        }

        public Task<Guid> GetRoom(string connectionId)
        {
            // connectionId = "{" + connectionId + "}";
            Guid key = Guid.Empty;
            ChatRoom value = new ChatRoom();
            foreach (var item in _roomInfo)
            {
                if(item.Key.ToString("D")== connectionId)
                {
                    key = item.Key;
                    value = item.Value;
                }
            }

            var foundRoom = new KeyValuePair<Guid, ChatRoom>(key, value);

            if (foundRoom.Key == Guid.Empty)
                throw new ArgumentException("Invalid connection ID");

            return Task.FromResult(foundRoom.Key);
        }
    }
}
