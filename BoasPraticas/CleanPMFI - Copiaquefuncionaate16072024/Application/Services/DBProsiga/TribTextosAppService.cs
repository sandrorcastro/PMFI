using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribTextosAppService : AppServiceBase<TribTexto>, ITribTextosAppService
    {
        private readonly ITribTextosService TribTextosService;

        public TribTextosAppService(ITribTextosService _TribTextosService)
            : base(_TribTextosService)
        {
            TribTextosService = _TribTextosService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await TribTextosService.GeraNossoNumero(ConvenioId);
        }
        public async Task<TribTextos> GeraNossoNumero(TribTextos TribTextos)
        {
            return await TribTextosService.GeraNossoNumero(TribTextos);
        }*/
        /*public TribTextosAppService(IServiceBase<TribTextos> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
