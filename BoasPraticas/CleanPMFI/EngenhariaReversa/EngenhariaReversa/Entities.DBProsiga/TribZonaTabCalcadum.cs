using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribZonaTabCalcadum
    {
        public int TiTaId { get; set; }
        public decimal? TiTaDe { get; set; }
        public decimal? TiTaAte { get; set; }
        public int TiFaId { get; set; }
        public decimal? TiFaTamMinimo { get; set; }
        public int? TiMaId { get; set; }
        public int? TiViId { get; set; }
        public decimal? TiFaTamMaximo { get; set; }

        public virtual TribZonaTipoFaixaCalcadum TiFa { get; set; } = null!;
        public virtual TribZonaTipoMaterialCalcadum? TiMa { get; set; }
        public virtual TribZonaTipoViaUrbana? TiVi { get; set; }
    }
}
