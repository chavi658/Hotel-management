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
    public class GuestRepository : IGuestRepository
    {
        private readonly DataContext _dataContext;
        public GuestRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
       
        public async Task<IEnumerable<Guest>> GetAllGuestsAsync()
        {
            return  await _dataContext.guests.ToListAsync();
            //return await _dataContext.guests.Include(u => u.Package).ToListAsync();

        }
        public async Task<Guest> AddGuestAsync(Guest guest)
        {
            _dataContext.guests.Add(guest);
         await   _dataContext.SaveChangesAsync();
            return guest;
        }
        public async Task<Guest> GetByIdAsync(int id)
        {
            return  await _dataContext.guests.FindAsync(id);
        }
        public async Task DeleteGuestAync(int id)
        {
            var Guest = await GetByIdAsync(id);
            _dataContext.guests.Remove(Guest);
          await  _dataContext.SaveChangesAsync();
        }
        public async Task<Guest> UpdateGuestAsync(int id,Guest guest)
        {
            var updateGuest = await GetByIdAsync(id);
            if (updateGuest != null)
            {
                updateGuest.Status = guest.Status;
                updateGuest.Phone = guest.Phone;

                _dataContext.SaveChangesAsync();
            }
            return  updateGuest;
            
        }
        

    }
}
