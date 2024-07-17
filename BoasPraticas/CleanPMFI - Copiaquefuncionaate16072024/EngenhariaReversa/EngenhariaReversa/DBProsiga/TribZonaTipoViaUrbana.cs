using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribZonaTipoViaUrbana
    {
        public TribZonaTipoViaUrbana()
        {
            TribQuadraLograds = new HashSet<TribQuadraLograd>();
            TribZonaTabCalcada = new HashSet<TribZonaTabCalcadum>();
            TribZonaTipoViaUrbanaTipoFaixaCalcada = new HashSet<TribZonaTipoViaUrbanaTipoFaixaCalcadum>();
            TiCas = new HashSet<TribZonaTipoCalcadum>();
        }

        public int TiViId { get; set; }
        public string? TiViTipoVia { get; set; }

        public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; }
        public virtual ICollection<TribZonaTabCalcadum> TribZonaTabCalcada { get; set; }
        public virtual ICollection<TribZonaTipoViaUrbanaTipoFaixaCalcadum> TribZonaTipoViaUrbanaTipoFaixaCalcada { get; set; }

        public virtual ICollection<TribZonaTipoCalcadum> TiCas { get; set; }
    }
}
