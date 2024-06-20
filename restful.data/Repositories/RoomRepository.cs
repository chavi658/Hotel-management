using CreateApi;
using Microsoft.EntityFrameworkCore;
using restful.core.Repository;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;
        public RoomRepository(DataContext context)
        {
            _context = context;
        }

       
    public async Task<Room> AddRoomAsync(Room value)
        {
            _context.rooms.Add(value);
          await  _context.SaveChangesAsync();
            return value;
        }
        public async Task<Room> GetByIdAsync(int id)
        {
            return await _context.rooms.FindAsync(id);
        }
        public async Task DeleteRoomAsync(int id)
        {
            var Room =await GetByIdAsync(id);
            _context.rooms.Remove(Room);
          await  _context.SaveChangesAsync();
        }
        public async Task<Room> UpdateRoomAsync(int id, Room room)
        {
            var updateRoom =await GetByIdAsync(id);
            if (updateRoom != null)
            {
                updateRoom.Avialable = room.Avialable;

                await _context.SaveChangesAsync();
            }
            return updateRoom;

        }

        public async Task<IEnumerable<Room>> GetAllRoomsAsyncs()
        {
            return await _context.rooms.Include(u => u.GuestId).ToListAsync();
        }

    }
}
