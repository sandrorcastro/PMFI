using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LocTipoPagto
{
    public int TipoPagtoId { get; set; }

    public string? TipoPdescricao { get; set; }

    public string? TipoPtecUltAlt { get; set; }

    public DateTime? TipoPdtUltAlt { get; set; }

    public virtual ICollection<Locacao> Locacaos { get; set; } = new List<Locacao>();
}
