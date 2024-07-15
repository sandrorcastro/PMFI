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
    public class TribReportParRepository : RepositoryBase<TribReportPar>, ITribReportParRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public TribReportParRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext dbContext) : base(ServiceScopeFactory, dbContext)
        {
            _scopeFactory = ServiceScopeFactory;
        }
     /*   public override async Task<TribReportPar> AddAsync(TribReportPar entity, CancellationToken cancellationToken = default)
        {

            //using (var scope = ServiceScopeFactory.CreateAsyncScope())
            using (var scope = ServiceScopeFactory.CreateAsyncScope())
            {
                try
                {

                var serviceProvider = scope.ServiceProvider;
                //var dbcontexto = serviceProvider.GetRequiredService<>();
                var dbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                await dbcontexto.Set<TribReportPar>().AddAsync(entity);
                await SaveChangesAsync(cancellationToken);
                return entity; 
                }catch (Exception ex)
                {
                    throw ex;
                }
            }

            

            //await _dbContext.Set<TribReportPar>().AddAsync(entity);

            //await SaveChangesAsync(cancellationToken);

            return entity;
        }*/
        //  public TribReportParRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        // public TribReportParRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
        /*   public async Task<long> GeraNossoNumero(int ConvenioId)

           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   TribReportPar cp = await xdbcontexto.Set<TribReportPar>().AsNoTracking().Where(c => c.ConvenioId==ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<TribReportPar>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return (long ) cp.ConvNossoNumero;

               }
           }
           public async Task<TribReportPar> GeraNossoNumero(TribReportPar TribReportPar)
           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   TribReportPar cp = await xdbcontexto.Set<TribReportPar>().AsNoTracking().Where(c => c.ConvenioId == TribReportPar.ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<TribReportPar>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return cp;

               }
           }*/
    }
}
