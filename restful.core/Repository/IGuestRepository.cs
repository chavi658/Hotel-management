
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Repository
{
    public interface IGuestRepository
    {
        Task<IEnumerable<Guest>> GetAllGuestsAsync();
         Task<Guest> AddGuestAsync(Guest guest);
        Task<Guest> UpdateGuestAsync(int id, Guest guest);
        Task<Guest> GetByIdAsync(int id);
        Task DeleteGuestAync(int id);


    }
}
