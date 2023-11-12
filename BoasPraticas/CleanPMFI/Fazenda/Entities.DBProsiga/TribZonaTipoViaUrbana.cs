using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribZonaTipoViaUrbana
{
    public int TiViId { get; set; }

    public string? TiViTipoVia { get; set; }

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();

    public virtual ICollection<TribZonaTabCalcadum> TribZonaTabCalcada { get; set; } = new List<TribZonaTabCalcadum>();

    public virtual ICollection<TribZonaTipoViaUrbanaTipoFaixaCalcadum> TribZonaTipoViaUrbanaTipoFaixaCalcada { get; set; } = new List<TribZonaTipoViaUrbanaTipoFaixaCalcadum>();

    public virtual ICollection<TribZonaTipoCalcadum> TiCas { get; set; } = new List<TribZonaTipoCalcadum>();
}
