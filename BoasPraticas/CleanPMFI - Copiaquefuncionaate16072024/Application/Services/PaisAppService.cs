using Application.Interfaces;
using Application.Services;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;
using Domain.Services;

namespace Application.Services
{
    public class PaisAppService : AppServiceBase<Pais>, IPaisAppService
    {
        private readonly IPaisService paisService;
        public PaisAppService(IPaisService _paisService)
            : base(_paisService)
        {
            paisService = _paisService;
        }




        /*  public PaisAppService(IServiceBase<Pais> _serviceBase) : base(_serviceBase)
          {
          }*/
    }
}



