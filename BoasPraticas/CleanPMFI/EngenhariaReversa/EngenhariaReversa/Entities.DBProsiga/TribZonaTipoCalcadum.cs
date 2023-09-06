using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribZonaTipoCalcadum
    {
        public TribZonaTipoCalcadum()
        {
            TiVis = new HashSet<TribZonaTipoViaUrbana>();
        }

        public int TiCaId { get; set; }
        public string? TiCaTipoCalcada { get; set; }
        public byte[]? TiCaImagemTipo { get; set; }

        public virtual ICollection<TribZonaTipoViaUrbana> TiVis { get; set; }
    }
}
