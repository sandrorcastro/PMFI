using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAtivGrupo
{
    public string AtivGrupo { get; set; } = null!;

    public string? AtivGrupoDenom { get; set; }

    public string? AtivDiv { get; set; }

    public virtual TribAtivDivisao? AtivDivNavigation { get; set; }

    public virtual ICollection<TribAtivClasse> TribAtivClasses { get; set; } = new List<TribAtivClasse>();

    public virtual ICollection<SerIturTipoEstabelecimento> TipoEstabs { get; set; } = new List<SerIturTipoEstabelecimento>();
}
