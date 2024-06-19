using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repositories.DBProsiga
{
    public class AutoNumEntidadesRepository : RepositoryBase<AutoNumEntidade>, IAutoNumEntidadesRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        //     public AutoNumAnoNumeroRepository(IServiceScopeFactory ServiceScopeFactory, DbContext context) : base(ServiceScopeFactory,context)   { }
        public AutoNumEntidadesRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext dbContext) : base(ServiceScopeFactory,dbContext)
        {
            _scopeFactory = ServiceScopeFactory;
        }
        //  public AutoNumEntidadesRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        //  public AutoNumEntidadesRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }

        public async Task<long> GetMaxAutoNumEntidade(string AutoNumEntidade)
        {

            //using (var scope = _scopeFactory.CreateAsyncScope())
            using (var scope =  ServiceScopeFactory.CreateAsyncScope())
            {
                var serviceProvider = scope.ServiceProvider;
                //var __dbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                AutoNumEntidade numero = await xdbcontexto.Set<AutoNumEntidade>().AsNoTracking().Where(a => a.AutNumEntidade == AutoNumEntidade).FirstOrDefaultAsync();
                numero.AutNumId = numero.AutNumId + 1;
                xdbcontexto.Update<AutoNumEntidade>(numero);
                await xdbcontexto.SaveChangesAsync();
                return numero.AutNumId;

            }

        }




        /*
        public async Task<AutoNumEntidade> GetMaxAutoNumEntidade(string AutoNumEntidade)
        {
            if (_dbContext == null)
            {
                throw new Exception("Contexto do banco de dados não inicializado.");
            }
            //using var transaction = await  _dbContext.Database.BeginTransactionAsync();
            //using (var scope = _dbContext.)
                try
                {
                    //  AutoNumAnoNumeroSpec autospec = new AutoNumAnoNumeroSpec((short) AutoAno,AutoTipo);
                    // AutoNumAnoNumero numero = await _dbContext.Set<AutoNumAnoNumero>().Where(a => a.AutAno == 2024 && a.AutTipo== "ITBI").FirstOrDefaultAsync();  //   .FindAsync(inscricao);

                    //AutoNumAnoNumero numero = await _dbContext.Set<AutoNumAnoNumero>().FirstOrDefaultAsync(a => a.AutAno == 2024 && a.AutTipo == "ITBI",CancellationToken.None);  

                    AutoNumEntidade numero = await _dbContext.Set<AutoNumEntidade>().Where(a => a.AutNumEntidade == AutoNumEntidade).FirstOrDefaultAsync();

                    // AutoNumAnoNumero numero = await _dbContext.FindAsync<AutoNumAnoNumero>(new object[] {(short)AutoAno,AutoTipo});
                    //AutoNumAnoNumero numero = await _dbContext.FindAsync(new object[] { 2024, "ITBI" });
                    numero.AutNumId = numero.AutNumId + 1;
                    //_dbContext.Update<AutoNumAnoNumero>(new AutoNumAnoNumero() { AutAno = AutoAno,AutTipo=AutoTipo,AutNumero=numero.AutNumero + 1}) ;
                    _dbContext.Update<AutoNumEntidade>(numero);
                    _dbContext.SaveChangesAsync();
                
                
                  //  transaction.CommitAsync();
                
                    // _dbContext.DisposeAsync();
                    return numero;


                }
                catch (Exception ex)
                {
                    // throw new NotImplementedException();
                    throw ex;
                }
        }*/
    }
}

        