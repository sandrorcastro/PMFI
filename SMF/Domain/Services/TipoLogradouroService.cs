using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class TipoLogradouroService : ServiceBase<TipoLogradouro>, ITipoLogradouroService
    {
        private readonly ITipoLogradouroRepository _Repository;

        public TipoLogradouroService(ITipoLogradouroRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public IEnumerable<TipoLogradouro> BuscarPorDescricao(string descricao)
        {
            return _Repository.BuscarPorDescricao(descricao);
        }

       
    }
}
