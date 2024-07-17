using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class PaisService : ServiceBase<Paise>, IPaisService
    {
        private readonly IPaisRepository _Repository;
        public PaisService(IPaisRepository repository) : base(repository)
        {
            _Repository = _Repository;
        }
    }
}
