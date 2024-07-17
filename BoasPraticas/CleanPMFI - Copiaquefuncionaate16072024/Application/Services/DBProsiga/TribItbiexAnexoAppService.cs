using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class TribItbiexAnexoAppService : AppServiceBase<TribItbiexAnexo>, ITribItbiexAnexoAppService
    {
        private readonly ITribItbiexAnexoService Service;

        public TribItbiexAnexoAppService(ITribItbiexAnexoService _Service)
            : base(_Service)
        {
            Service = _Service;
        }
        /*public TribItbiexAnexoAppService(IServiceBase<TribItbiexAnexo> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
