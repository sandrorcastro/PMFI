using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsTipoExecuco
    {
        public TbSbsTipoExecuco()
        {
            TbSbsSubvencaoSocials = new HashSet<TbSbsSubvencaoSocial>();
        }

        public short IdTipoExecucao { get; set; }
        public string? DsTipoExecucao { get; set; }

        public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; }
    }
}
