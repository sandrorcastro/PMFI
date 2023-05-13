using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class SituacaoEtapaService : ServiceBase<SituacaoEtapa>, ISituacaoEtapaService
    {
        private readonly ISituacaoEtapaRepository _Repository;

        public SituacaoEtapaService(ISituacaoEtapaRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
