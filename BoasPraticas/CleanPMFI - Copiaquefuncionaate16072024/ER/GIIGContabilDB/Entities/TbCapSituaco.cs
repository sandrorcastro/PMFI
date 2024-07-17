using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapSituaco
{
    public short IdSituacao { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsSigla { get; set; }

    public short? CdTc { get; set; }

    public virtual ICollection<TbCapConvAuxProgramasSituaco> TbCapConvAuxProgramasSituacos { get; set; } = new List<TbCapConvAuxProgramasSituaco>();
}
