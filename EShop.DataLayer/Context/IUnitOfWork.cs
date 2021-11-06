using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EShop.DataLayer.Context
{
    public interface IUnitOfWork : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
