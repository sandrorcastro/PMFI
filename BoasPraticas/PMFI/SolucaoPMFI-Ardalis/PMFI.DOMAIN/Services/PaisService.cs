

using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Repositories;
using PMFI.Domain.Interfaces.Services;

namespace PMFI.Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        public PaisService(IRepositoryBase<Pais> _repository) : base(_repository)
        {
        }
    }
}
