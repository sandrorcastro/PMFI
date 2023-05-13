
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEconomiaAppService : IAppServiceBase<Economia>
    {
        public void UpdateEconomiaTemProcessos(Economia economia);
    }
}
