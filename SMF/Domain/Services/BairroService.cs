using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class BairroService : ServiceBase<Bairro>, IBairroService
    {
        private readonly IBairroRepository Repository;

        public BairroService(IBairroRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<Bairro> BuscarPorDescricao(string descricao)
        {
            return Repository.BuscarPorDescricao(descricao);
        }

       
    }
}
