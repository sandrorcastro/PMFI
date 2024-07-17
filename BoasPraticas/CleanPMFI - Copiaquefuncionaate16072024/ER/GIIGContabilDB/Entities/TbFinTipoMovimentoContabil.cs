using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTipoMovimentoContabil
{
    public short IdTipoMovimento { get; set; }

    public string? DsTipoMovimento { get; set; }

    public virtual ICollection<TbFinLancamentosPartidaDobrada> TbFinLancamentosPartidaDobrada { get; set; } = new List<TbFinLancamentosPartidaDobrada>();
}
