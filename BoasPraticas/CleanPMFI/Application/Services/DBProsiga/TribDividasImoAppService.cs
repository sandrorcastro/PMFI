using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class TribDividasImoAppService : AppServiceBase<TribDividasImo>, ITribDividasImoAppService
    {
        private readonly ITribDividasImoService TribDividasImoService;

        public TribDividasImoAppService(ITribDividasImoService _TribDividasImoService)
            : base(_TribDividasImoService)
        {
            TribDividasImoService = _TribDividasImoService;
        }
        /*public TribDividasImoAppService(IServiceBase<TribDividasImo> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
