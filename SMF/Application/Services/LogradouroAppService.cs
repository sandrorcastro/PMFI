using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class LogradouroAppService : AppServiceBase<Logradouro>, ILogradouroAppService
    {
        private readonly ILogradouroService service;

        public LogradouroAppService(ILogradouroService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<Logradouro> BuscarPorDescricao(string descricao)
        {
            return service.BuscarPorDescricao(descricao);
        }
    }
}
