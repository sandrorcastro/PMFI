﻿using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repositories.DBProsiga
{
    public class TribObjetoRepository : RepositoryBase<TribObjeto>, ITribObjetoRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public TribObjetoRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext dbContext) : base(ServiceScopeFactory, dbContext)
        {
            _scopeFactory = ServiceScopeFactory;
        }
     /*   public override async Task<TribObjeto> AddAsync(TribObjeto entity, CancellationToken cancellationToken = default)
        {

            //using (var scope = ServiceScopeFactory.CreateAsyncScope())
            using (var scope = ServiceScopeFactory.CreateAsyncScope())
            {
                try
                {

                var serviceProvider = scope.ServiceProvider;
                //var dbcontexto = serviceProvider.GetRequiredService<>();
                var dbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                await dbcontexto.Set<TribObjeto>().AddAsync(entity);
                await SaveChangesAsync(cancellationToken);
                return entity; 
                }catch (Exception ex)
                {
                    throw ex;
                }
            }

            

            //await _dbContext.Set<TribObjeto>().AddAsync(entity);

            //await SaveChangesAsync(cancellationToken);

            return entity;
        }*/
        //  public TribObjetoRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        // public TribObjetoRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
        /*   public async Task<long> GeraNossoNumero(int ConvenioId)

           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   TribObjeto cp = await xdbcontexto.Set<TribObjeto>().AsNoTracking().Where(c => c.ConvenioId==ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<TribObjeto>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return (long ) cp.ConvNossoNumero;

               }
           }
           public async Task<TribObjeto> GeraNossoNumero(TribObjeto TribObjeto)
           {
               //using(var scope = _scopeFactory.CreateAsyncScope())
               using (var scope = ServiceScopeFactory.CreateAsyncScope())
               {
                   var serviceProvider = scope.ServiceProvider;
                   var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                   TribObjeto cp = await xdbcontexto.Set<TribObjeto>().AsNoTracking().Where(c => c.ConvenioId == TribObjeto.ConvenioId).FirstOrDefaultAsync();
                   cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                   xdbcontexto.Update<TribObjeto>(cp);
                   await xdbcontexto.SaveChangesAsync();
                   return cp;

               }
           }*/
    }
}
