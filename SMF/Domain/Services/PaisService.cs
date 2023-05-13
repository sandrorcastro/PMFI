using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        private readonly IPaisRepository _Repository;

        public PaisService(IPaisRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public IEnumerable<Pais> BuscarPorDescricao(string nome)
        {
            return _Repository.BuscarPorDescricao(nome);
        }

       
    }
}
