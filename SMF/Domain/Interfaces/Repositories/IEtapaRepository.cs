using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IEtapaRepository : IRepositoryBase<Etapa>
    {
        public Etapa GetById(long ProcessoId, long ImovelId, long EconomiaId, int TipoEtapaId, int SituacaoEtapaId);
    }
}
