using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class PerspectivaAppService : AppServiceBase<Perspectiva>, IPerspectivaAppService
    {
        private readonly IPerspectivaService service;

        public PerspectivaAppService(IPerspectivaService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
