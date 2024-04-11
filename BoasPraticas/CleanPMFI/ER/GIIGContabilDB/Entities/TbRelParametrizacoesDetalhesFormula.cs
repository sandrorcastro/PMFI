using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRelParametrizacoesDetalhesFormula
{
    public int IdDetalheFormula { get; set; }

    public int? IdDetalhe { get; set; }

    public short? NrColuna { get; set; }

    public string? NmColuna { get; set; }

    public string? DsFormula { get; set; }

    public virtual ICollection<TbRelParametrizacoesExecuco> TbRelParametrizacoesExecucos { get; set; } = new List<TbRelParametrizacoesExecuco>();
}
