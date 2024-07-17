using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class TribComposicaoDivImoAppService : AppServiceBase<TribComposicaoDivImo>, ITribComposicaoDivImoAppService
    {
        private readonly ITribComposicaoDivImoService TribComposicaoDivImoService;

        public TribComposicaoDivImoAppService(ITribComposicaoDivImoService _TribComposicaoDivImoService)
            : base(_TribComposicaoDivImoService)
        {
            TribComposicaoDivImoService = _TribComposicaoDivImoService;
        }
        /*public TribComposicaoDivImoService(IServiceBase<TribDividasImo> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
