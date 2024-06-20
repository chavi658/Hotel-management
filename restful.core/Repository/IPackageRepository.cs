using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Repository
{
    public interface IPackageRepository
    {
        Task<IEnumerable<Package>> GetAllPackagesAync();
        Task<Package> AddPackageAsync(Package package);
        Task<Package> UpdatePackage(int id, Package value);
        Task<Package> GetByIdAsync(int id);

        Task DeletePackageAsync(int id);
    }
}

