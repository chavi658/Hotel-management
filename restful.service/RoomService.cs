using restful.core.Repository;
using restful.core.Services;
using restful.Entities;
using static restful.service.RoomService;


namespace restful.service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<Room> AddAsync(Room value)
        {
            return await _roomRepository.AddRoomAsync(value);
        }

        public async Task DeleteAsync(int id)
        {
         await   _roomRepository.DeleteRoomAsync(id);
        }

        public async Task<IEnumerable<Room>> GetRoomsAsync()
        {
            return await _roomRepository.GetAllRoomsAsyncs();
        }
        public async Task<Room> UpdateAsync(int id, Room value)
        {
            return await _roomRepository.UpdateRoomAsync(id, value);
        }
        public async Task<Room> GetByIdAsync(int id)
        {
            return await _roomRepository.GetByIdAsync(id);
        }

    }
}