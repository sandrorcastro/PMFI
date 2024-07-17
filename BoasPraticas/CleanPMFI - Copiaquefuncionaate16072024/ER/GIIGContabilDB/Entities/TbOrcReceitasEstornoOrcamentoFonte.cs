using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcReceitasEstornoOrcamentoFonte
{
    public int IdEstorno { get; set; }

    public int IdFonte { get; set; }

    public decimal? VlOrcado { get; set; }
}
