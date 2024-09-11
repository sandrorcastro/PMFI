using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;


namespace Application.Services.DBProsiga
{
    public class CepAppService : AppServiceBase<Cep>, ICepAppService
    {
        private readonly ICepService CepService;

        public CepAppService(ICepService _CepService)
            : base(_CepService)
        {
            CepService = _CepService;
        }
        /*public CepAppService(IServiceBase<Cep> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
