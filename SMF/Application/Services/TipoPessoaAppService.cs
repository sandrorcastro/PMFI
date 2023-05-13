using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class TipoPessoaAppService : AppServiceBase<TipoPessoa>, ITipoPessoaAppService
    {
        private readonly ITipoPessoaService service;

        public TipoPessoaAppService(ITipoPessoaService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<TipoPessoa> BuscarPorDescricao(string descricao)
        {
            return service.BuscarPorDescricao(descricao);
        }
    }
}
