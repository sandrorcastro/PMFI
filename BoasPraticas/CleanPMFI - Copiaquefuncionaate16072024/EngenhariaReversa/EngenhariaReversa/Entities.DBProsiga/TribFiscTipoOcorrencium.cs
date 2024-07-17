using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscTipoOcorrencium
    {
        public TribFiscTipoOcorrencium()
        {
            TribFiscOrdemServicoOcorrencia = new HashSet<TribFiscOrdemServicoOcorrencia>();
        }

        public int TipoOcorId { get; set; }
        public string? TipoOcorDescricao { get; set; }
        public string? TipoOcorInicial { get; set; }
        public string? TipoOcorAuto { get; set; }

        public virtual ICollection<TribFiscOrdemServicoOcorrencia> TribFiscOrdemServicoOcorrencia { get; set; }
    }
}
