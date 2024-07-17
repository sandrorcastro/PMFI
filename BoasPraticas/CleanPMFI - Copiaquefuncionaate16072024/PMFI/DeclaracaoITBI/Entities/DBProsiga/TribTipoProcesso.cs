using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTipoProcesso
{
    public int TipoProcessoId { get; set; }

    public string? DsTipoProcesso { get; set; }

    public virtual ICollection<TribTipoProcessoTributo> TribTipoProcessoTributos { get; set; } = new List<TribTipoProcessoTributo>();
}
