using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribReportParAppService : AppServiceBase<TribReportPar>, ITribReportParAppService
    {
        private readonly ITribReportParService TribReportParService;

        public TribReportParAppService(ITribReportParService _TribReportParService)
            : base(_TribReportParService)
        {
            TribReportParService = _TribReportParService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await TribReportParService.GeraNossoNumero(ConvenioId);
        }
        public async Task<TribReportPar> GeraNossoNumero(TribReportPar TribReportPar)
        {
            return await TribReportParService.GeraNossoNumero(TribReportPar);
        }*/
        /*public TribReportParAppService(IServiceBase<TribReportPar> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
