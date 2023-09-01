using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;

namespace Application.Services
{
    public class PaisAppService : AppServiceBase<Pais>, IPaisAppService
    {
        public PaisAppService(IServiceBase<Pais> _serviceBase) : base(_serviceBase)
        {
        }
    }
}
