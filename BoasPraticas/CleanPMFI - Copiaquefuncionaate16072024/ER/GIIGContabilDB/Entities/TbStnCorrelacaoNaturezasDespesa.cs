using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbStnCorrelacaoNaturezasDespesa
{
    public int IdCorrelacao { get; set; }

    public string? CdNatDespesaGiig { get; set; }

    public string? CdNatDespesaStn { get; set; }

    public short? NrAno { get; set; }
}
