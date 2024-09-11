using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class CepService : ServiceBase<Cep>, ICepService
    {
        private readonly ICepRepository _Repository;
        public CepService(ICepRepository repository) : base(repository)
        {
            _Repository = _Repository;
        }
    }
}
