using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class UfAppService : AppServiceBase<Uf>, IUfAppService
    {
        private readonly IUfService ufService;

        public UfAppService(IUfService _ufService)
            : base(_ufService)
        {
            ufService = _ufService;
        }
    }
}
