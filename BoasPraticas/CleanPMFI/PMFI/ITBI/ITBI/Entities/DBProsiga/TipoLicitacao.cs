using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TipoLicitacao
{
    public int TplId { get; set; }

    public string? TplDescricao { get; set; }

    public string TplPadraoTce { get; set; } = null!;

    public virtual ICollection<ContratoConcessao> ContratoConcessaos { get; set; } = new List<ContratoConcessao>();
}
