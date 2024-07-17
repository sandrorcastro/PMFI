using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicSituaco
{
    public short IdSituacao { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsSigla { get; set; }

    public bool? FlAtivo { get; set; }

    public short? CdTc { get; set; }

    public virtual ICollection<TbLicMovimentosSituaco> TbLicMovimentosSituacos { get; set; } = new List<TbLicMovimentosSituaco>();
}
