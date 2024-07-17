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
    public class ConvenioBancoRepository : RepositoryBase<ConvenioBanco>, IConvenioBancoRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public ConvenioBancoRepository(IServiceScopeFactory ServiceScopeFactory, DBProsigaContext dbContext) : base(ServiceScopeFactory, dbContext)
        {
            _scopeFactory = ServiceScopeFactory;
        }
      //  public ConvenioBancoRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
       // public ConvenioBancoRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
        public async Task<long> GeraNossoNumero(int ConvenioId)
        
        {
            //using(var scope = _scopeFactory.CreateAsyncScope())
            using (var scope = ServiceScopeFactory.CreateAsyncScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();
                
                ConvenioBanco cp = await xdbcontexto.Set<ConvenioBanco>().AsNoTracking().Where(c => c.ConvenioId==ConvenioId).FirstOrDefaultAsync();
                cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                xdbcontexto.Update<ConvenioBanco>(cp);
                await xdbcontexto.SaveChangesAsync();
                return (long ) cp.ConvNossoNumero;

            }
        }
        public async Task<ConvenioBanco> GeraNossoNumero(ConvenioBanco ConvenioBanco)
        {
            //using(var scope = _scopeFactory.CreateAsyncScope())
            using (var scope = ServiceScopeFactory.CreateAsyncScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var xdbcontexto = serviceProvider.GetRequiredService<DBProsigaContext>();

                ConvenioBanco cp = await xdbcontexto.Set<ConvenioBanco>().AsNoTracking().Where(c => c.ConvenioId == ConvenioBanco.ConvenioId).FirstOrDefaultAsync();
                cp.ConvNossoNumero = cp.ConvNossoNumero + 1;
                xdbcontexto.Update<ConvenioBanco>(cp);
                await xdbcontexto.SaveChangesAsync();
                return cp;

            }
        }
    }
}
