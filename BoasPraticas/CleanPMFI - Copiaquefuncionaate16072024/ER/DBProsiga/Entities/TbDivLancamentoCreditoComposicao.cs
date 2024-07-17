using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbDivLancamentoCreditoComposicao
{
    public int IdCreditoDivida { get; set; }

    public int? IdCredito { get; set; }

    public long? ImoIddivida { get; set; }

    public long? ConIddivida { get; set; }

    public long? EmpIddivida { get; set; }

    public decimal? VlComposicao { get; set; }

    public int? IdEstono { get; set; }

    public bool? FlUnica { get; set; }

    public bool? FlExcluido { get; set; }

    public bool? FlDiferenca { get; set; }

    public virtual TbDivLancamentoCredito? IdCreditoNavigation { get; set; }
}
