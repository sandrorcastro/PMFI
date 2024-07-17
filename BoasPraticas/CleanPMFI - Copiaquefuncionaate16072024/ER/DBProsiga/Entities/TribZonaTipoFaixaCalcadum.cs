using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZonaTipoFaixaCalcadum
{
    public int TiFaId { get; set; }

    public string? TiFaTipoFaixa { get; set; }

    public virtual ICollection<TribZonaTabCalcadum> TribZonaTabCalcada { get; set; } = new List<TribZonaTabCalcadum>();

    public virtual ICollection<TribZonaTipoViaUrbanaTipoFaixaCalcadum> TribZonaTipoViaUrbanaTipoFaixaCalcada { get; set; } = new List<TribZonaTipoViaUrbanaTipoFaixaCalcadum>();
}
