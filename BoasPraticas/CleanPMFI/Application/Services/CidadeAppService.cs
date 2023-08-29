using Application.Interfaces;
using Application.Services.Base;
using Application.ViewModels;
using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
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
