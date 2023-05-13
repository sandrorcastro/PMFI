using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class EconomiaService : ServiceBase<Economia>, IEconomiaService
    {
        private readonly IEconomiaRepository _Repository;

        public EconomiaService(IEconomiaRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public void UpdateEconomiaTemProcessos(Economia economia)
        {
            _Repository.UpdateEconomiaTemProcessos(economia);
        }



    }
}
