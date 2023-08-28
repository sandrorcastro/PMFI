using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services.Base;
using Domain.Specification;

namespace Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        public PaisService(IRepositoryBase<Pais> _repository) : base(_repository)
        {
        }
    }
}
