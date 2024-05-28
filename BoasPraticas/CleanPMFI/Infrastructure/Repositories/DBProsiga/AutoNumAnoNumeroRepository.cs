using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Specs.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.DBProsiga
{
    public class AutoNumAnoNumeroRepository : RepositoryBase<AutoNumAnoNumero>, IAutoNumAnoNumeroRepository
    {
        public AutoNumAnoNumeroRepository(DBProsigaContext context) : base(context) { }
        public AutoNumAnoNumeroRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        public AutoNumAnoNumeroRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }

        public async Task<AutoNumAnoNumero> GetMaxAutoNumAnoNumero(short AutoAno, string AutoTipo)
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                //  AutoNumAnoNumeroSpec autospec = new AutoNumAnoNumeroSpec((short) AutoAno,AutoTipo);
                // AutoNumAnoNumero numero = await _dbContext.Set<AutoNumAnoNumero>().Where(a => a.AutAno == 2024 && a.AutTipo== "ITBI").FirstOrDefaultAsync();  //   .FindAsync(inscricao);
                 
                AutoNumAnoNumero numero = await _dbContext.Set<AutoNumAnoNumero>().FirstOrDefaultAsync(a => a.AutAno == 2024 && a.AutTipo == "ITBI",CancellationToken.None);  
                                                                                                                                                               // AutoNumAnoNumero numero = await _dbContext.FindAsync<AutoNumAnoNumero>(new object[] {(short)AutoAno,AutoTipo});
                                                                                                                                                               //AutoNumAnoNumero numero = await _dbContext.FindAsync(new object[] { 2024, "ITBI" });
               // _dbContext.Update(new AutoNumAnoNumero() { AutAno = AutoAno,AutTipo=AutoTipo,AutNumero=numero.AutNumero + 1});
                transaction.Commit();
                return numero;


            } catch(Exception ex) {
                throw new NotImplementedException();
            }
        }
    }
}
