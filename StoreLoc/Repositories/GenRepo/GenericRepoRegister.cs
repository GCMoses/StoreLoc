using StoreLoc.APIData;
using StoreLoc.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.Repositories.GenRepo
{
    public class GenericRepoRegister : IGenericRepoRegister
    {
        private readonly DatabaseContext _dbContext;
        private IGenericRepository<Province> _provinces;
        private IGenericRepository<ShoppingCenter> _shoppingCenters;
        private IGenericRepository<Store> _stores;

        public GenericRepoRegister(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IGenericRepository<Province> Provinces => _provinces ??= new GenericRepository<Province>(_dbContext);

        public IGenericRepository<ShoppingCenter> ShoppingCenters => _shoppingCenters ??= new GenericRepository<ShoppingCenter>(_dbContext);

        public IGenericRepository<Store> Stores => _stores ??= new GenericRepository<Store>(_dbContext);

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this); //GC short for garbage collector
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
