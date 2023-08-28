using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;

namespace Application.Services
{
    public class UfAppService : AppServiceBase<Uf>, IUfAppService
    {
        public UfAppService(IServiceBase<Uf> _serviceBase) : base(_serviceBase)
        {
        }
    }
}
