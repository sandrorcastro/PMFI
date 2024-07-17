using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribBoletoService : ServiceBase<TribBoleto>, ITribBoletoService
    {
        private readonly ITribBoletoRepository _Repository;

        public TribBoletoService(ITribBoletoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
     /*   public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<TribBoleto> GeraNossoNumero(TribBoleto TribBoleto) {
            return await _Repository.GeraNossoNumero(TribBoleto);
        }*/
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
