using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;

namespace Application.Services
{
    public class CidadeAppService : AppServiceBase<Cidade>, ICidadeAppService
    {
        public CidadeAppService(IServiceBase<Cidade> _serviceBase) : base(_serviceBase)
        {
        }
    }
}
