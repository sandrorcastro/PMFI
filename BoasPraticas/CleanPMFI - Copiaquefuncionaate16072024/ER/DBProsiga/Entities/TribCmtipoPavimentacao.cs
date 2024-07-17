using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCmtipoPavimentacao
{
    public int CmtipoPavId { get; set; }

    public string? CmtipoPavNome { get; set; }

    public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; } = new List<TribCmprocesso>();
}
