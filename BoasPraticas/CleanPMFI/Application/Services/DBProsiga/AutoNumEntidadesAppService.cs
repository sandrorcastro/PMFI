using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class AutoNumEntidadesAppService : AppServiceBase<AutoNumEntidade>, IAutoNumEntidadesAppService
    {
        private readonly IAutoNumEntidadesService Service;

        public AutoNumEntidadesAppService(IAutoNumEntidadesService _Service)
            : base(_Service)
        {
            Service = _Service;
        }
        public async Task<AutoNumEntidade> GetMaxAutoNumEntidade(string AutoNumEntidade) {
            return await Service.GetMaxAutoNumEntidade(AutoNumEntidade);

        }
        
        /*public AutoNumAutoNumEntidadesAppService(IServiceBase<AutoNumAutoNumEntidades> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
