using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscRelatorio
{
    public short FiscRelId { get; set; }

    public string? FiscRelDescricao { get; set; }

    public string? FiscRelNome { get; set; }

    public string? FiscRelParametros { get; set; }

    public string? FiscRelAbreviacao { get; set; }

    public long? TextoId { get; set; }
}
