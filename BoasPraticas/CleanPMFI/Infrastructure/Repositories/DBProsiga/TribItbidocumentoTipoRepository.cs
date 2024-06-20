using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Specifications;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repositories.DBProsiga
{
    public class TribItbidocumentoTipoRepository : RepositoryBase<TribItbidocumentoTipo>, ITribItbidocumentoTipoRepository
    {
        //private readonly IServiceScopeFactory _scopeFactory;
        //public DBProsigaContext dBProsigaContext { get; set; }
         //public TribItbidocumentoTipoRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext context) : base(ServiceScopeFactory,context)   { }
        /*public TribItbidocumentoTipoRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext dbContext) : base(ServiceScopeFactory, dbContext)
        {
          //  _scopeFactory = ServiceScopeFactory;
        }*/
        public TribItbidocumentoTipoRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        public TribItbidocumentoTipoRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
       //public TribItbidocumentoTipoRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator,IServiceScopeFactory iServiceScopeFactory) : base(dbContext, specificationEvaluator, iServiceScopeFactory) { }

        //public TribItbidocumentoTipoRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper) { }
        /*  public virtual async Task<List<TribItbidocumentoTipo>> ListAsync(ISpecification<TribItbidocumentoTipo> specification, CancellationToken cancellationToken = default)
          {
              using (var scope = ServiceScopeFactory.CreateAsyncScope())
              {
                  var serviceProvider = scope.ServiceProvider;
                  var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                  var queryResult = await ApplySpecification(specification).ToListAsync(cancellationToken);

              return specification.PostProcessingAction == null ? queryResult : specification.PostProcessingAction(queryResult).ToList();

              }
          }*/
         /* public virtual IQueryable<TribItbidocumentoTipo> ApplySpecification(ISpecification<TribItbidocumentoTipo> specification, bool evaluateCriteriaOnly = false)
          {
              using (var scope = ServiceScopeFactory.CreateAsyncScope())
              {
                  var serviceProvider = scope.ServiceProvider;
                  var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();


                  //return await repository.ProjectToListAsync<TResult>(specification, filter, cancellationToken);
                  return Evaluator.GetQuery(xdbcontexto.Set<TribItbidocumentoTipo>().AsQueryable(), specification, evaluateCriteriaOnly);
                  //return Evaluator.GetQuery(_dbContext.Set<T>(), specification, evaluateCriteriaOnly);
              }
          }*/
    }
}
