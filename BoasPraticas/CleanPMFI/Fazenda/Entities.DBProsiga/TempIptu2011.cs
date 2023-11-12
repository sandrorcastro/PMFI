using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TempIptu2011
{
    public string? Inscricao { get; set; }

    public long? Edificacaoid { get; set; }

    public int? Tipotribid { get; set; }

    public string? Tipotribno { get; set; }

    public decimal? Valor { get; set; }

    public int? Tipobxid { get; set; }

    public string? Tipobxnome { get; set; }

    public int? Incidencia { get; set; }
}
