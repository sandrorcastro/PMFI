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
using Infrastructure.Context.DBProsiga;
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

            services.AddDbContextFactory<DBProsigaContext>(options => {

                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection-DBProsiga"),
                b => b.MigrationsAssembly(typeof(DBProsigaContext).Assembly.FullName));
            }); //, ServiceLifetime.Transient);
                // services.AddScoped<IServiceScopeFactory,ServiceScopeFactory>();
               //  services.AddScoped<IServiceScopeFactory, AutoNumAnoNumeroServiceScopeFactoryImp>();
            /*  services.AddDbContextFactory<DBProsigaContext>(options => {
                  //services.AddDbContext<DBProsigaContext>(options => {
                  options.UseSqlServer(configuration.GetConnectionString("DefaultConnection-DBProsigaDev"),
                  b => b.MigrationsAssembly(typeof(DBProsigaContext).Assembly.FullName));
              });*/

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



            services.AddDbContextFactory<MegaDataDBContext>(options => {
                //    services.AddDbContext<MegaDataDBContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection-MegaData"),
                b => b.MigrationsAssembly(typeof(MegaDataDBContext).Assembly.FullName));
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
            services.AddScoped<IMegaData_NFSE_AppService, MegaData_NFSE_AppService>();
            services.AddScoped<IMegaData_Export_AppService, MegaData_Export_AppService>();
            services.AddScoped<IMegaDataAppService, MegaDataAppService>();
            //DBProsiga
            //services.AddScoped<Application.Interfaces.DBProsiga.ILogradouroAppService, Application.Services.DBProsiga.LogradouroAppService>();
            //services.AddScoped<Application.Interfaces.DBProsiga.ILogradouroTipoAppService, Application.Services.DBProsiga.LogradouroTipoAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribEdificacoesAppService, Application.Services.DBProsiga.TribEdificacoesAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.IContribuinteAppService, Application.Services.DBProsiga.ContribuinteAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.IAutoNumAnoNumeroAppService, Application.Services.DBProsiga.AutoNumAnoNumeroAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.IAutoNumEntidadesAppService, Application.Services.DBProsiga.AutoNumEntidadesAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribITBIAppService, Application.Services.DBProsiga.TribITBIAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribITBIEdifAppService, Application.Services.DBProsiga.TribITBIEdifAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribITBICompradoresAppService, Application.Services.DBProsiga.TribITBICompradoresAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribITBIVendedoresAppService, Application.Services.DBProsiga.TribITBIVendedoresAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribDividasImoAppService, Application.Services.DBProsiga.TribDividasImoAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribComposicaoDivImoAppService, Application.Services.DBProsiga.TribComposicaoDivImoAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.IConvenioBancoAppService, Application.Services.DBProsiga.ConvenioBancoAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribBoletoAppService, Application.Services.DBProsiga.TribBoletoAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribBoletosDividasAppService, Application.Services.DBProsiga.TribBoletosDividasAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribBoletosBarraAppService, Application.Services.DBProsiga.TribBoletosBarraAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribObjetoAppService, Application.Services.DBProsiga.TribObjetoAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribItbiexAnexoAppService, Application.Services.DBProsiga.TribItbiexAnexoAppService>();
            services.AddScoped<Application.Interfaces.DBProsiga.ITribItbidocumentoTipoAppService, Application.Services.DBProsiga.TribItbidocumentoTipoAppService>();


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
            services.AddScoped<IMegaData_NFSE_Service, MegaData_NFSE_Service>();
            services.AddScoped<IMegaDataService, MegaDataService>();
            //DBProsiga
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribEdificacoesService, Domain.Services.DBProsiga.TribEdificacoesService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.IContribuinteService, Domain.Services.DBProsiga.ContribuinteService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.IAutoNumAnoNumeroService, Domain.Services.DBProsiga.AutoNumAnoNumeroService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.IAutoNumEntidadesService, Domain.Services.DBProsiga.AutoNumEntidadesService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribITBIService, Domain.Services.DBProsiga.TribITBIService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribITBIEdifService, Domain.Services.DBProsiga.TribITBIEdifService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribITBICompradoresService, Domain.Services.DBProsiga.TribITBICompradoresService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribITBIVendedoresService, Domain.Services.DBProsiga.TribITBIVendedoresService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribDividasImoService, Domain.Services.DBProsiga.TribDividasImoService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribComposicaoDivImoService, Domain.Services.DBProsiga.TribComposicaoDivImoService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.IConvenioBancoService, Domain.Services.DBProsiga.ConvenioBancoService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribBoletoService, Domain.Services.DBProsiga.TribBoletoService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribBoletosDividasService, Domain.Services.DBProsiga.TribBoletosDividasService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribBoletosBarraService, Domain.Services.DBProsiga.TribBoletosBarraService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribObjetoService, Domain.Services.DBProsiga.TribObjetoService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribItbiexAnexoService, Domain.Services.DBProsiga.TribItbiexAnexoService>();
            services.AddScoped<Domain.Interfaces.Services.DBProsiga.ITribItbidocumentoTipoService, Domain.Services.DBProsiga.TribItbidocumentoTipoService>();

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
            services.AddScoped<IMegaData_NFSE_Repository, MegaData_NFSE_Repository>();
            services.AddScoped<IMegaDataRepository, MegaDataRepository>();
            //DBProsiga
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribEdificacoesRepository, Infrastructure.Repositories.DBProsiga.TribEdificacoesRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.IContribuinteRepository, Infrastructure.Repositories.DBProsiga.ContribuinteRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.IAutoNumAnoNumeroRepository, Infrastructure.Repositories.DBProsiga.AutoNumAnoNumeroRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.IAutoNumEntidadesRepository, Infrastructure.Repositories.DBProsiga.AutoNumEntidadesRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribITBIRepository, Infrastructure.Repositories.DBProsiga.TribITBIRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribITBIEdifRepository, Infrastructure.Repositories.DBProsiga.TribITBIEdifRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribITBICompradoresRepository, Infrastructure.Repositories.DBProsiga.TribITBICompradoresRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribITBIVendedoresRepository, Infrastructure.Repositories.DBProsiga.TribITBIVendedoresRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribDividasImoRepository, Infrastructure.Repositories.DBProsiga.TribDividasImoRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribComposicaoDivImoRepository, Infrastructure.Repositories.DBProsiga.TribComposicaoDivImoRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.IConvenioBancoRepository, Infrastructure.Repositories.DBProsiga.ConvenioBancoRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribBoletoRepository, Infrastructure.Repositories.DBProsiga.TribBoletoRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribBoletosDividasRepository, Infrastructure.Repositories.DBProsiga.TribBoletosDividasRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribBoletosBarraRepository, Infrastructure.Repositories.DBProsiga.TribBoletosBarraRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribObjetoRepository, Infrastructure.Repositories.DBProsiga.TribObjetoRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribItbiexAnexoRepository, Infrastructure.Repositories.DBProsiga.TribItbiexAnexoRepository>();
            services.AddScoped<Domain.Interfaces.Repositories.DBProsiga.ITribItbidocumentoTipoRepository, Infrastructure.Repositories.DBProsiga.TribItbidocumentoTipoRepository>();
            //////////////////////////////////////////////////////////////////////
            //services.AddScoped<ISpecificationEvaluator, SpecificationEvaluator>();
            return services;
        }
    }
}
