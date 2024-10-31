

using Domain.Entities.DBProsiga;
using LancamentoDecenio;
using LancamentoDecenio.Models;

//using Infrastructure.Context.DBProsiga;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace LancamentoTaxas
{
    class Program
    {
        public static List<INPC> HISTORICOINPC;
        public static async Task Main(string[] args)
        {
            var host = await MontaConexao(args);
            List<DecenioServidores> Servidores = await BuscaDecenioServidores(host);
            var mapeamentoMeses = new Dictionary<string, string>
                {{ "jan", "jan" },{"fev","fev"},{"mar","mar"},{"abr","abr"},{"mai","mai"},{"jun","jun"},{"jul","jul"},{"ago","ago"},{ "sete", "sete" },{ "outu", "outu" },{"nov","nov"},{"dez","dez"},{"decimo3","decimo3"}};
            HISTORICOINPC = await CarregaHISTORICOINPC(host);
            var csvBuilder = new StringBuilder();
            // Adicionando cabeçalho ao CSV
            csvBuilder.AppendLine("CPF;Matricula;Nome;Ano;Mes;ValorBaseMes;AliquotaSMSS;SMSS;INPCAtual;INPCAnoBase;ValorCorrigido");
            foreach (var servidor in Servidores)
            {
                servidor.DecenioBase = await BuscaDecenioBaseServidor(host, servidor.CPF, servidor.Matricula);
                foreach (DecenioBase baseano in servidor.DecenioBase)
                {
                    var propriedades = baseano.GetType().GetProperties();
                    foreach (var prop in propriedades)
                    {
                        // Verifica se a propriedade está no mapeamento
                        //if (mapeamentoMeses.ContainsKey(prop.Name))
                        if (mapeamentoMeses.TryGetValue(prop.Name,out string col))
                        {
                            // Se estiver, imprime o nome da coluna mapeada
                            //Console.WriteLine(mapeamentoMeses[prop.Name] + "--" + col);
                            var property = baseano.GetType().GetProperty(col);

                            if (property != null)
                            {
                                
                                // Obtendo o valor da propriedade (que é o valor do mês)
                                var valorBaseMes = property.GetValue(baseano) as decimal?;
                                valorBaseMes = Math.Round((decimal) valorBaseMes, 2);

                                //pegar apenas dos ultimos 5 anos da tabela deceniobase
                                if (baseano.ano >= 2019)
                                {
                                    if(baseano.ano == 2019 && (col=="jan" || col == "fev" || col == "mar" || col == "abr" || col == "mai" || col == "jun" || col == "jul" || col == "ago" || col == "sete" ))
                                    {
                                        valorBaseMes = 0.00M;

                                    }
                                    

                                    if (valorBaseMes.HasValue && valorBaseMes.Value != 0.00M)
                                    {
                                        // Se o valor não for nulo e diferente de 0.00, faça o que precisar
                                        Console.WriteLine($" {servidor.CPF};{servidor.Matricula};{servidor.Nome};{baseano.ano};{mapeamentoMeses[prop.Name]};{valorBaseMes.Value};{GetAliquotaSMSS(baseano.ano, mapeamentoMeses[prop.Name].ToUpper())};{await GetSMSS(baseano.ano, mapeamentoMeses[prop.Name].ToUpper(), valorBaseMes.Value)};{await GetINPC(2024, mapeamentoMeses[prop.Name].ToUpper())};{await GetINPC(baseano.ano, mapeamentoMeses[prop.Name].ToUpper())};{await Corrigir(2024, baseano.ano, mapeamentoMeses[prop.Name].ToUpper(), mapeamentoMeses[prop.Name].ToUpper(), await GetSMSS(baseano.ano, mapeamentoMeses[prop.Name].ToUpper(), valorBaseMes.Value))}");
                                        csvBuilder.AppendLine(
                                        $"{servidor.CPF};{servidor.Matricula};{servidor.Nome};{baseano.ano};{mapeamentoMeses[prop.Name]};{valorBaseMes.Value};" +
                                        $"{GetAliquotaSMSS(baseano.ano, mapeamentoMeses[prop.Name].ToUpper())};" +
                                        $"{await GetSMSS(baseano.ano, mapeamentoMeses[prop.Name].ToUpper(), valorBaseMes.Value)};" +
                                        $"{await GetINPC(2024, mapeamentoMeses[prop.Name].ToUpper())};" +
                                        $"{await GetINPC(baseano.ano, mapeamentoMeses[prop.Name].ToUpper())};" +
                                        $"{await Corrigir(2024, baseano.ano, mapeamentoMeses[prop.Name].ToUpper(), mapeamentoMeses[prop.Name].ToUpper(), await GetSMSS(baseano.ano, mapeamentoMeses[prop.Name].ToUpper(), valorBaseMes.Value))}"
                                         );
                                    }
                                }
                            }

                        }
                    }
                }
            }
            string caminhoArquivo = "D:\\Decenio\\DeceniosParaLancar.csv";
            await File.WriteAllTextAsync(caminhoArquivo, csvBuilder.ToString());
            Console.WriteLine("Dados salvos no arquivo CSV com sucesso.");
        }
        static decimal GetAliquotaSMSS(short? ano,string mes)
        {
            decimal tx1 = 0.11M;
            decimal tx2 = 0.14M;
            decimal tx = 0.00M;
            if (ano >= 2020)
            {
                if (ano == 2020)
                {
                    if (mes == "JAN")
                    {
                        tx = tx1;
                    }
                    if (mes == "FEV")
                    {
                        tx = tx1;
                    }
                    if (mes == "MAR")
                    {
                        tx = tx1;
                    }
                    if (mes == "ABR")
                    {
                        tx = tx2;
                    }
                    if (mes == "MAI")
                    {
                        tx = tx2;
                    }
                    if (mes == "JUN")
                    {
                        tx = tx2;
                    }
                    if (mes == "JUL")
                    {
                        tx = tx2;
                    }
                    if (mes == "AGO")
                    {
                        tx = tx2;
                    }
                    if (mes == "SETE")
                    {
                        tx = tx2;
                    }
                    if (mes == "OUTU")
                    {
                        tx = tx2;
                    }
                    if (mes == "NOV")
                    {
                        tx = tx2;
                    }
                    if (mes == "DEZ")
                    {
                        tx = tx2;
                    }
                    if (mes == "DECIMO3")
                    {
                        tx = tx2;
                    }
                    if (mes == "DEC")
                    {
                        tx = tx2;
                    }
                }
                else
                {
                    tx = tx2;
                }
            }
            else
            {
                tx = tx1;

            }
            return tx;
        }
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
        static async Task<List<INPC>> CarregaHISTORICOINPC(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // Pegar uma instância do DbContext
                    var dbContext = services.GetRequiredService<DBProsigaContext>();
                    // Exemplo de operação com o DbContext
                    return await dbContext.INPC.ToListAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return null;
                }
            }
        }
        static async Task<decimal> Corrigir(short anoatual, short? anoacorrigir, string mesatual,string mesacorrigir,decimal? smss)
        {
            INPC? INPCATUAL;
            INPC? INPCaCorrigir;
            if(mesatual=="SETE")
            {
                mesatual = "SET";

            }
            if(mesatual == "OUTU")
            {
                mesatual = "OUT";
            }
            if (mesacorrigir == "SETE")
            {
                mesacorrigir = "SET";

            }
            if (mesacorrigir == "OUTU")
            {
                mesacorrigir = "OUT";
            }


            if (mesacorrigir=="DECIMO3" || mesacorrigir == "DEC"  )
            {
                INPCATUAL = await Task.FromResult(result: HISTORICOINPC.Find(i => i.ano == anoatual && i.mes == mesatual) ?? HISTORICOINPC.Where(i => i.ano == anoatual).OrderByDescending(i => i.mes).FirstOrDefault());
                INPCaCorrigir = await Task.FromResult(result: HISTORICOINPC.Find(i => i.ano == anoacorrigir && i.mes == "DEZ"));
            }
            else
            {

                INPCATUAL = await Task.FromResult(result: HISTORICOINPC.Find(i => i.ano == anoatual && i.mes == mesatual) ??  HISTORICOINPC.Where(i => i.ano == anoatual).OrderByDescending(i => i.mes).FirstOrDefault());
                INPCaCorrigir = await Task.FromResult(result: HISTORICOINPC.Find(i => i.ano == anoacorrigir && i.mes == mesacorrigir));
            }
            
            return Math.Round((decimal) await Task.FromResult(result: smss * (INPCATUAL.numero_indice / INPCaCorrigir.numero_indice)),2);
         }
        static async Task<decimal> GetINPC(short? ano, string mes)
        {
            INPC? INPCATUAL;
            INPC? INPCaCorrigir;
            if (mes == "SETE")
            {
                mes = "SET";

            }
            if (mes == "OUTU")
            {
                mes = "OUT";
            }
            if (mes == "DECIMO3")
            {
                mes = "DEZ";
            }
            if (mes == "DEC")
            {
                mes = "DEZ";
            }
            INPCATUAL = await Task.FromResult(result: HISTORICOINPC.Find(i => i.ano == ano && i.mes == mes) ?? HISTORICOINPC.Where(i => i.ano == ano).OrderByDescending(i => i.mes).FirstOrDefault());
            return Math.Round((decimal) INPCATUAL.numero_indice,2);
        }

        static async Task<decimal> GetSMSS(short? ano,string mes, decimal? valorBase)
        {
            decimal? SMSS = 0.00M;
            decimal tx1 = 0.11M;
            decimal tx2 = 0.14M;
            if (ano >= 2020)
            {
                if(ano == 2020)
                {
                        if (mes == "JAN")
                        {
                            SMSS = valorBase * tx1;
                        }
                        if (mes == "FEV")
                        {
                            SMSS = valorBase * tx1;
                        }
                        if (mes == "MAR")
                        {
                            SMSS = valorBase * tx1;
                        }
                        if (mes == "ABR")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "MAI")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "JUN")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "JUL")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "AGO")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "SETE")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "OUTU")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "NOV")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "DEZ")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "DECIMO3")
                        {
                            SMSS = valorBase * tx2;
                        }
                        if (mes == "DEC")
                        {
                            SMSS = valorBase * tx2;
                        }
                }
                else
                {
                        SMSS = valorBase * tx2;
                }
            }
            else
            {
                SMSS = valorBase * tx1;
            
            }
            return Math.Round(SMSS ?? 0.00M,2);
        }
        static async Task<AutoNumEntidade> BuscaAtualizaIDAutoNumEntidades(IHost host, string? autnumentidade)
        {
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
        static async Task<List<DecenioServidores>> BuscaDecenioServidores(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var dbContext = services.GetRequiredService<DBProsigaContext>();
                    var result = await dbContext.DecenioServidores.ToListAsync();
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return null;
                }
            }
        }
        static async Task<List<DecenioBase>> BuscaDecenioBaseServidor(IHost host, string cpf,int? matricula)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var dbContext = services.GetRequiredService<DBProsigaContext>();
                    var result = await dbContext.DecenioBase.Where(b=> b.CPF==cpf && b.Matricula==matricula).ToListAsync();
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return null;
                }
            }
        }
        static async Task LancaDividasServidor(IHost host, DecenioServidores servidor, DecenioBase decenioBase)
        {
            bool inserir = false;
            TribDividasContribuinte? divida = new TribDividasContribuinte();
            divida.TipoTribId = 395;
            divida.ConDivSubDivida = 0;
            divida.ConDivParcela = 0;
            //divida.ConDivVencimento = "";
            //divida.ConDivDataGeracao = "";
            divida.ConDivTipoDivida = 1;
            divida.ConDivSaiBoleto = "SIM";
            divida.ConDivExcluido = null;
            //    divida.ConDivDataUltimaCorrecao=
            divida.ConDivOrigemLancamento = "Manual";
            divida.ConDivParcelaUnica = "Sim";
            //divida.ConDivMes = 
            divida.ConDivAno = 2024;
            divida.TipoBxId = 1;
            divida.Idmoeda = 1;
            if(decenioBase.jan != 0.00M)
            {
                AutoNumEntidade autonum = await BuscaAtualizaIDAutoNumEntidades(host, "TribDividasContribuinte");
                divida.ConIddivida = autonum.AutNumId;
                divida.ConDivVlrUltimaCorrecao = await Corrigir(2024, decenioBase.ano, "JAN", "JAN", await GetSMSS(decenioBase.ano, "JAN", decenioBase.jan));
                divida.ConDivValorHistorico = await Corrigir(2024, decenioBase.ano, "JAN", "JAN", await GetSMSS(decenioBase.ano, "JAN", decenioBase.jan));
                divida.ConDivValor = await Corrigir(2024, decenioBase.ano, "JAN", "JAN", await GetSMSS(decenioBase.ano, "JAN", decenioBase.jan));
                inserir = true;
            }
            if (inserir)
            {

            }
        }
        static async Task  InsereDividas(IHost host, TribDividasContribuinte divida)
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
                    var dividainserida = await dbContext.TribDividasContribuintes.AddAsync(divida);
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
        static async Task InsereComposicaoDividas(IHost host, TribComposicaoDivContribuinte composicaodivida)
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
                    var dividainserida = await dbContext.TribComposicaoDivContribuintes.AddAsync(composicaodivida);
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

