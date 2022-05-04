using StoreLoc.APIData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.Repositories.IRepo
{
    public interface IGenericRepoRegister : IDisposable
    {
        IGenericRepository<Province> Provinces { get; }
        IGenericRepository<ShoppingCenter> ShoppingCenters { get; }
        IGenericRepository<Store> Stores { get; }
        Task Save();
    }
}
