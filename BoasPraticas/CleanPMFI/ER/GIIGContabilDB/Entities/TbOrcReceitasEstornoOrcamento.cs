using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcReceitasEstornoOrcamento
{
    public int IdEstorno { get; set; }

    public int IdReceitaOrcamentoAnual { get; set; }

    public DateTime? DtEstorno { get; set; }

    public short? NrSequencia { get; set; }

    public decimal? VlOrcado { get; set; }
}
