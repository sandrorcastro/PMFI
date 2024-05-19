using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class TribEdificacoesAppService : AppServiceBase<TribEdificaco>, ITribEdificacoesAppService
    {
        private readonly ITribEdificacoesService tribedificacoesService;

        public TribEdificacoesAppService(ITribEdificacoesService _tribedificacoesService)
            : base(_tribedificacoesService)
        {
            tribedificacoesService = _tribedificacoesService;
        }

        public async Task<TribEdificaco> GetByInscricaoImobiliaria(string inscricao)
        {
            return await tribedificacoesService.GetByInscricaoImobiliaria(inscricao);
        }


        /*public CidadeAppService(IServiceBase<Cidade> _serviceBase) : base(_serviceBase)
{
}*/
    }
}
