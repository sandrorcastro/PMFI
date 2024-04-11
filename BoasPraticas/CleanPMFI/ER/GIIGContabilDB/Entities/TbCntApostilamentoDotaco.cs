using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntApostilamentoDotaco
{
    public int IdAtoContratual { get; set; }

    public int IdDotacao { get; set; }

    public DateTime? DtVinculacao { get; set; }

    public decimal? VlPrevisto { get; set; }

    public bool? FlBloqueiaSaldo { get; set; }

    public virtual TbCntAtosContratuai IdAtoContratualNavigation { get; set; } = null!;

    public virtual TbOrcDotaco IdDotacaoNavigation { get; set; } = null!;
}
