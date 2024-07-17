using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class TipoLogradouroAppService : AppServiceBase<TipoLogradouro>, ITipoLogradouroAppService
    {
        private readonly ITipoLogradouroService ufService;

        public TipoLogradouroAppService(ITipoLogradouroService _ufService)
            : base(_ufService)
        {
            ufService = _ufService;
        }
    }
}
