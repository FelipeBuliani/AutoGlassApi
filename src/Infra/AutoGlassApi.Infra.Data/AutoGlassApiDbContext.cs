using AutoGlassApi.Domain.Entities;
using AutoGlassApi.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AutoGlassApi.Infra.Data
{
    public class AutoGlassApiDbContext : DbContext
    {

        public DbSet<Produto> Produto { get; set; }

        public AutoGlassApiDbContext(DbContextOptions<AutoGlassApiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
