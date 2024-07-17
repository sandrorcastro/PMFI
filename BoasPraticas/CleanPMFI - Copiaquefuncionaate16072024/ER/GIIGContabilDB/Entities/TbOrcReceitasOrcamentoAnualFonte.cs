using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcReceitasOrcamentoAnualFonte
{
    public int IdReceitaOrcamentoAnual { get; set; }

    public int IdFonte { get; set; }

    public decimal? VlOrcado { get; set; }
}
