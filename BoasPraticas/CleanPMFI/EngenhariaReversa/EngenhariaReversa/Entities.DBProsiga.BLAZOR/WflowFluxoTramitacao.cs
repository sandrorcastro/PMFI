using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class WflowFluxoTramitacao
    {
        public WflowFluxoTramitacao()
        {
            WflowDespachoFluxos = new HashSet<WflowDespachoFluxo>();
        }

        public long FluxoTramId { get; set; }
        public long? TipoProcId { get; set; }
        public long? TipoFluxoId { get; set; }
        public int? FluxoTramNumOrdem { get; set; }

        public virtual WflowTiposFluxo? TipoFluxo { get; set; }
        public virtual WflowTipoProcesso? TipoProc { get; set; }
        public virtual ICollection<WflowDespachoFluxo> WflowDespachoFluxos { get; set; }
    }
}
