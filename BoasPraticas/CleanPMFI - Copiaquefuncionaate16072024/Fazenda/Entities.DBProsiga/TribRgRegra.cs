using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribRgRegra
{
    public long IdRegra { get; set; }

    public string? NmRegra { get; set; }

    public string? DsRegra { get; set; }

    public string? VlRegra { get; set; }

    public string? TpRegra { get; set; }

    public string? TpRetorno { get; set; }

    public string? TpRotina { get; set; }

    public int? TipoTribId { get; set; }
}
