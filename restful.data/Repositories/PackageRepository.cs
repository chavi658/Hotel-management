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
    public class PackageRepository: IPackageRepository
    {

        private readonly DataContext _dataContext;

        public PackageRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Package>> GetAllPackagesAync()
        {
            return await _dataContext.Packages.ToListAsync();
        }
        
        public async Task<Package> AddPackageAsync(Package package)
        {
            
            _dataContext.Packages.Add(package);
          await   _dataContext.SaveChangesAsync();
            return  package;
        }
        public async Task<Package> GetByIdAsync(int id)
        {
            return await  _dataContext.Packages.FindAsync(id);
        }
        
        public async Task DeletePackageAsync(int id)
        {
            var Package = await GetByIdAsync(id);
            _dataContext.Packages.Remove(Package);
           await _dataContext.SaveChangesAsync();
        }
        public async Task<Package> UpdatePackage(int id, Package package)
        {
            var updatePackage = await GetByIdAsync(id);
            if (updatePackage != null)
            {
                updatePackage.Price = package.Price;
                updatePackage.PackgeName = package.PackgeName;

             await   _dataContext.SaveChangesAsync();
            }
            return updatePackage;

        }
        

    }
}
