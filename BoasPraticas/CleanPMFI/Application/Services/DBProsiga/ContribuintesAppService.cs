using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class ContribuintesAppService : AppServiceBase<Contribuinte>, IContribuintesAppService
    {
        private readonly IContribuintesService ContribuintesService;

        public ContribuintesAppService(IContribuintesService _ContribuintesService)
            : base(_ContribuintesService)
        {
            ContribuintesService = _ContribuintesService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await ContribuintesService.GeraNossoNumero(ConvenioId);
        }
        public async Task<Contribuintes> GeraNossoNumero(Contribuintes Contribuintes)
        {
            return await ContribuintesService.GeraNossoNumero(Contribuintes);
        }*/
        /*public ContribuintesAppService(IServiceBase<Contribuintes> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
