using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbOrcFontesGiiGcorrelacao
    {
        public int IdFonte { get; set; }
        public int IdCorrelacao { get; set; }

        public virtual TbOrcFontesCorrelacaoOrigen IdCorrelacaoNavigation { get; set; } = null!;
    }
}
