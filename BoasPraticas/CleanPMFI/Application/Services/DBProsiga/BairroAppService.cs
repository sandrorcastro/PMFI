using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;


namespace Application.Services.DBProsiga
{
    public class BairroAppService : AppServiceBase<Bairro>, IBairroAppService
    {
        private readonly IBairroService BairroService;

        public BairroAppService(IBairroService _BairroService)
            : base(_BairroService)
        {
            BairroService = _BairroService;
        }
        /*public BairroAppService(IServiceBase<Bairro> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
