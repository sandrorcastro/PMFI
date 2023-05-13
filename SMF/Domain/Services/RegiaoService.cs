using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class RegiaoService : ServiceBase<Regiao>, IRegiaoService
    {
        private readonly IRegiaoRepository Repository;

        public RegiaoService(IRegiaoRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<Regiao> BuscarPorDescricao(string descricao)
        {
            return Repository.BuscarPorDescricao(descricao);
        }

       
    }
}
