using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class PessoaFisicaAppService : AppServiceBase<PessoaFisica>, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaService service;

        public PessoaFisicaAppService(IPessoaFisicaService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<PessoaFisica> BuscarPorNome(string nome)
        {
            return service.BuscarPorNome(nome);
        }
    }
}
