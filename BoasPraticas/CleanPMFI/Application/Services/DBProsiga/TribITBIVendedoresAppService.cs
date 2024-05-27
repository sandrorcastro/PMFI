using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class TribITBIVendedoresAppService : AppServiceBase<TribItbivendedore>, ITribITBIVendedoresAppService
    {
        private readonly ITribITBIVendedoresService Service;

        public TribITBIVendedoresAppService(ITribITBIVendedoresService _Service)
            : base(_Service)
        {
            Service = _Service;
        }
        /*public TribITBIAppService(IServiceBase<TribITBI> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
