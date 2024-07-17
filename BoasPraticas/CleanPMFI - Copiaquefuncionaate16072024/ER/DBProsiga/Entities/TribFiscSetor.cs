using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscSetor
{
    public int SetorId { get; set; }

    public string? SetorNome { get; set; }

    public int GrupSetId { get; set; }

    public virtual TribFiscGrupoSetor GrupSet { get; set; } = null!;

    public virtual ICollection<TribFiscTipoProcedimento> TribFiscTipoProcedimentos { get; set; } = new List<TribFiscTipoProcedimento>();
}
