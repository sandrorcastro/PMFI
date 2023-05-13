using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class Economia_EntidadeAppService : AppServiceBase<Economia_Entidade>, IEconomia_EntidadeAppService
    {
        private readonly IEconomia_EntidadeService service;

        public Economia_EntidadeAppService(IEconomia_EntidadeService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
