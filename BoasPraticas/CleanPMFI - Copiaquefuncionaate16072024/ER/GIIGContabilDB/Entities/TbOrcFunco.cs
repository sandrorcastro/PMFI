using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcFunco
{
    public short NrAno { get; set; }

    public string CdFuncao { get; set; } = null!;

    public string? DsFuncao { get; set; }

    public virtual ICollection<TbOrcProgramasAco> TbOrcProgramasAcos { get; set; } = new List<TbOrcProgramasAco>();
}
