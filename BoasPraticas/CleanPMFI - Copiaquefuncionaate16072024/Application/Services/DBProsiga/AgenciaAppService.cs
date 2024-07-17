using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class AgenciaAppService : AppServiceBase<Agencium>, IAgenciaAppService
    {
        private readonly IAgenciaService AgenciaService;

        public AgenciaAppService(IAgenciaService _AgenciaService)
            : base(_AgenciaService)
        {
            AgenciaService = _AgenciaService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await AgenciaService.GeraNossoNumero(ConvenioId);
        }
        public async Task<Agencia> GeraNossoNumero(Agencia Agencia)
        {
            return await AgenciaService.GeraNossoNumero(Agencia);
        }*/
        /*public AgenciaAppService(IServiceBase<Agencia> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
