using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class PerspectivaService : ServiceBase<Perspectiva>, IPerspectivaService
    {
        private readonly IPerspectivaRepository _Repository;

        public PerspectivaService(IPerspectivaRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
