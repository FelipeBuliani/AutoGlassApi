using AutoGlassApi.Domain.Interfaces;
using AutoGlassApi.Domain.Interfaces.Services;
using AutoGlassApi.Infra.Data;
using AutoGlassApi.Infra.Data.Repositories;
using AutoGlassApi.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutoGlassApi.Infra.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration) 
        {
            // Services
            services.AddTransient<IProdutoService, ProdutoService>();

            // Repositories
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            services.AddDbContext<AutoGlassApiDbContext>(
                options => options.UseSqlite(configuration.GetConnectionString("SqliteConnectionString"))
            );
        }
    }
}
