using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapSituaco
    {
        public TbCapSituaco()
        {
            TbCapConvAuxProgramasSituacos = new HashSet<TbCapConvAuxProgramasSituaco>();
        }

        public short IdSituacao { get; set; }
        public string? DsSituacao { get; set; }
        public string? DsSigla { get; set; }
        public short? CdTc { get; set; }

        public virtual ICollection<TbCapConvAuxProgramasSituaco> TbCapConvAuxProgramasSituacos { get; set; }
    }
}
