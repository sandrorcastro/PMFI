using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class Endereco_EntidadeAppService : AppServiceBase<Endereco_Entidade>, IEndereco_EntidadeAppService
    {
        private readonly IEndereco_EntidadeService service;

        public Endereco_EntidadeAppService(IEndereco_EntidadeService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<Endereco_Entidade> BuscarPorDescricao(string descricao)
        {
            return service.BuscarPorDescricao(descricao);
        }
    }
}
