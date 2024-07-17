using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbStnPlanoPadraoFonte
{
    public string? CdFontePadrao { get; set; }

    public string? CdOrigem { get; set; }

    public string? CdAplicacao { get; set; }

    public string? CdDesdobramento { get; set; }

    public string? CdDetalhamento { get; set; }

    public string? DsFonte { get; set; }

    public int? CdFontePadraoStn { get; set; }

    public DateTime? DtDesativacao { get; set; }

    public virtual TbStnFontePadrao? CdFontePadraoStnNavigation { get; set; }
}
