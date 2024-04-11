using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ImoveisIsentos2006
{
    public string InscricaoImobiliaria { get; set; } = null!;

    public decimal? EdifAreaConstruida { get; set; }

    public decimal? EdifAreaCoberta { get; set; }

    public int? TipoBxId { get; set; }

    public string? TipoBxNome { get; set; }
}
