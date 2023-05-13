using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService service;

        public PessoaAppService(IPessoaService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return service.BuscarPorNome(nome);
        }
    }
}
