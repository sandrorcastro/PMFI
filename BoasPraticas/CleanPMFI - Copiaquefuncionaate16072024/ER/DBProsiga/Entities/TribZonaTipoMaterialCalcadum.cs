using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZonaTipoMaterialCalcadum
{
    public int TiMaId { get; set; }

    public string? TiMaTipoMaterial { get; set; }

    public virtual ICollection<TribZonaTabCalcadum> TribZonaTabCalcada { get; set; } = new List<TribZonaTabCalcadum>();
}
