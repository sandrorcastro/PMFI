using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribCmtipoPavimentacao
{
    public int CmtipoPavId { get; set; }

    public string? CmtipoPavNome { get; set; }

    public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; } = new List<TribCmprocesso>();
}
