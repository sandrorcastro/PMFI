using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class TipoResponsabilidadeAppService : AppServiceBase<TipoResponsabilidade>, ITipoResponsabilidadeAppService
    {
        private readonly ITipoResponsabilidadeService service;

        public TipoResponsabilidadeAppService(ITipoResponsabilidadeService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
