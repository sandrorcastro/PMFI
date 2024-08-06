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
    public class TribEmpresasRepository : RepositoryBase<TribEmpresa>, ITribEmpresasRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public TribEmpresasRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext dbContext) : base(ServiceScopeFactory, dbContext)
        {
            _scopeFactory = ServiceScopeFactory;
        }
     /*   public override async Task<TribEmpresas> AddAsync(TribEmpresas entity, CancellationToken cancellationToken = default)
        {

            //using (var scope = ServiceScopeFactory.CreateAsyncScope())
            using (var scope = ServiceScopeFactory.CreateAsyncScope())
            {
                try
                {

                var serviceProvider = scope.ServiceProvider;
                //var dbcontexto = serviceProvider.GetRequiredService<>();
                var dbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                await dbcontexto.Set<TribEmpresas>().AddAsync(entity);
                await SaveChangesAsync(cancellationToken);
                return entity; 
                }catch (Exception ex)
                {
                    throw ex;
                }
            }

            

            //await _dbContext.Set<TribEmpresas>().AddAsync(entity);

            //await SaveChangesAsync(cancellationToken);

            return entity;
        }*/
        //  public TribEmpresasRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        // public TribEmpresasRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
        /*   public async Task<long> GeraNossoNumero(int ConvenioId)

           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   TribEmpresas cp = await xdbcontexto.Set<TribEmpresas>().AsNoTracking().Where(c => c.ConvenioId==ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<TribEmpresas>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return (long ) cp.ConvNossoNumero;

               }
           }
           public async Task<TribEmpresas> GeraNossoNumero(TribEmpresas TribEmpresas)
           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   TribEmpresas cp = await xdbcontexto.Set<TribEmpresas>().AsNoTracking().Where(c => c.ConvenioId == TribEmpresas.ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<TribEmpresas>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return cp;

               }
           }*/
    }
}
