using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Services
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetRoomsAsync();
        Task<Room> GetByIdAsync(int id);
        Task<Room> AddAsync(Room value);
        Task<Room> UpdateAsync(int id, Room value);
        Task DeleteAsync (int id);
    }

}
