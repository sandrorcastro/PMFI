using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class BairroAppService : AppServiceBase<Bairro>, IBairroAppService
    {
        private readonly IBairroService service;

        public BairroAppService(IBairroService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<Bairro> BuscarPorDescricao(string descricao)
        {
            return service.BuscarPorDescricao(descricao);
        }
    }
}
