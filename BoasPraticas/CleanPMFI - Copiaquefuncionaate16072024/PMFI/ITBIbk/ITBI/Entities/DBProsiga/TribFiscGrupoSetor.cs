using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscGrupoSetor
{
    public int GrupSetId { get; set; }

    public string? GrupSetNome { get; set; }

    public virtual ICollection<TribFiscSetor> TribFiscSetors { get; set; } = new List<TribFiscSetor>();
}
