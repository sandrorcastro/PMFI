using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class AutoNumAnoNumeroAppService : AppServiceBase<AutoNumAnoNumero>, IAutoNumAnoNumeroAppService
    {
        private readonly IAutoNumAnoNumeroService Service;

        public AutoNumAnoNumeroAppService(IAutoNumAnoNumeroService _Service)
            : base(_Service)
        {
            Service = _Service;
        }
        /*public AutoNumAnoNumeroAppService(IServiceBase<AutoNumAnoNumero> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
