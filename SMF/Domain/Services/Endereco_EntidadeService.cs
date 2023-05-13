using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class Endereco_EntidadeService : ServiceBase<Endereco_Entidade>, IEndereco_EntidadeService
    {
        private readonly IEndereco_EntidadeRepository Repository;

        public Endereco_EntidadeService(IEndereco_EntidadeRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<Endereco_Entidade> BuscarPorDescricao(string descricao)
        {
            return Repository.BuscarPorDescricao(descricao);
        }

       
    }
}
