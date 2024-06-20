using restful.core.Repository;
using restful.core.Services;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.service
{
    public class GuestService:IGuestService
    {

        private readonly IGuestRepository _guestRepository;
        public GuestService(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }


        public async Task<IEnumerable<Guest>> GetGuestsAsync()
        {
            return await  _guestRepository.GetAllGuestsAsync();
        }
        public async Task<Guest> AddAsync(Guest guest)
        {
          return await _guestRepository.AddGuestAsync(guest);
        }
        public async Task<Guest> UpdateAsync(int id, Guest value){
            return await  _guestRepository.UpdateGuestAsync(id, value);
        }

        public async Task DeleteAsync(int id)
        {
             
           await _guestRepository.DeleteGuestAync(id);
        }

        public async Task<Guest> GetByIdAsync(int id)
        {
          return  await  _guestRepository.GetByIdAsync(id);
        }
    }
}
