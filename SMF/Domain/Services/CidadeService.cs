using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        private readonly ICidadeRepository _Repository;

        public CidadeService(ICidadeRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public IEnumerable<Cidade> BuscarPorDescricao(string nome)
        {
            return _Repository.BuscarPorDescricao(nome);
        }

       
    }
}
