using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        public PaisService(IRepositoryBase<Pais> _repository) : base(_repository)
        {
        }
    }
}
