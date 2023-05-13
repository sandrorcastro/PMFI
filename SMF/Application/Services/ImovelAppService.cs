using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class ImovelAppService : AppServiceBase<Imovel>, IImovelAppService
    {
        private readonly IImovelService service;

        public ImovelAppService(IImovelService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
