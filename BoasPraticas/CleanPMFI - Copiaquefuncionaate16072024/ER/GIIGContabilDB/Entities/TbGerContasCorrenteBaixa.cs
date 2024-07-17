using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerContasCorrenteBaixa
{
    public int IdBaixa { get; set; }

    public int IdCc { get; set; }

    public DateTime? DtDesativacao { get; set; }

    public string? DsMotivoDesativacao { get; set; }

    public DateTime? DtReversao { get; set; }

    public string? DsMotivoReversao { get; set; }

    public virtual TbGerContasCorrente IdCcNavigation { get; set; } = null!;
}
