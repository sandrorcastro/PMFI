using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VisaoLocarRelTaxa
{
    public int TaxaId { get; set; }

    public string? TaxNome { get; set; }

    public string? LocNome { get; set; }

    public int SubLocalId { get; set; }

    public string? SubLocNome { get; set; }

    public string ReceitaCodigo { get; set; } = null!;

    public int PeriodoId { get; set; }

    public string? PerDescricao { get; set; }

    public decimal? Uffivalor { get; set; }

    public decimal? TaxVlrEmUffi { get; set; }

    public int LocId { get; set; }

    public int TipoSubLocId { get; set; }

    public string? TsnmTipo { get; set; }
}
