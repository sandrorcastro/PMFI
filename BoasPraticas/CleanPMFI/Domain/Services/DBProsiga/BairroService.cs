using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class BairroService : ServiceBase<Bairro>, IBairroService
    {
        private readonly IBairroRepository _Repository;
        public BairroService(IBairroRepository repository) : base(repository)
        {
            _Repository = _Repository;
        }
    }
}
