using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribBoletosBarraAppService : AppServiceBase<TribBoletosBarra>, ITribBoletosBarraAppService
    {
        private readonly ITribBoletosBarraService TribBoletosBarraService;

        public TribBoletosBarraAppService(ITribBoletosBarraService _TribBoletosBarraService)
            : base(_TribBoletosBarraService)
        {
            TribBoletosBarraService = _TribBoletosBarraService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await TribBoletoService.GeraNossoNumero(ConvenioId);
        }
        public async Task<TribBoleto> GeraNossoNumero(TribBoleto TribBoleto)
        {
            return await TribBoletoService.GeraNossoNumero(TribBoleto);
        }*/
        /*public TribBoletoAppService(IServiceBase<TribBoleto> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
