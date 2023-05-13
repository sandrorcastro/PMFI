using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class TipoResponsabilidadeService : ServiceBase<TipoResponsabilidade>, ITipoResponsabilidadeService
    {
        private readonly ITipoResponsabilidadeRepository _Repository;

        public TipoResponsabilidadeService(ITipoResponsabilidadeRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
