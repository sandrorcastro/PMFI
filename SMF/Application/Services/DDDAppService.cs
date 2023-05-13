using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class DDDAppService : AppServiceBase<DDD>, IDDDAppService
    {
        private readonly IDDDService service;

        public DDDAppService(IDDDService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<DDD> BuscarPorNumero(string numero)
        {
            return service.BuscarPorNumero(numero);
        }
    }
}
