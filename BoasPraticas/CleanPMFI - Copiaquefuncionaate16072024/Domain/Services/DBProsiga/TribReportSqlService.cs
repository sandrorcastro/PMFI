using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribReportSqlService : ServiceBase<TribReportSql>, ITribReportSqlService
    {
        private readonly ITribReportSqlRepository _Repository;

        public TribReportSqlService(ITribReportSqlRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
     /*   public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<TribReportSql> GeraNossoNumero(TribReportSql TribReportSql) {
            return await _Repository.GeraNossoNumero(TribReportSql);
        }*/
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
