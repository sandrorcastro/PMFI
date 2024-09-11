using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class CepcorreioAppService : AppServiceBase<Cepcorreio>, ICepcorreioAppService
    {
        private readonly ICepcorreioService CepcorreioService;

        public CepcorreioAppService(ICepcorreioService _CepcorreioService)
            : base(_CepcorreioService)
        {
            CepcorreioService = _CepcorreioService;
        }
        /*public CepcorreioAppService(IServiceBase<Cepcorreio> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
