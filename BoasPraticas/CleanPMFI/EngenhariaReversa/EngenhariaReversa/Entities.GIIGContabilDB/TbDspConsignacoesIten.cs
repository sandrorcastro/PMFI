using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspConsignacoesIten
    {
        public int IdConsignacao { get; set; }
        public int IdNatDespesa { get; set; }
        public decimal? VlTotal { get; set; }

        public virtual TbDspConsignaco IdConsignacaoNavigation { get; set; } = null!;
    }
}
