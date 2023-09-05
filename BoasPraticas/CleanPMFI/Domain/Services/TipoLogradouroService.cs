using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class TipoLogradouroService : ServiceBase<TipoLogradouro>, ITipoLogradouroService
    {
        private readonly ITipoLogradouroRepository _Repository;

        public TipoLogradouroService(ITipoLogradouroRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
