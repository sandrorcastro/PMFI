using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbWflFluxosTramitacao
    {
        public TbWflFluxosTramitacao()
        {
            TbWflDespachosFluxos = new HashSet<TbWflDespachosFluxo>();
        }

        public short IdFluxoTramitacao { get; set; }
        public short? IdTipoProcesso { get; set; }
        public short? IdTipoFluxo { get; set; }
        public short? NrFluxoTramitacao { get; set; }

        public virtual TbWflTiposFluxo? IdTipoFluxoNavigation { get; set; }
        public virtual TbWflTiposProcesso? IdTipoProcessoNavigation { get; set; }
        public virtual ICollection<TbWflDespachosFluxo> TbWflDespachosFluxos { get; set; }
    }
}
