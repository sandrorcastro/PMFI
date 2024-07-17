using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
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
