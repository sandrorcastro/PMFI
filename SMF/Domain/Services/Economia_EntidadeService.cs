using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class Economia_EntidadeService : ServiceBase<Economia_Entidade>, IEconomia_EntidadeService
    {
        private readonly IEconomia_EntidadeRepository _Repository;

        public Economia_EntidadeService(IEconomia_EntidadeRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
