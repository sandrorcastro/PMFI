using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class TipoProcessoAppService : AppServiceBase<TipoProcesso>, ITipoProcessoAppService
    {
        private readonly ITipoProcessoService service;

        public TipoProcessoAppService(ITipoProcessoService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
