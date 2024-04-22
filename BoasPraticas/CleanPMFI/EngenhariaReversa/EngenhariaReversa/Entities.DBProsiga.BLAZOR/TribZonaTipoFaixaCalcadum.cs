using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaTipoFaixaCalcadum
    {
        public TribZonaTipoFaixaCalcadum()
        {
            TribZonaTabCalcada = new HashSet<TribZonaTabCalcadum>();
            TribZonaTipoViaUrbanaTipoFaixaCalcada = new HashSet<TribZonaTipoViaUrbanaTipoFaixaCalcadum>();
        }

        public int TiFaId { get; set; }
        public string? TiFaTipoFaixa { get; set; }

        public virtual ICollection<TribZonaTabCalcadum> TribZonaTabCalcada { get; set; }
        public virtual ICollection<TribZonaTipoViaUrbanaTipoFaixaCalcadum> TribZonaTipoViaUrbanaTipoFaixaCalcada { get; set; }
    }
}
