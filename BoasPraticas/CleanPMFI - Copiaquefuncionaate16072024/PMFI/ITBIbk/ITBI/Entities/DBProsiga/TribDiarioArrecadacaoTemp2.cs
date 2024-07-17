using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribDiarioArrecadacaoTemp2
{
    public DateTime? Data { get; set; }

    public string? CodReceita { get; set; }

    public string? Descricao { get; set; }

    public decimal? ArrecadadoDiario { get; set; }

    public decimal? ArrecadadoTribuario { get; set; }
}
