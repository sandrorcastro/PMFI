using Application.Interfaces.DBProsiga;
using Application.Services.DBProsiga;
using Application.Services.Base;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class PaisAppService : AppServiceBase<Paise>, IPaisAppService
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



