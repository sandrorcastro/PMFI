using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class LogradouroService : ServiceBase<Logradouro>, ILogradouroService
    {
        private readonly ILogradouroRepository _Repository;

        public LogradouroService(ILogradouroRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
