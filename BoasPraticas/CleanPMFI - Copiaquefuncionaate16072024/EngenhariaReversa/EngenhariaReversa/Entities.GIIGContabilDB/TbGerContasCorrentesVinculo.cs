using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerContasCorrentesVinculo
    {
        public int IdCc { get; set; }
        public int IdCcvinculada { get; set; }

        public virtual TbGerContasCorrente IdCcNavigation { get; set; } = null!;
    }
}
