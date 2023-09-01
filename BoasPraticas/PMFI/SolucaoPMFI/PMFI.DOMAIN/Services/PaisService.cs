

using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Services.Base;
using PMIFI.Domain.Interfaces.Base;

namespace PMFI.Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        public PaisService(IRepositoryBase<Pais> _repository) : base(_repository)
        {
        }
    }
}
