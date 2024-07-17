using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAdvertenciaTipoOrigem
{
    public int TipoAdvertId { get; set; }

    public string? TipoAdvertOrigem { get; set; }

    public virtual ICollection<TribAdvertencia> TribAdvertencia { get; set; } = new List<TribAdvertencia>();
}
