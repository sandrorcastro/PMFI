using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class LogradouroService : ServiceBase<Logradouro>, ILogradouroService
    {
        private readonly ILogradouroRepository Repository;

        public LogradouroService(ILogradouroRepository _Repository)
            : base(_Repository)
        {
            Repository = _Repository;
        }

        public IEnumerable<Logradouro> BuscarPorDescricao(string descricao)
        {
            return Repository.BuscarPorDescricao(descricao);
        }

       
    }
}
