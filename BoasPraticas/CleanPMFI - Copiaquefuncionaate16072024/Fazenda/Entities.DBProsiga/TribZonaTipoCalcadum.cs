using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribZonaTipoCalcadum
{
    public int TiCaId { get; set; }

    public string? TiCaTipoCalcada { get; set; }

    public byte[]? TiCaImagemTipo { get; set; }

    public virtual ICollection<TribZonaTipoViaUrbana> TiVis { get; set; } = new List<TribZonaTipoViaUrbana>();
}
