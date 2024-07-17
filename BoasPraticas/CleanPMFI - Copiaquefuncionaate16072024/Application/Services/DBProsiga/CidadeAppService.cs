using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class CidadeAppService : AppServiceBase<Cidade>, ICidadeAppService
    {
        private readonly ICidadeService cidadeService;

        public CidadeAppService(ICidadeService _cidadeService)
            : base(_cidadeService)
        {
            cidadeService = _cidadeService;
        }
        /*public CidadeAppService(IServiceBase<Cidade> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
