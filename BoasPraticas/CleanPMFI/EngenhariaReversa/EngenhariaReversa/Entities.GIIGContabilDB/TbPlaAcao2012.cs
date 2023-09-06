using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAcao2012
    {
        public int IdAcao { get; set; }
        public int IdAcao2012 { get; set; }

        public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;
    }
}
