using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.GroupChatter
{
    public interface IChatRoomService
    {
        Task<Guid> CreateRoom(string connectionid);
        Task<Guid> GetRoom(string connectionid);
        Task<Guid> GetRoomByContextConnection(string connectionid);
        Task AddMessage(Guid roomid, Message message);
        Task<IEnumerable<Message>> GetMessages(Guid roomId);

    }
}
