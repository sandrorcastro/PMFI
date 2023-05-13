using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class TipoProcessoService : ServiceBase<TipoProcesso>, ITipoProcessoService
    {
        private readonly ITipoProcessoRepository _Repository;

        public TipoProcessoService(ITipoProcessoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
