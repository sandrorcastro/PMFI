using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinHistoricosPadrao
{
    public int CdHistorico { get; set; }

    public string? DsHistorico { get; set; }

    public int? CdEvento { get; set; }

    public bool? FlDesativado { get; set; }

    public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; } = new List<TbFinContasContabeisLancamentosAnalisador>();
}
