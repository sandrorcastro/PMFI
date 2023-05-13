using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class SituacaoProcessoAppService : AppServiceBase<SituacaoProcesso>, ISituacaoProcessoAppService
    {
        private readonly ISituacaoProcessoService service;

        public SituacaoProcessoAppService(ISituacaoProcessoService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
