//using MailKit;

using Application.Interfaces;
using Application.Interfaces.Base;
using Application.Services;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Infra.Context;
using Infra.EntityConfig;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Org.BouncyCastle.Tls;
using System.Data.Common;

namespace IOC
{
    public static class DependencyInjection
    {
        //private static string connectString;
        
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContextFactory<ContextoAplicacao>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            //                                              b=> b.MigrationsAssembly(typeof(ContextoAplicacao).Assembly.FullName)));

            ////////////services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            ///////////                                  b => b.MigrationsAssembly(typeof(ContextoAplicacao).Assembly.FullName)));




            /////testes
            /////////////////services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionHSS"),b => b.MigrationsAssembly(typeof(ContextoAplicacao).Assembly.FullName)));
            services.AddDbContextFactory<ContextoAplicacao>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionHSS"),b => b.MigrationsAssembly(typeof(ContextoAplicacao).Assembly.FullName)));

           // services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionHSS"))
                                                                                    //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                                                                                  //  );


            //services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(configuration.GetConnectionString(connectString), b => b.MigrationsAssembly(typeof(ContextoAplicacao).Assembly.FullName)));
            //services.AddDbContextFactory<ContextoAplicacaoFactory>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ContextoAplicacao).Assembly.FullName)));
            ///





            //services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(connectionString));

            // var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            //configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            //services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(connectionString));
            ////////////////////////////////////////////////////////////////////
            /* services.AddDbContext<ContextoAplicacao>(options =>*/
            ///////////////////////////////////////////////////////////////////////
            //services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ContextoAplicacao>();
            //services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ContextoAplicacao>();
            //services.Add .AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ContextoAplicacao>();


            ///////////////////////////////////////////////////////////////////////
            // services.Configure<SendinBlueSettings>(options => configuration.GetSection("SendinBlueSettings"));//    .GetSection("SendinBlueSettings"));
            // services.AddSingleton<IEmailService, SendinBlueService>();
            // services.AddSingleton<IWhatsappService, TwilioWhatsappService>();


