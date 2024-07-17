using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspComponentesDespesa
    {
        public TbDspComponentesDespesa()
        {
            TbDspEmpenhosCompoentesDespesas = new HashSet<TbDspEmpenhosCompoentesDespesa>();
        }

        public short IdComponente { get; set; }
        public string? CdComponente { get; set; }
        public string? NmComponente { get; set; }
        public short? IdComponenteVinculo { get; set; }

        public virtual ICollection<TbDspEmpenhosCompoentesDespesa> TbDspEmpenhosCompoentesDespesas { get; set; }
    }
}
