using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Services
{
    public interface IPackageService
    {
        Task<IEnumerable<Package>> GetPackagesAsync();
        Task<Package> UpdateAsync(int id, Package value);
        Task DeleteAsync(int id);
        Task<Package> GetByIdAsync(int id);
        Task<Package> AddAsync(Package value);
    }
}
