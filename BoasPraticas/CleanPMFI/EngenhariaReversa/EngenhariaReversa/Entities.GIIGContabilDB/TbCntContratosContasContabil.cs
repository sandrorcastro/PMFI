using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntContratosContasContabil
    {
        public int IdContrato { get; set; }
        public int IdContaContabil { get; set; }

        public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;
    }
}
