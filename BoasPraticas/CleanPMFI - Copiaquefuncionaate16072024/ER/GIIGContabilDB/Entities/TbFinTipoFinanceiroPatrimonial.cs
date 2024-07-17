using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTipoFinanceiroPatrimonial
{
    public short IdTipoFinanceiroPatrimonial { get; set; }

    public string? DsTipoFinanceiroPatrimonial { get; set; }

    public virtual ICollection<TbFinLancamentosPartidaDobrada> TbFinLancamentosPartidaDobrada { get; set; } = new List<TbFinLancamentosPartidaDobrada>();
}
