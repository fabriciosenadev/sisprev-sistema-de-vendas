using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaCompra.Domain.ProdutoAggregate;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using SistemaCompra.Infra.Data.Produto;
using SistemaCompra.Infra.Data.SolicitacaoCompra;
using SistemaCompra.Infra.Data.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Infra.Data
{
    public static class DependecyInjectionConfiguration
    {
        
        public static void UseDependecyInjectionConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ISolicitacaoCompraRepository, SolicitacaoCompraRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<SistemaCompraContext>(options =>
                options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
        o => o.MigrationsAssembly("SistemaCompra.API"))
);
        }
    }
}
