using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IEconomiaRepository : IRepositoryBase<Economia>
    {
        public void UpdateEconomiaTemProcessos(Economia economia);
    }
}
