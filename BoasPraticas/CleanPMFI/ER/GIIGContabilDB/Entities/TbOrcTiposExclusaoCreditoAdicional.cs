using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTiposExclusaoCreditoAdicional
{
    public int IdTipoExclusao { get; set; }

    public string? DsTipoExclusao { get; set; }

    public virtual ICollection<TbOrcLimitesCreditoAdicional> TbOrcLimitesCreditoAdicionals { get; set; } = new List<TbOrcLimitesCreditoAdicional>();
}
