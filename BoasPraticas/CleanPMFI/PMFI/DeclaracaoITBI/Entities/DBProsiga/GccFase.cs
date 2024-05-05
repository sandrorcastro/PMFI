using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GccFase
{
    public string FaseCnpjmembro { get; set; } = null!;

    public int FaseId { get; set; }

    public int? FaseGrupoId { get; set; }

    public string? FaseDescr { get; set; }

    public int? FaseIdadeIni { get; set; }

    public int? FaseIdadeFim { get; set; }

    public virtual ICollection<GccCreFase> GccCreFases { get; set; } = new List<GccCreFase>();

    public virtual GccGruposFase? GccGruposFase { get; set; }
}
