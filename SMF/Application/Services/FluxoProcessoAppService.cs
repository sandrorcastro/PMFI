using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class FluxoProcessoAppService : AppServiceBase<FluxoProcesso>, IFluxoProcessoAppService
    {
        private readonly IFluxoProcessoService service;

        public FluxoProcessoAppService(IFluxoProcessoService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
