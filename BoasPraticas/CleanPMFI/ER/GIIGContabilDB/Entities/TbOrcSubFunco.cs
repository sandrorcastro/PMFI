using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcSubFunco
{
    public short NrAno { get; set; }

    public string CdSubFuncao { get; set; } = null!;

    public string? DsSubFuncao { get; set; }

    public virtual ICollection<TbOrcProgramasAco> TbOrcProgramasAcos { get; set; } = new List<TbOrcProgramasAco>();
}
