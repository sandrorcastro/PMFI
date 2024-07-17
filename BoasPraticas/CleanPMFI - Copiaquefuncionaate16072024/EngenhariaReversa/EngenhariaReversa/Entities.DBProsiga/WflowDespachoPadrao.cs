using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class WflowDespachoPadrao
    {
        public WflowDespachoPadrao()
        {
            WflowDespachoFluxos = new HashSet<WflowDespachoFluxo>();
            WflowRemessas = new HashSet<WflowRemessa>();
        }

        public long DespPadraoId { get; set; }
        public string? DespPadraoNome { get; set; }
        public string? InterrompeFluxo { get; set; }
        public string? CancelaRequisicao { get; set; }
        public string? RetornaOrigem { get; set; }
        public string? AprovaRequisicao { get; set; }

        public virtual ICollection<WflowDespachoFluxo> WflowDespachoFluxos { get; set; }
        public virtual ICollection<WflowRemessa> WflowRemessas { get; set; }
    }
}
