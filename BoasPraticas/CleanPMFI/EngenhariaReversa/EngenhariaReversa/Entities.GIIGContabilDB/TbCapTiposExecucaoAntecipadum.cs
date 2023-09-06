using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapTiposExecucaoAntecipadum
    {
        public TbCapTiposExecucaoAntecipadum()
        {
            TbCapExecucaoAntecipada = new HashSet<TbCapExecucaoAntecipadum>();
        }

        public short IdTipoExecucaoAntecipada { get; set; }
        public string? DsTipoExecucaoAntecipada { get; set; }

        public virtual ICollection<TbCapExecucaoAntecipadum> TbCapExecucaoAntecipada { get; set; }
    }
}
