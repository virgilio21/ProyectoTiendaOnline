using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class OnlineStoreContext:DbContext
    {

        public OnlineStoreContext()
        {
            Database.SetInitializer<OnlineStoreContext>(new DropCreateDatabaseIfModelChanges<OnlineStoreContext>());
        }

        public DbSet<Input> Inputs { get; set; }
        public DbSet<Output> Outputs { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductHasSale> ProductHasSales { get; set; }
        public DbSet<ProductHasStore> ProductHasStores { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public DbSet<Role> Roles{ get; set; }
        public DbSet<Sale> Sales { get; set; }

        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }

    }
}