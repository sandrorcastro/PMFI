using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribBoletosDividasAppService : AppServiceBase<TribBoletosDivida>, ITribBoletosDividasAppService
    {
        private readonly ITribBoletosDividasService TribBoletosDividasService;

        public TribBoletosDividasAppService(ITribBoletosDividasService _TribBoletosDividasService)
            : base(_TribBoletosDividasService)
        {
            TribBoletosDividasService = _TribBoletosDividasService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await TribBoletosDividasService.GeraNossoNumero(ConvenioId);
        }
        public async Task<TribBoletosDividas> GeraNossoNumero(TribBoletosDividas TribBoletosDividas)
        {
            return await TribBoletosDividasService.GeraNossoNumero(TribBoletosDividas);
        }*/
        /*public TribBoletosDividasAppService(IServiceBase<TribBoletosDividas> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
