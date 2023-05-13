using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository Repository;

        public PessoaService(IPessoaRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return Repository.BuscarPorNome(nome);
        }

       
    }
}
