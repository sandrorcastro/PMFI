using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class TipoEtapaService : ServiceBase<TipoEtapa>, ITipoEtapaService
    {
        private readonly ITipoEtapaRepository _Repository;

        public TipoEtapaService(ITipoEtapaRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