            /////////////////////////////////////////////////////////////////////
            services.AddScoped(typeof(IAppServiceBase<>),typeof(AppServiceBase<>));
                       services.AddScoped<ITipoLogradouroAppService,TipoLogradouroAppService>();
                       services.AddScoped<IIncrementoTabelasAppService, IncrementoTabelasAppService>();
                       services.AddScoped<IEstadoAppService, EstadoAppService>();
                       services.AddScoped<IPaisAppService, PaisAppService>();
                       services.AddScoped<IDDDAppService, DDDAppService>();
                       services.AddScoped<ICidadeAppService, CidadeAppService>();
                       services.AddScoped<IRegiaoAppService, RegiaoAppService>();
                       services.AddScoped<IBairroAppService, BairroAppService>();
                       services.AddScoped<ILogradouroAppService, LogradouroAppService>();
                       services.AddScoped<IEnderecoAppService, EnderecoAppService>();
                       services.AddScoped<IEndereco_EntidadeAppService, Endereco_EntidadeAppService>();
                       services.AddScoped<ITipoPessoaAppService, TipoPessoaAppService>();
                       services.AddScoped<IPessoaAppService, PessoaAppService>();
                       services.AddScoped<IPessoaFisicaAppService, PessoaFisicaAppService>();
                       services.AddScoped<IPessoaJuridicaAppService, PessoaJuridicaAppService>();
                       services.AddScoped<ITipoResponsabilidadeAppService, TipoResponsabilidadeAppService>();
                       services.AddScoped<IEconomiaAppService, EconomiaAppService>();
                       services.AddScoped<IEconomia_EntidadeAppService, Economia_EntidadeAppService>();
                       services.AddScoped<IImovelAppService, ImovelAppService>();
                       services.AddScoped<IServidorAppService, ServidorAppService>();
                       services.AddScoped<IEtapaAppService, EtapaAppService>();
                       services.AddScoped<ITipoEtapaAppService, TipoEtapaAppService>();
                       services.AddScoped<ISituacaoEtapaAppService, SituacaoEtapaAppService>();
                       services.AddScoped<IProcessoAppService, ProcessoAppService>();    
                       services.AddScoped<IFluxoProcessoAppService, FluxoProcessoAppService>();
                       services.AddScoped<ITipoProcessoAppService, TipoProcessoAppService>();
                       services.AddScoped<ISituacaoProcessoAppService, SituacaoProcessoAppService>();
                       services.AddScoped<IImageAppService, ImageAppService>();
                       services.AddScoped<IPerspectivaAppService, PerspectivaAppService>();
                       services.AddScoped<ITextoAutuacaoAppService, TextoAutuacaoAppService>();
                        ////////////////////////////////////////////////////////////////////
                       services.AddScoped(typeof(IServiceBase<>),typeof(ServiceBase<>));
                       services.AddScoped<ITipoLogradouroService,TipoLogradouroService>();
                       services.AddScoped<IIncrementoTabelasService, IncrementoTabelasService>();
                       services.AddScoped<IEstadoService, EstadoService>();
                       services.AddScoped<IPaisService, PaisService>();
                       services.AddScoped<IDDDService, DDDService>();
                       services.AddScoped<ICidadeService, CidadeService>();
                       services.AddScoped<IRegiaoService, RegiaoService>();
                       services.AddScoped<IBairroService, BairroService>();
                       services.AddScoped<ILogradouroService, LogradouroService>();
                       services.AddScoped<IEnderecoService, EnderecoService>();
                       services.AddScoped<IEndereco_EntidadeService, Endereco_EntidadeService>();
                       services.AddScoped<ITipoPessoaService, TipoPessoaService>();
                       services.AddScoped<IPessoaService, PessoaService>();
                       services.AddScoped<IPessoaFisicaService, PessoaFisicaService>();
                       services.AddScoped<IPessoaJuridicaService, PessoaJuridicaService>();
                       services.AddScoped<ITipoResponsabilidadeService, TipoResponsabilidadeService>();
                       services.AddScoped<IEconomiaService, EconomiaService>();
                       services.AddScoped<IEconomia_EntidadeService, Economia_EntidadeService>();
                       services.AddScoped<IImovelService, ImovelService>();
                       services.AddScoped<IServidorService, ServidorService>();
                       services.AddScoped<IEtapaService, EtapaService>();
                       services.AddScoped<ITipoEtapaService, TipoEtapaService>();
                       services.AddScoped<ISituacaoEtapaService, SituacaoEtapaService>();
                       services.AddScoped<IFluxoProcessoService, FluxoProcessoService>();
                       services.AddScoped<IProcessoService, ProcessoService>();
                       services.AddScoped<ITipoProcessoService, TipoProcessoService>();
                       services.AddScoped<ISituacaoProcessoService, SituacaoProcessoService>();
                       services.AddScoped<IImageService, ImageService>();
                       services.AddScoped<IPerspectivaService, PerspectivaService>();
                       services.AddScoped<ITextoAutuacaoService, TextoAutuacaoService>();
                        //////////////////////////////////////////////////////////////////////
                       services.AddScoped(typeof(IRepositoryBase<>),typeof(RepositoryBase<>));
                       services.AddScoped<ITipoLogradouroRepository,TipoLogradouroRepository>();
                       services.AddScoped<IIncrementoTabelasRepository, IncrementoTabelasRepository>();
                       services.AddScoped<IEstadoRepository, EstadoRepository>();
                       services.AddScoped<IPaisRepository, PaisRepository>();
                       services.AddScoped<IDDDRepository, DDDRepository>();
                       services.AddScoped<ICidadeRepository, CidadeRepository>();
                       services.AddScoped<IRegiaoRepository, RegiaoRepository>();
                       services.AddScoped<IBairroRepository, BairroRepository>();
                       services.AddScoped<ILogradouroRepository, LogradouroRepository>();
                       services.AddScoped<IEnderecoRepository, EnderecoRepository>();
                       services.AddScoped<IEndereco_EntidadeRepository, Endereco_EntidadeRepository>();
                       services.AddScoped<ITipoPessoaRepository, TipoPessoaRepository>();
                       services.AddScoped<IPessoaRepository, PessoaRepository>();
                       services.AddScoped<IPessoaFisicaRepository, PessoaFisicaRepository>();
                       services.AddScoped<IPessoaJuridicaRepository, PessoaJuridicaRepository>();
                       services.AddScoped<ITipoResponsabilidadeRepository, TipoResponsabilidadeRepository>();
                       services.AddScoped<IEconomiaRepository, EconomiaRepository>();
                       services.AddScoped<IEconomia_EntidadeRepository, Economia_EntidadeRepository>();
                       services.AddScoped<IImovelRepository, ImovelRepository>();
                       services.AddScoped<IServidorRepository, ServidorRepository>();
                       services.AddScoped<IEtapaRepository, EtapaRepository>();
                       services.AddScoped<ITipoEtapaRepository, TipoEtapaRepository>();
                       services.AddScoped<ISituacaoEtapaRepository, SituacaoEtapaRepository>();
                       services.AddScoped<IProcessoRepository, ProcessoRepository>();
                       services.AddScoped<IFluxoProcessoRepository, FluxoProcessoRepository>();
                       services.AddScoped<ITipoProcessoRepository, TipoProcessoRepository>();
                       services.AddScoped<ISituacaoProcessoRepository, SituacaoProcessoRepository>();
                       services.AddScoped<IImageRepository, ImageRepository>();
                       services.AddScoped<IPerspectivaRepository, PerspectivaRepository>();
                       services.AddScoped<ITextoAutuacaoRepository, TextoAutuacaoRepository>();
            return services;
        }
    }
}
