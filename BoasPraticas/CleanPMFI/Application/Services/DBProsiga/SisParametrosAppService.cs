using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class SisParametrosAppService : AppServiceBase<SisParametro>, ISisParametrosAppService
    {
        private readonly ISisParametrosService SisParametrosService;

        public SisParametrosAppService(ISisParametrosService _SisParametrosService)
            : base(_SisParametrosService)
        {
            SisParametrosService = _SisParametrosService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await SisParametrosService.GeraNossoNumero(ConvenioId);
        }
        public async Task<SisParametros> GeraNossoNumero(SisParametros SisParametros)
        {
            return await SisParametrosService.GeraNossoNumero(SisParametros);
        }*/
        /*public SisParametrosAppService(IServiceBase<SisParametros> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
