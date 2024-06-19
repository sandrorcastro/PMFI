using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribBoletosBarraService : ServiceBase<TribBoletosBarra>, ITribBoletosBarraService
    {
        private readonly ITribBoletosBarraRepository _Repository;

        public TribBoletosBarraService(ITribBoletosBarraRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
     /*   public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<TribBoletosBarra> GeraNossoNumero(TribBoletosBarra TribBoletosBarra) {
            return await _Repository.GeraNossoNumero(TribBoletosBarra);
        }*/
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
