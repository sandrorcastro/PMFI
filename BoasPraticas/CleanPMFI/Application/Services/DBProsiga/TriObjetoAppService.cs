using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribObjetoAppService : AppServiceBase<TribObjeto>, ITribObjetoAppService
    {
        private readonly ITribObjetoService TribObjetoService;

        public TribObjetoAppService(ITribObjetoService _TribObjetoService)
            : base(_TribObjetoService)
        {
            TribObjetoService = _TribObjetoService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await TribObjetoService.GeraNossoNumero(ConvenioId);
        }
        public async Task<TribObjeto> GeraNossoNumero(TribObjeto TribObjeto)
        {
            return await TribObjetoService.GeraNossoNumero(TribObjeto);
        }*/
        /*public TribObjetoAppService(IServiceBase<TribObjeto> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
