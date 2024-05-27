using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class TribITBIEdifAppService : AppServiceBase<TribItbiedif>, ITribITBIEdifAppService
    {
        private readonly ITribITBIEdifService Service;

        public TribITBIEdifAppService(ITribITBIEdifService _Service)
            : base(_Service)
        {
            Service = _Service;
        }
        /*public CidadeAppService(IServiceBase<Cidade> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
