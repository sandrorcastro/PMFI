using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class RegiaoAppService : AppServiceBase<Regiao>, IRegiaoAppService
    {
        private readonly IRegiaoService service;

        public RegiaoAppService(IRegiaoService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<Regiao> BuscarPorDescricao(string descricao)
        {
            return service.BuscarPorDescricao(descricao);
        }
    }
}
