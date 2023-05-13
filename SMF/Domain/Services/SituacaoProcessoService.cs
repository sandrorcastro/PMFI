using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class SituacaoProcessoService : ServiceBase<SituacaoProcesso>, ISituacaoProcessoService
    {
        private readonly ISituacaoProcessoRepository _Repository;

        public SituacaoProcessoService(ISituacaoProcessoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
