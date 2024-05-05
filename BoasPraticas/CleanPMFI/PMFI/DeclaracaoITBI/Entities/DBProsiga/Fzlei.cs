using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Fzlei
{
    /// <summary>
    /// Número e ano que identifica a lei.
    /// </summary>
    public string LeiNumAno { get; set; } = null!;

    /// <summary>
    /// Descrição da lei.
    /// </summary>
    public string LeiDescricao { get; set; } = null!;

    public virtual ICollection<Fzinfraco> Fzinfracos { get; set; } = new List<Fzinfraco>();
}
