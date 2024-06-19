using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribBoletoAppService : AppServiceBase<TribBoleto>, ITribBoletoAppService
    {
        private readonly ITribBoletoService TribBoletoService;

        public TribBoletoAppService(ITribBoletoService _TribBoletoService)
            : base(_TribBoletoService)
        {
            TribBoletoService = _TribBoletoService;
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
