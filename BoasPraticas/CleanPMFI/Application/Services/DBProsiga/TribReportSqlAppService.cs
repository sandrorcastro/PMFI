using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribReportSqlAppService : AppServiceBase<TribReportSql>, ITribReportSqlAppService
    {
        private readonly ITribReportSqlService TribReportSqlService;

        public TribReportSqlAppService(ITribReportSqlService _TribReportSqlService)
            : base(_TribReportSqlService)
        {
            TribReportSqlService = _TribReportSqlService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await TribReportSqlService.GeraNossoNumero(ConvenioId);
        }
        public async Task<TribReportSql> GeraNossoNumero(TribReportSql TribReportSql)
        {
            return await TribReportSqlService.GeraNossoNumero(TribReportSql);
        }*/
        /*public TribReportSqlAppService(IServiceBase<TribReportSql> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
