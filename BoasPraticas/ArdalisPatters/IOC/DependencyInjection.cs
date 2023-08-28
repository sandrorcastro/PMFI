using Application.Interfaces;
using Application.Services;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Services.Base;
using Domain.Specification;
using Infra.Context;
using Infra.Repositories;
using Infra.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IOC
{
    public static class DependencyInjection
    {
        //private static string connectString;
        
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<AppDbContext>(options => {
                //services.AddDbContext<ApplicationDbContext>(options => {
                 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                 //options.UseSqlServer(,
                 b => b.MigrationsAssembly(typeof(Infra.Context.ApplicationDbContext).Assembly.FullName));
            });

            /*services.AddDbContextFactory<ApplicationDbContext>(options => {
                //services.AddDbContext<ApplicationDbContext>(options => {
                 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                 //options.UseSqlServer(,
                 b => b.MigrationsAssembly(typeof(Infra.Context.ApplicationDbContext).Assembly.FullName));
            });*/

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
            //services.AddScoped(typeof(IAppServiceBase<,>),typeof(AppServiceBase<,>));
            services.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            //  services.AddScoped<IUfAppService,UfAppService>();
            //  services.AddScoped<IPaisAppService, PaisAppService>();
            //  services.AddScoped<ICidadeAppService, CidadeAppService>();

            ////////////////////////////////////////////////////////////////////
            services.AddScoped(typeof(IServiceBase<>),typeof(ServiceBase<>));
           // services.AddScoped<IUfService, UfService>();

            //////////////////////////////////////////////////////////////////////
            //services.AddScoped(typeof(IRepositoryBase<>),typeof(RepositoryBase<>));
            //services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<ICidadeRepository,CidadeRepository>();
            //services.AddScoped(typeof(IUfRepository),UfRepository);

            //////////////////////////////////////////////////////////////////////
            return services;
        }
    }
}
