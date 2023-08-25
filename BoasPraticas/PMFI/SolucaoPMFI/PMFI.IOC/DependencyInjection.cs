

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PMFI.Application.Interfaces;
using PMFI.Application.Interfaces.Base;
using PMFI.Application.Services;
using PMFI.Application.Services.Base;
using PMFI.Domain.Interfaces.Repositories;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Services;
using PMFI.Infra.Context;
using PMFI.Infra.Repositories;
using PMFI.Infra.Repositories.Base;
using System.Data.Common;

namespace PMFI.IOC
{
    public static class DependencyInjection
    {
        //private static string connectString;
        
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextFactory<Infra.Context.ApplicationDbContext>(options => {
            //services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(Infra.Context.ApplicationDbContext).Assembly.FullName));
            });

            /*services.AddDbContextFactory<SegurancaDbContext>(options => {
                // options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionSeguranca"),
                options.UseSqlServer("Data Source=localhost;Initial Catalog=Seg;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme"),
                b => b.MigrationsAssembly(typeof(SegurancaDbContext).Assembly.FullName));
            });*/

            /*
            services.AddDbContextFactory<Seguranca.Context.SegurancaDbContext>(options => {
                options.UseSqlServer("Data Source=localhost;Initial Catalog=Seg;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme",
                b => b.MigrationsAssembly(typeof(Seguranca.Context.SegurancaDbContext).Assembly.FullName));
            });


            services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<SegurancaDbContext>().AddSignInManager<SignInManager<ApplicationUser>>().AddDefaultUI();
           // services.AddIdentityCore<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<Seguranca.Context.SegurancaDbContext>().AddSignInManager<SignInManager<IdentityUser>>().AddDefaultUI();
            */






            /////////////////////////////////////////////////////////////////////
            services.AddScoped(typeof(IAppServiceBase<,>),typeof(AppServiceBase<,>));
            services.AddScoped<IUfAppService,UfAppService>();
            services.AddScoped<IPaisAppService, PaisAppService>();
            services.AddScoped<ICidadeAppService, CidadeAppService>();

            ////////////////////////////////////////////////////////////////////
            services.AddScoped(typeof(IServiceBase<>),typeof(ServiceBase<>));
           // services.AddScoped<IUfService, UfService>();

            //////////////////////////////////////////////////////////////////////
            services.AddScoped(typeof(IRepositoryBase<>),typeof(RepositoryBase<>));
            //services.AddScoped<IUfRepository, UfRepository>();

            //////////////////////////////////////////////////////////////////////
            return services;
        }
    }
}
