using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribReportParService : ServiceBase<TribReportPar>, ITribReportParService
    {
        private readonly ITribReportParRepository _Repository;

        public TribReportParService(ITribReportParRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
     /*   public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<TribReportPar> GeraNossoNumero(TribReportPar TribReportPar) {
            return await _Repository.GeraNossoNumero(TribReportPar);
        }*/
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
