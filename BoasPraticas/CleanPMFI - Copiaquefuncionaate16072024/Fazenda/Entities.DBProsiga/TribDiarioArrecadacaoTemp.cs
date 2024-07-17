using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribDiarioArrecadacaoTemp
{
    public DateTime? Data { get; set; }

    public string? Tipo { get; set; }

    public string? CodReceita { get; set; }

    public string? Descricao { get; set; }

    public decimal? Arrecadado { get; set; }
}
