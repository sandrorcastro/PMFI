using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribCalcInfTributo
{
    public short AnoCalculo { get; set; }

    public long EdificacaoId { get; set; }

    public int TipoTribId { get; set; }

    public decimal? Valor { get; set; }

    public int? Incidencia { get; set; }
}
