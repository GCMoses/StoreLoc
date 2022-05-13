using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreLoc.LocatorDataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.APIData
{
    public class DatabaseContext : IdentityDbContext<APIUser> 
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Province> Provinces { get; set; }
        public DbSet<ShoppingCenter> ShoppingCenters { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProvinceConfig());
            builder.ApplyConfiguration(new ShoppingCenterConfig());
            builder.ApplyConfiguration(new StoreConfig());
            builder.ApplyConfiguration(new RoleConfig());
        }

    }
}
