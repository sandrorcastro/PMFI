using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribEmpresasAppService : AppServiceBase<TribEmpresa>, ITribEmpresasAppService
    {
        private readonly ITribEmpresasService TribEmpresasService;

        public TribEmpresasAppService(ITribEmpresasService _TribEmpresasService)
            : base(_TribEmpresasService)
        {
            TribEmpresasService = _TribEmpresasService;
        }
      /*  public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await TribEmpresasService.GeraNossoNumero(ConvenioId);
        }
        public async Task<TribEmpresas> GeraNossoNumero(TribEmpresas TribEmpresas)
        {
            return await TribEmpresasService.GeraNossoNumero(TribEmpresas);
        }*/
        /*public TribEmpresasAppService(IServiceBase<TribEmpresas> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
