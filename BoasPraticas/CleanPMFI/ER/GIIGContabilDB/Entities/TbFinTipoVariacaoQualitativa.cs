using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTipoVariacaoQualitativa
{
    public short IdTipoVariacao { get; set; }

    public string? DsTipoVariacao { get; set; }

    public virtual ICollection<TbFinLancamentosPartidaDobrada> TbFinLancamentosPartidaDobrada { get; set; } = new List<TbFinLancamentosPartidaDobrada>();
}
