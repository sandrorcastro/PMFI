using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribZonaTipoMaterialCalcadum
    {
        public TribZonaTipoMaterialCalcadum()
        {
            TribZonaTabCalcada = new HashSet<TribZonaTabCalcadum>();
        }

        public int TiMaId { get; set; }
        public string? TiMaTipoMaterial { get; set; }

        public virtual ICollection<TribZonaTabCalcadum> TribZonaTabCalcada { get; set; }
    }
}
