
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEtapaAppService : IAppServiceBase<Etapa>
    {
        public Etapa GetById(long ProcessoId, long ImovelId, long EconomiaId, int TipoEtapaId, int SituacaoEtapaId);
    }
}
