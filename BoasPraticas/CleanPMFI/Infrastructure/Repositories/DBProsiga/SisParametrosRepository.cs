using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repositories.DBProsiga
{
    public class SisParametrosRepository : RepositoryBase<SisParametro>, ISisParametrosRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public SisParametrosRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext dbContext) : base(ServiceScopeFactory, dbContext)
        {
            _scopeFactory = ServiceScopeFactory;
        }
     /*   public override async Task<SisParametros> AddAsync(SisParametros entity, CancellationToken cancellationToken = default)
        {

            //using (var scope = ServiceScopeFactory.CreateAsyncScope())
            using (var scope = ServiceScopeFactory.CreateAsyncScope())
            {
                try
                {

                var serviceProvider = scope.ServiceProvider;
                //var dbcontexto = serviceProvider.GetRequiredService<>();
                var dbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                await dbcontexto.Set<SisParametros>().AddAsync(entity);
                await SaveChangesAsync(cancellationToken);
                return entity; 
                }catch (Exception ex)
                {
                    throw ex;
                }
            }

            

            //await _dbContext.Set<SisParametros>().AddAsync(entity);

            //await SaveChangesAsync(cancellationToken);

            return entity;
        }*/
        //  public SisParametrosRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        // public SisParametrosRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
        /*   public async Task<long> GeraNossoNumero(int ConvenioId)

           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   SisParametros cp = await xdbcontexto.Set<SisParametros>().AsNoTracking().Where(c => c.ConvenioId==ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<SisParametros>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return (long ) cp.ConvNossoNumero;

               }
           }
           public async Task<SisParametros> GeraNossoNumero(SisParametros SisParametros)
           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   SisParametros cp = await xdbcontexto.Set<SisParametros>().AsNoTracking().Where(c => c.ConvenioId == SisParametros.ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<SisParametros>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return cp;

               }
           }*/
    }
}
