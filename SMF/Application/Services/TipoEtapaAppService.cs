using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class TipoEtapaAppService : AppServiceBase<TipoEtapa>, ITipoEtapaAppService
    {
        private readonly ITipoEtapaService service;

        public TipoEtapaAppService(ITipoEtapaService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
