using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class ContribuinteAppService : AppServiceBase<Contribuinte>, IContribuinteAppService
    {
        private readonly IContribuinteService contribuinteService;

        public ContribuinteAppService(IContribuinteService _contribuinteService)
            : base(_contribuinteService)
        {
            contribuinteService = _contribuinteService;
        }
        /*public ContribuinteAppService(IServiceBase<Contribuinte> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
