using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class SituacaoEtapaAppService : AppServiceBase<SituacaoEtapa>, ISituacaoEtapaAppService
    {
        private readonly ISituacaoEtapaService service;

        public SituacaoEtapaAppService(ISituacaoEtapaService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
