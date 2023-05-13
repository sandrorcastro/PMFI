using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class PaisAppService : AppServiceBase<Pais>, IPaisAppService
    {
        private readonly IPaisService service;

        public PaisAppService(IPaisService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<Pais> BuscarPorDescricao(string nome)
        {
            return service.BuscarPorDescricao(nome);
        }
    }
}
