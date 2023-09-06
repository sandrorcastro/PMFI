using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicLicitacaoTecnica
    {
        public int IdLicitacao { get; set; }
        public int IdTecnica { get; set; }
        public short? NrOrdem { get; set; }

        public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;
        public virtual TbLicTecnica IdTecnicaNavigation { get; set; } = null!;
    }
}
