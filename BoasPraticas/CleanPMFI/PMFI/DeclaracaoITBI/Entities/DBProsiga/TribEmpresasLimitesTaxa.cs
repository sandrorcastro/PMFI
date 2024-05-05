using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasLimitesTaxa
{
    public int LimId { get; set; }

    public int? TipoTribId { get; set; }

    public decimal? LimValorMinimo { get; set; }

    public decimal? LimValorMaximo { get; set; }

    public string LimCalcAtiv { get; set; } = null!;

    public virtual TribTipoTributo? TipoTrib { get; set; }
}
