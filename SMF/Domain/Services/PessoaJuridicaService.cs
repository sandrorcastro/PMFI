using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class PessoaJuridicaService : ServiceBase<PessoaJuridica>, IPessoaJuridicaService
    {
        private readonly IPessoaJuridicaRepository Repository;

        public PessoaJuridicaService(IPessoaJuridicaRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<PessoaJuridica> BuscarPorNome(string nome)
        {
            return Repository.BuscarPorNome(nome);
        }

       
    }
}
