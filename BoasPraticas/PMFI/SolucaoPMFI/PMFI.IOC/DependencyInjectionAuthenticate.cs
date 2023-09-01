

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PMFI.Application.Interfaces;
using PMFI.Application.Interfaces.Base;
using PMFI.Application.Services;
using PMFI.Application.Services.Base;
using PMFI.Domain.Interfaces.Base;
using PMFI.Domain.Interfaces.Repositories;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Services;
using PMFI.Domain.Services.Base;
using PMFI.Seguranca.Context;
using PMFI.Infra.Repositories;
using PMFI.Infra.Repositories.Base;

using PMIFI.Domain.Interfaces.Base;
using System.Data.Common;

namespace PMFI.IOC
{
    public static class DependencyInjectionAuthenticate
    {
        //private static string connectString;
        
        public static IServiceCollection AddInfrastructureAuthenticate(this IServiceCollection services, IConfiguration configuration)
        {/*
            services.AddDbContextFactory<SegurancaDbContext>(options => {
            //services.AddDbContext<SegurancaDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionSeguranca"),
                b => b.MigrationsAssembly(typeof(SegurancaDbContext).Assembly.FullName));
            });*/

            /*services.AddDbContextFactory<SegurancaDbContext>(options => {
                // options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionSeguranca"),
                options.UseSqlServer("Data Source=localhost;Initial Catalog=Seg;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme"),
                b => b.MigrationsAssembly(typeof(SegurancaDbContext).Assembly.FullName));
            });*/

            
            services.AddDbContextFactory<Seguranca.Context.SegurancaDbContext>(options => {
                options.UseSqlServer("Data Source=localhost;Initial Catalog=Seguranca;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme",
                b => b.MigrationsAssembly(typeof(Seguranca.Context.SegurancaDbContext).Assembly.FullName));
            });


            services.AddIdentity<ApplicationUser,ApplicationRole>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<SegurancaDbContext>().AddSignInManager<SignInManager<ApplicationUser>>().AddDefaultUI();
           // services.AddIdentityCore<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<Seguranca.Context.SegurancaDbContext>().AddSignInManager<SignInManager<IdentityUser>>().AddDefaultUI();
            
           
            //////////////////////////////////////////////////////////////////////
            return services;
        }
    }
}
