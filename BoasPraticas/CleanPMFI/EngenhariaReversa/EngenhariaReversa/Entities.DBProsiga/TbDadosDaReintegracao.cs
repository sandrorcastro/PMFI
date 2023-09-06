using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbDadosDaReintegracao
    {
        public int IdReintegracao { get; set; }
        public DateTime DtReintegracao { get; set; }
        public string DsReintegracao { get; set; } = null!;
        public string ObsReintegracao { get; set; } = null!;
        public int IdInvasao { get; set; }

        public virtual TbImoInvasao IdInvasaoNavigation { get; set; } = null!;
    }
}
