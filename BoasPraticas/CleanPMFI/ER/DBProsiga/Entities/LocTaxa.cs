﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LocTaxa
{
    public int TaxaId { get; set; }

    public string? TaxNome { get; set; }

    public int? TaxSubLocalId { get; set; }

    public int? TaxPeriodoId { get; set; }

    public string? TaxReceitaCod { get; set; }

    /// <summary>
    /// Prazo de Pagto da Taxa en Dias
    /// </summary>
    public int? TaxPrazoPagto { get; set; }

    public decimal? TaxVlrEmUffi { get; set; }

    public string? TaxTecUltAlt { get; set; }

    public DateTime? TaxDtUltAlt { get; set; }

    public virtual ICollection<Locacao> Locacaos { get; set; } = new List<Locacao>();

    public virtual LocPeriodo? TaxPeriodo { get; set; }

    public virtual LocReceitum? TaxReceitaCodNavigation { get; set; }

    public virtual LocSubLocal? TaxSubLocal { get; set; }
}
