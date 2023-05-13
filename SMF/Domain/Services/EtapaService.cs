using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class EtapaService : ServiceBase<Etapa>, IEtapaService
    {
        private readonly IEtapaRepository _Repository;

        public EtapaService(IEtapaRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public Etapa GetById(long ProcessoId, long ImovelId, long EconomiaId, int TipoEtapaId, int SituacaoEtapaId)
        {
            return _Repository.GetById(ProcessoId, ImovelId, EconomiaId, TipoEtapaId, SituacaoEtapaId);
        }



    }
}
