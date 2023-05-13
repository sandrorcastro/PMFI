using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class PessoaJuridicaAppService : AppServiceBase<PessoaJuridica>, IPessoaJuridicaAppService
    {
        private readonly IPessoaJuridicaService service;

        public PessoaJuridicaAppService(IPessoaJuridicaService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<PessoaJuridica> BuscarPorNome(string nome)
        {
            return service.BuscarPorNome(nome);
        }
    }
}
