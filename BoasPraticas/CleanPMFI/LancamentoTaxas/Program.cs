

using Domain.Entities.DBProsiga;
//using Infrastructure.Context.DBProsiga;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace LancamentoDecenio
{
    class Program
    {
        //        public string strIDsConstituicao; //  = Trim(sisP.getValorParametro("Tribuno", "IdTipoConstituicaoLancaTaxas"))
        //      public string intIDSituacaoAtiva; // As Integer = Trim(sisP.getValorParametro("fiss", "fissSituacaoEmpresaAtiva"))
        //    public string strTributos; 
        //public DBProsigaContext DBProsiga { get; set; }
        public static async Task Main(string[] args)
        {
            var host = await MontaConexao(args);
            //var intIDSituacaoAtiva = await BuscaParametros(host, "fiss", "fissSituacaoEmpresaAtiva");
            //var strIDsConstituicao = await BuscaParametros(host,"Tribuno", "IdTipoConstituicaoLancaTaxas");
            List<TribEmpresa> Empresas = await BuscaEmpresas(host); 
            foreach(var empresa in Empresas)
            {
                TribDividasEmpresa novadiv = new TribDividasEmpresa();
                var novoid = await BuscaAtualizaIDAutoNumEntidades(host, "TribDividasEmpresas");
                

                
                if(novoid != null)
                {
                    novadiv.DivEmpId = novoid.AutNumId;
                    novadiv.EmprCmc = 
                    novadiv.EmprDivAno = DateTime.Now.Date.Year;
                    novadiv.EmprDivMes = DateTime.Now.Date.Month;
                   // novadiv.

                   // Console.WriteLine(novoid.AutNumId.ToString() +" -- " + empresa.EmprCmc.ToString());
                }
                else
                {
                    Console.WriteLine("ID Nullo!");
                }
            }
          //  Console.WriteLine(strIDsConstituicao.Result.SiPaValorParametro.ToString());
        }
       /* static async Task<int> GetTipoTributo(int tributoselecionado)
        {
            if (tributoselecionado==)
            {

            }
        }*/
        static async Task<IHost> MontaConexao(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
           .ConfigureAppConfiguration((context, config) =>
           {
               // Configura o carregamento do appsettings.json
               config.SetBasePath(Directory.GetCurrentDirectory());
               config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
           })
           .ConfigureServices((context, services) =>
           {
               // Carregar a connection string do appsettings.json
               var connectionString = context.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

               // Configurar o DbContext com SQL Server
               services.AddDbContext<DBProsigaContext>(options => options.UseSqlServer(connectionString));

               // Registrar serviços adicionais se necessário
               //services.AddTransient<SomeService>(); // Exemplo de um serviço adicional
           })
           .Build();
            return host;
        }
        static async Task<SisParametro> BuscaParametros(IHost host, string? sipaidsistema,string? sipaidparametro)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // Pegar uma instância do DbContext
                    var dbContext = services.GetRequiredService<DBProsigaContext>();
                    // Exemplo de operação com o DbContext
                    return  await dbContext.SisParametros.AsNoTracking().FirstOrDefaultAsync(p => p.SiPaIdSistema == sipaidsistema && p.SiPaIdParametro == sipaidparametro);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return null;
                }
            }
        }
        static async Task<AutoNumEntidade> BuscaAtualizaIDAutoNumEntidades(IHost host, string? autnumentidade)
        {
            //TribDividasImo retorna AutNumId
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    // Pegar uma instância do DbContext
                    var dbContext = services.GetRequiredService<DBProsigaContext>();

                    // Exemplo de operação com o DbContext
                    var result = await dbContext.AutoNumEntidades.FirstOrDefaultAsync(id => id.AutNumEntidade==autnumentidade.Trim());
                    result.AutNumId += 1;
                    var  atualizado = Task.FromResult( dbContext.AutoNumEntidades.Update(result)) ?? null;
                    dbContext.SaveChanges();
                    if(atualizado != null)
                    {
                        return result;
                    }
                    else
                    {

                        return null ;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return null;
                }
            }
        }
        static async Task<List<TribEmpresa>> BuscaEmpresas(IHost host)
        {
            List<int> strIDsConstituicao = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 17, 19, 22, 32, 33, 34, 35, 36, 38, 203, 204, 205, 206, 207, 208, 209, 212, 213, 214, 215, 216, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 311, 313, 324, 401, 408, 501 };
            List<int> intIDSituacaoAtiva = new List<int>() { 6, 7, 8, 14, 17, 18, 20 };
            List<int> strTributos = new List<int>() { 316, 70, 6, 64, 16,  218};

            using (var scope = host.Services.CreateScope())
            {
                
                var services = scope.ServiceProvider;

                try
                {
                    // Pegar uma instância do DbContext
                    var dbContext = services.GetRequiredService<DBProsigaContext>();
                    // Exemplo de operação com o DbContext
                    //return await dbContext.TribEmpresas.AsNoTracking().Where();
                    var result = await dbContext.TribEmpresas
                                       //.Where(e => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 17, 19, 22, 32, 33, 34, 35, 36, 38, 203, 204, 205, 206, 207, 208, 209, 212, 213, 214, 215, 216, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 311, 313, 324, 401, 408, 501 }.Contains(e.EmprConstitId))
                                       //.Where(e => new List<int> { 6, 7, 8, 14, 17, 18, 20 }.Contains(e.EmprSituacaoId))
                                       .Where(e => e.EmprConstitId.HasValue && strIDsConstituicao.Contains(e.EmprConstitId.Value))               
                                       //.Where(e => e.EmprSituacaoId.HasValue && new List<int> { 6, 7, 8, 14, 17, 18, 20 }.Contains(e.EmprSituacaoId.Value))
                                       .Where(e => e.EmprSituacaoId.HasValue && intIDSituacaoAtiva.Contains(e.EmprSituacaoId.Value))
                                       .Where(e => e.EmprAreaAberta > 0 || e.AnteriorAreaConstr > 0)
                                       .Where(e => e.EmprCmc > 0 || e.EmprCmc < 2000)
                                       .Where(e => e.EmprDomicilioTributario == "Não")
                                       .Where(e => !dbContext.TribDividasEmpresas
                                           .Any(d => d.EmprCmc == e.EmprCmc
                                                     && d.EmprDivAno == 2024
                                                     && d.TipoTribId.HasValue && strTributos.Contains(d.TipoTribId.Value)
                                                     && d.EmprDivExcluido == null))
                                       .OrderBy(e => e.EmprCmc)
                                       .ToListAsync();
                    return result;


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return null;
                }
            }
        }



        static async Task  InsereDividas(IHost host, TribDividasEmpresa divida)
        //static async Task<TribDividasEmpresa> InsereDividas(IHost host, TribDividasEmpresa divida)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // Pegar uma instância do DbContext
                    var dbContext = services.GetRequiredService<DBProsigaContext>();
                    // Exemplo de operação com o DbContext
                    //var dividainserida = Task.FromResult(dbContext.TribDividasEmpresas.AddAsync(divida));
                    var dividainserida = await dbContext.TribDividasEmpresas.AddAsync(divida);
                    dbContext.SaveChanges();
                    //return dividainserida;// ?? null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                //    return null;
                }
            }
        }
        static async Task InsereComposicaoDividas(IHost host, TribComposicaoDivEmpresa composicaodivida)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // Pegar uma instância do DbContext
                    var dbContext = services.GetRequiredService<DBProsigaContext>();
                    // Exemplo de operação com o DbContext
                    //var dividainserida = Task.FromResult(dbContext.TribDividasEmpresas.AddAsync(divida));
                    var dividainserida = await dbContext.TribComposicaoDivEmpresas.AddAsync(composicaodivida);
                    dbContext.SaveChanges();
                    //return dividainserida;// ?? null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    //    return null;
                }
            }
        }
    }
}

