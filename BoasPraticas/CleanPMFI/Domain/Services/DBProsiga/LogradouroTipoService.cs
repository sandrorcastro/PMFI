using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class LogradouroTipoService : ServiceBase<Logradourotipo>, ILogradouroTipoService
    {
        private readonly ILogradouroTipoRepository _Repository;

        public LogradouroTipoService(ILogradouroTipoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
