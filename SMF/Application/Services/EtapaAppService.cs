using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using System;

namespace Application.Services
{
    public class EtapaAppService : AppServiceBase<Etapa>, IEtapaAppService
    {
        private readonly IEtapaService service;

        public EtapaAppService(IEtapaService _service)
            : base(_service)
        {
            service = _service;
        }
        public Etapa GetById(long ProcessoId, long ImovelId, long EconomiaId, int TipoEtapaId, int SituacaoEtapaId)
        {
            return service.GetById(ProcessoId,ImovelId,EconomiaId,TipoEtapaId,SituacaoEtapaId);
        }


    }
}
