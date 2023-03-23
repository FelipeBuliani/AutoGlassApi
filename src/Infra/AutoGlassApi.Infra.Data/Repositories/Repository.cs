using AutoGlassApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlassApi.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AutoGlassApiDbContext context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(AutoGlassApiDbContext context)
        {
            this.context = context;
            DbSet = context.Set<TEntity>();
        }

        public virtual async Task AddAsync(TEntity obj)
        {
            await DbSet.AddAsync(obj);
            await SaveChangesAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<IQueryable<TEntity>> GetAllAsync()
        {
            return DbSet.AsNoTracking();
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            DbSet.Update(obj);
            await SaveChangesAsync();
        }

        public virtual async Task RemoveAsync(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
