using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribEmpresasService : ServiceBase<TribEmpresa>, ITribEmpresasService
    {
        private readonly ITribEmpresasRepository _Repository;

        public TribEmpresasService(ITribEmpresasRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
     /*   public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<TribEmpresas> GeraNossoNumero(TribEmpresas TribEmpresas) {
            return await _Repository.GeraNossoNumero(TribEmpresas);
        }*/
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
