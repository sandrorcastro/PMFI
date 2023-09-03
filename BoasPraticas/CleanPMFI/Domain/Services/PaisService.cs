using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        private readonly IPaisRepository _Repository;
        public PaisService(IPaisRepository repository) : base(repository)
        {
            _Repository = _Repository;
        }
    }
}
