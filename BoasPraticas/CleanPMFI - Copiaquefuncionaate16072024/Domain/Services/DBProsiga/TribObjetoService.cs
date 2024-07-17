using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribObjetoService : ServiceBase<TribObjeto>, ITribObjetoService
    {
        private readonly ITribObjetoRepository _Repository;

        public TribObjetoService(ITribObjetoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
     /*   public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<TribObjeto> GeraNossoNumero(TribObjeto TribObjeto) {
            return await _Repository.GeraNossoNumero(TribObjeto);
        }*/
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
