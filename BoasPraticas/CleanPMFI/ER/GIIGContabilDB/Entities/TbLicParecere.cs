using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicParecere
{
    public short IdParecer { get; set; }

    public string? DsParecer { get; set; }

    public string? DsSigla { get; set; }

    public string? FlLiberaEdital { get; set; }

    public string? FlLiberaJulgamento { get; set; }

    public short? CdTc { get; set; }

    public string? FlAtivo { get; set; }

    public virtual ICollection<TbLicMovimentacoesParecer> TbLicMovimentacoesParecers { get; set; } = new List<TbLicMovimentacoesParecer>();
}
