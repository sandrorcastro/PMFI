using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTipoTributosConf
{
    public int TipoTribId { get; set; }

    public short? Idmoeda { get; set; }

    public string? ConfTribTipo { get; set; }

    public decimal? ConfTribValor { get; set; }

    public string? ConfTribInfo { get; set; }

    public short? ConfTribDiaaVencer { get; set; }
}
