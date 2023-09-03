using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class UfService : ServiceBase<Uf>, IUfService
    {
        private readonly IUfRepository _Repository;

        public UfService(IUfRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
