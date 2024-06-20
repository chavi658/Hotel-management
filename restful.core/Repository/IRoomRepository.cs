
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Repository
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAllRoomsAsyncs();
        Task<Room> AddRoomAsync(Room value);
        Task<Room> UpdateRoomAsync(int id, Room room);
        Task<Room> GetByIdAsync( int id);
        Task DeleteRoomAsync(int id);

    }
}
