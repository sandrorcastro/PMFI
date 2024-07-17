using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbWflTiposProcesso
    {
        public TbWflTiposProcesso()
        {
            TbDspRms = new HashSet<TbDspRm>();
            TbWflFluxosTramitacaos = new HashSet<TbWflFluxosTramitacao>();
        }

        public short IdTipoProcesso { get; set; }
        public string? NmTipoProcesso { get; set; }
        public string? FlRestringeFluxo { get; set; }
        public string? CdNatDespesas { get; set; }

        public virtual ICollection<TbDspRm> TbDspRms { get; set; }
        public virtual ICollection<TbWflFluxosTramitacao> TbWflFluxosTramitacaos { get; set; }
    }
}
