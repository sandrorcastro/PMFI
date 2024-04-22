using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscTipoOcorrencium
{
    public int TipoOcorId { get; set; }

    public string? TipoOcorDescricao { get; set; }

    public string? TipoOcorInicial { get; set; }

    public string? TipoOcorAuto { get; set; }

    public virtual ICollection<TribFiscOrdemServicoOcorrencia> TribFiscOrdemServicoOcorrencia { get; set; } = new List<TribFiscOrdemServicoOcorrencia>();
}
