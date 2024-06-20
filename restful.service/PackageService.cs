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
    public class PackageService : IPackageService
    {

        private readonly IPackageRepository _packageRepository;
        public PackageService(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }
        public async Task<IEnumerable<Package>> GetPackagesAsync()
        {
            return  await _packageRepository.GetAllPackagesAync();
        }
        public async Task<Package> AddAsync(Package package)
        {
            return  await _packageRepository.AddPackageAsync(package);
        }
        public async Task<Package> UpdateAsync(int id, Package value)
        {
            return await _packageRepository.UpdatePackage(id,value);
        }
        public async Task<Package> GetByIdAsync(int id)
        {
            return  await _packageRepository.GetByIdAsync(id);
        }
        public async Task DeleteAsync(int id)
        {
          await _packageRepository.DeletePackageAsync( id);
        }

       
    }
}
