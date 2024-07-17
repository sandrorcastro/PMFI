using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Saptipo
{
    public string? Recnum { get; set; }

    public string? TipoProcesso { get; set; }

    public string? Descricao { get; set; }

    public string? TipoIndice { get; set; }

    public string? DiasPrimAtend { get; set; }

    public string? ProcessoJurid { get; set; }
}
