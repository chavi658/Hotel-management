using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Services
{
    public interface IGuestService
    {
        Task<IEnumerable<Guest>> GetGuestsAsync();
        Task<Guest> AddAsync(Guest guest);
        Task<Guest> UpdateAsync(int id, Guest value);
        Task DeleteAsync(int id);
        Task<Guest> GetByIdAsync(int id);
    }
}
