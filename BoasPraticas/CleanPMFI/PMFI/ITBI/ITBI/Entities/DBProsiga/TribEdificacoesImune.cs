using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEdificacoesImune
{
    public long EdificacaoId { get; set; }

    public int TipoTribId { get; set; }

    public short AnoIptu { get; set; }

    public string? ImuObservacao { get; set; }
}
