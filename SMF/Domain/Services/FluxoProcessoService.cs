using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class FluxoProcessoService : ServiceBase<FluxoProcesso>, IFluxoProcessoService
    {
        private readonly IFluxoProcessoRepository _Repository;

        public FluxoProcessoService(IFluxoProcessoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
