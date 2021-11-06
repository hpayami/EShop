using EShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DataLayer.Context
{
    public class EShopDbContext : DbContext , IUnitOfWork
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }

        public Task<int> SaveChangesAsync()
            => base.SaveChangesAsync();
    }
}
