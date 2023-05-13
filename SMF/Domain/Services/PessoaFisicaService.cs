using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class PessoaFisicaService : ServiceBase<PessoaFisica>, IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository Repository;

        public PessoaFisicaService(IPessoaFisicaRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<PessoaFisica> BuscarPorNome(string nome)
        {
            return Repository.BuscarPorNome(nome);
        }

       
    }
}
