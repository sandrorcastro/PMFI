using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class ConvenioBancoService : ServiceBase<ConvenioBanco>, IConvenioBancoService
    {
        private readonly IConvenioBancoRepository _Repository;

        public ConvenioBancoService(IConvenioBancoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
        public async Task<long> GeraNossoNumero(int ConvenioId) { 
            return await _Repository.GeraNossoNumero(ConvenioId);
        }
        public async  Task<ConvenioBanco> GeraNossoNumero(ConvenioBanco ConvenioBanco) {
            return await _Repository.GeraNossoNumero(ConvenioBanco);
        }
        
        
        
        /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
          {
          }*/
    }
}
