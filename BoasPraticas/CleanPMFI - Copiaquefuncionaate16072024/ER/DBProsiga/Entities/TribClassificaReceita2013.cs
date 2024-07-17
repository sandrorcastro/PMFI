using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribClassificaReceita2013
{
    public DateTime ClreDataBaixa { get; set; }

    public int TipoTribId { get; set; }

    public string ClreReceita { get; set; } = null!;

    public int ConvenioId { get; set; }

    public string ClreTipo { get; set; } = null!;

    public decimal ClreValor { get; set; }
}
