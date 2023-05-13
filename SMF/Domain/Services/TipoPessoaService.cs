using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class TipoPessoaService : ServiceBase<TipoPessoa>, ITipoPessoaService
    {
        private readonly ITipoPessoaRepository Repository;

        public TipoPessoaService(ITipoPessoaRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<TipoPessoa> BuscarPorDescricao(string descricao)
        {
            return Repository.BuscarPorDescricao(descricao);
        }

       
    }
}
