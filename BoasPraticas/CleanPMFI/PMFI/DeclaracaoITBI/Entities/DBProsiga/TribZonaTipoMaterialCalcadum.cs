using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribZonaTipoMaterialCalcadum
{
    public int TiMaId { get; set; }

    public string? TiMaTipoMaterial { get; set; }

    public virtual ICollection<TribZonaTabCalcadum> TribZonaTabCalcada { get; set; } = new List<TribZonaTabCalcadum>();
}
