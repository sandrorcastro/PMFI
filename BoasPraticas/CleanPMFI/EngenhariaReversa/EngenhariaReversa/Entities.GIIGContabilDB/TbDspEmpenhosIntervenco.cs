using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEmpenhosIntervenco
    {
        public int IdEmpenho { get; set; }
        public int CdIntervencao { get; set; }

        public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
    }
}
