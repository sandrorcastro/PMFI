using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class DDDService : ServiceBase<DDD>, IDDDService
    {
        private readonly IDDDRepository _Repository;

        public DDDService(IDDDRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public IEnumerable<DDD> BuscarPorNumero(string numero)
        {
            return _Repository.BuscarPorNumero(numero);
        }

       
    }
}
