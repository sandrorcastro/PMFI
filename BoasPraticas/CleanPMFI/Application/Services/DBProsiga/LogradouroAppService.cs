using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;

namespace Application.Services.DBProsiga
{
    public class LogradouroAppService : AppServiceBase<Logradouro>, ILogradouroAppService
    {
        private readonly ILogradouroService ufService;

        public LogradouroAppService(ILogradouroService _ufService)
            : base(_ufService)
        {
            ufService = _ufService;
        }
    }
}
