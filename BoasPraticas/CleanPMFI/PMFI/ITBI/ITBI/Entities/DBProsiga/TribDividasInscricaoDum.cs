using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribDividasInscricaoDum
{
    public long IdInscricaoDa { get; set; }

    public string? TpCadastro { get; set; }

    public long IdDivida { get; set; }

    public long IdDividaOrigem { get; set; }

    public bool? FlEstornada { get; set; }

    public string? DsNumProcData { get; set; }
}
