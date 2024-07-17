using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspUnidadesMedidum
    {
        public TbDspUnidadesMedidum()
        {
            TbDspItens = new HashSet<TbDspIten>();
        }

        public short IdUnidadeMedida { get; set; }
        public string? NmUnidadeMedida { get; set; }
        public short? IdUnidadeMedidaPadrao { get; set; }

        public virtual TbPlaUnidadesMedidasPadrao? IdUnidadeMedidaPadraoNavigation { get; set; }
        public virtual ICollection<TbDspIten> TbDspItens { get; set; }
    }
}
