using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class EconomiaAppService : AppServiceBase<Economia>, IEconomiaAppService
    {
        private readonly IEconomiaService service;

        public EconomiaAppService(IEconomiaService _service)
            : base(_service)
        {
            service = _service;
        }
        public void UpdateEconomiaTemProcessos(Economia economia)
        {
            service.UpdateEconomiaTemProcessos(economia);
        }


    }
}
