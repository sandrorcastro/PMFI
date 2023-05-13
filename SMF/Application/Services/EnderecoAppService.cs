using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService service;

        public EnderecoAppService(IEnderecoService _service)
            : base(_service)
        {
            service = _service;
        }

        public IEnumerable<Endereco> BuscarPorDescricao(string descricao)
        {
            return service.BuscarPorDescricao(descricao);
        }
    }
}
