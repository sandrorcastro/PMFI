using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribZonaTipoViaUrbanaTipoFaixaCalcadum
    {
        public int TiViId { get; set; }
        public int TiFaId { get; set; }
        public string? ViFaInstrucoes { get; set; }

        public virtual TribZonaTipoFaixaCalcadum TiFa { get; set; } = null!;
        public virtual TribZonaTipoViaUrbana TiVi { get; set; } = null!;
    }
}
