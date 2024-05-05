using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class LocAtividade
{
    public int AtividadeId { get; set; }

    public string? AtivDescricao { get; set; }

    public string? AtivTecUltAlt { get; set; }

    public DateTime? AtivDtUltAlt { get; set; }

    public virtual ICollection<LocFilaEspera> LocFilaEsperas { get; set; } = new List<LocFilaEspera>();

    public virtual ICollection<Locacao> Locacaos { get; set; } = new List<Locacao>();
}
