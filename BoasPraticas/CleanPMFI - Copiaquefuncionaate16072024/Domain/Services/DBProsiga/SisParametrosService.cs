using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class SisParametrosService : ServiceBase<SisParametro>, ISisParametrosService
    {
        private readonly ISisParametrosRepository _Repository;

        public SisParametrosService(ISisParametrosRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
     /*   public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<TribSisParametros> GeraNossoNumero(TribSisParametros TribSisParametros) {
            return await _Repository.GeraNossoNumero(TribSisParametros);
        }*/
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
