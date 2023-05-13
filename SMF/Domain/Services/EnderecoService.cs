using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository Repository;

        public EnderecoService(IEnderecoRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<Endereco> BuscarPorDescricao(string descricao)
        {
            return Repository.BuscarPorDescricao(descricao);
        }

       
    }
}
