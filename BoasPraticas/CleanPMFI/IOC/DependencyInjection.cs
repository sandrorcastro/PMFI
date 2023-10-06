using Application.Interfaces;
using Application.Interfaces.Base;
using Application.Services;
using Application.Services.Base;
using Domain.Entities;
using Domain.Entities.NFSEDB;
using Domain.Interfaces.Base;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Domain.Services.Base;
using Infrastructure.Context;
using Infrastructure.Evaluators;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Data.Common;

namespace IOC
{
    public static class DependencyInjection
    {
        //private static string connectString;
        
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextFactory<ApplicationDbContext>(options => {
            //services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection-SRC-PMFI"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });


            services.AddDbContextFactory<NFSEDBContext>(options => {
            //    services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection-NFSEDB"),
                b => b.MigrationsAssembly(typeof(NFSEDBContext).Assembly.FullName));
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
            services.AddScoped(typeof(IAppServiceBase<>),typeof(AppServiceBase<>));
            //         services.AddScoped<IUfAppService,UfAppService>();
            //    services.AddScoped<IPaisAppService, PaisAppService>();
            services.AddScoped<ICidadeAppService, CidadeAppService>();
            services.AddScoped<IPaisAppService, PaisAppService>();
            services.AddScoped<IUfAppService, UfAppService>();
            services.AddScoped<ILogradouroAppService, LogradouroAppService>();
            services.AddScoped<ITipoLogradouroAppService, TipoLogradouroAppService>();
            services.AddScoped<ITribAlvDocumentoAppService, TribAlvDocumentoAppService>();
            services.AddScoped<INFSE_To_MegaData_AppService, NFSE_To_MegaData_AppService>();



            ////////////////////////////////////////////////////////////////////
            services.AddScoped(typeof(IServiceBase<>),typeof(ServiceBase<>));
            //       services.AddScoped<IUfService, UfService>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IPaisService, PaisService>();
            services.AddScoped<IUfService, UfService>();
            services.AddScoped<ILogradouroService, LogradouroService>();
            services.AddScoped<ITipoLogradouroService, TipoLogradouroService>();
            services.AddScoped<ITribAlvDocumentoService, TribAlvDocumentoService>();
            services.AddScoped<INfseTblNfse_Service, NfseTblNfse_Service>();

            //////////////////////////////////////////////////////////////////////
            services.AddScoped(typeof(IRepositoryBase<>),typeof(RepositoryBase<>));
            services.AddScoped(typeof(IReadRepositoryBase<>), typeof(RepositoryBase<>));
            //services.AddScoped(typeof(IRepositoryBase<Cidade>), typeof(RepositoryBase<Cidade>));
            //services.AddScoped(typeof(IRepositoryBase<Uf>), typeof(RepositoryBase<Uf>));
            services.AddScoped<IUfRepository, UfRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IPaisRepository, PaisRepository>();
            services.AddScoped<ILogradouroRepository, LogradouroRepository>();
            services.AddScoped<ITipoLogradouroRepository, TipoLogradouroRepository>();
            services.AddScoped<ITribAlvDocumentoRepository, TribAlvDocumentoRepository>();
            services.AddScoped<INfseTblNfse_Repository, NfseTblNfse_Repository>();


            //////////////////////////////////////////////////////////////////////
            //services.AddScoped<ISpecificationEvaluator, SpecificationEvaluator>();
            return services;
        }
    }
}
