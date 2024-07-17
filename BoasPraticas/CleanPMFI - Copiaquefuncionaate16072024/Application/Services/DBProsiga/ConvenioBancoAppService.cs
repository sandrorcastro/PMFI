using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class ConvenioBancoAppService : AppServiceBase<ConvenioBanco>, IConvenioBancoAppService
    {
        private readonly IConvenioBancoService ConvenioBancoService;

        public ConvenioBancoAppService(IConvenioBancoService _ConvenioBancoService)
            : base(_ConvenioBancoService)
        {
            ConvenioBancoService = _ConvenioBancoService;
        }
        public async Task<long> GeraNossoNumero(int ConvenioId)
        {
            return await ConvenioBancoService.GeraNossoNumero(ConvenioId);
        }
        public async Task<ConvenioBanco> GeraNossoNumero(ConvenioBanco ConvenioBanco)
        {
            return await ConvenioBancoService.GeraNossoNumero(ConvenioBanco);
        }
        /*public ConvenioBancoAppService(IServiceBase<ConvenioBanco> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
