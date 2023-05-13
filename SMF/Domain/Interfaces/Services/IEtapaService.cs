using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IEtapaService : IServiceBase<Etapa>
    {
        public Etapa GetById(long ProcessoId, long ImovelId, long EconomiaId, int TipoEtapaId, int SituacaoEtapaId);
    }
}
