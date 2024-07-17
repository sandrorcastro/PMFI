using Application.Interfaces;
using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;


namespace Application.Services.DBProsiga
{
    public class LogradouroTipoAppService : AppServiceBase<Logradourotipo>, ILogradouroTipoAppService
    {
        private readonly ILogradouroTipoService ufService;

        public LogradouroTipoAppService(ILogradouroTipoService _ufService)
            : base(_ufService)
        {
            ufService = _ufService;
        }
    }
}
