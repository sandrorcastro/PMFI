using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Entities;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Specs.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace Infrastructure.Repositories.DBProsiga
{
    public class AutoNumAnoNumeroRepository : RepositoryBase<AutoNumAnoNumero>, IAutoNumAnoNumeroRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        //public DBProsigaContext dBProsigaContext { get; set; }
        //     public AutoNumAnoNumeroRepository(IServiceScopeFactory ServiceScopeFactory, DbContext context) : base(ServiceScopeFactory,context)   { }
        public AutoNumAnoNumeroRepository(IServiceScopeFactory ServiceScopeFactory , DBProsigaContext dbContext) : base(ServiceScopeFactory, dbContext)
        {
            _scopeFactory = ServiceScopeFactory;
        }
    //    public AutoNumAnoNumeroRepository(DBProsigaContext context) : base(context) { }
      //  //public AutoNumAnoNumeroRepository(IDbContextFactory<DBProsigaContext> _contextFactory) : base(_contextFactory) { }
     //   public AutoNumAnoNumeroRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
     //   public AutoNumAnoNumeroRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
        
        public async Task<AutoNumAnoNumero> GetMaxAutoNumAnoNumero(short AutoAno, string AutoTipo)
        {
            //using(var scope = _scopeFactory.CreateAsyncScope())
            using (var scope = ServiceScopeFactory.CreateAsyncScope())
            {
                var serviceProvider = scope.ServiceProvider;
                //var __dbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
          //      var xdbcontexto = serviceProvider.GetRequiredService<dBProsigaContext>();
                AutoNumAnoNumero numero = await xdbcontexto.Set<AutoNumAnoNumero>().AsNoTracking().Where(a => a.AutAno == AutoAno && a.AutTipo == AutoTipo).FirstOrDefaultAsync();
                numero.AutNumero = numero.AutNumero + 1;
                xdbcontexto.Update<AutoNumAnoNumero>(numero);
                await xdbcontexto.SaveChangesAsync();
                return numero;

            }
        }
        
        /*
       public async Task<AutoNumAnoNumero> GetMaxAutoNumAnoNumero(short AutoAno, string AutoTipo)
        {

            
               if (_dbContext == null)
               {
                   throw new Exception("Contexto do banco de dados não inicializado.");
               }
          
            //using var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
               {
                   //  AutoNumAnoNumeroSpec autospec = new AutoNumAnoNumeroSpec((short) AutoAno,AutoTipo);
                   // AutoNumAnoNumero numero = await _dbContext.Set<AutoNumAnoNumero>().Where(a => a.AutAno == 2024 && a.AutTipo== "ITBI").FirstOrDefaultAsync();  //   .FindAsync(inscricao);

                   //AutoNumAnoNumero numero = await _dbContext.Set<AutoNumAnoNumero>().FirstOrDefaultAsync(a => a.AutAno == 2024 && a.AutTipo == "ITBI",CancellationToken.None);  

                   AutoNumAnoNumero numero = await _dbContext.Set<AutoNumAnoNumero>().Where(a => a.AutAno == AutoAno && a.AutTipo == AutoTipo).FirstOrDefaultAsync();

                   // AutoNumAnoNumero numero = await _dbContext.FindAsync<AutoNumAnoNumero>(new object[] {(short)AutoAno,AutoTipo});
                   //AutoNumAnoNumero numero = await _dbContext.FindAsync(new object[] { 2024, "ITBI" });
                   numero.AutNumero = numero.AutNumero + 1;
                    //_dbContext.Update<AutoNumAnoNumero>(new AutoNumAnoNumero() { AutAno = AutoAno,AutTipo=AutoTipo,AutNumero=numero.AutNumero + 1}) ;
                    _dbContext.Update<AutoNumAnoNumero>(numero);
                   _dbContext.SaveChangesAsync();
                //   transaction.CommitAsync();
                  
                  // _dbContext.DisposeAsync();
                   return numero;


               } catch(Exception ex) {
                   // throw new NotImplementedException();
                   throw  ex;
               }
        }
        */
       
    }
}
